using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportSLR
{
    public partial class frmWiley : Form
    {
        public frmWiley()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchWiley();
        }

        private void SearchWiley()
        {
            string basicURL = textBox3.Text;
            string querystring = textBox2.Text;
            string titleLocator = textBox4.Text;

            int page = 1;
            int page_end = 1;
            int numResult = 1;
            bool hasPages = true;
            page = int.Parse(textBox5.Text);
            page_end = int.Parse(textBox6.Text);


            while (hasPages)
            {
                string resultsFromSearch = string.Empty;
                string url = String.Format(basicURL + querystring, (page - 1)*20 + 1);

                try
                {
                    resultsFromSearch = GetContentFromURL(url);
                }
                catch (Exception ex)
                {
                    textBox1.Text += "Error on: " + url + System.Environment.NewLine;
                }

                if (resultsFromSearch != string.Empty)
                {
                    List<string> listResults = resultsFromSearch.Split(new string[] { titleLocator }, StringSplitOptions.None).ToList();
                    listResults.RemoveAt(0);
                    hasPages = false;

                    foreach (string result in listResults)
                    {
                        string resultTrim = result.Trim();
                       
                        hasPages = true;

                        string token01 = "href=\"";
                        string urlResult = resultTrim.Substring(resultTrim.IndexOf(token01) + token01.Length);
                        urlResult = basicURL + urlResult.Substring(0, urlResult.IndexOf("\"")).Replace("&lt;", "%3C").Replace("&gt;", "%3E");

                        string contentResult = string.Empty;
                        contentResult = GetContentFromURL(urlResult).Trim();

                        SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter searchResultItemTableAdapter = new SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter();
                        SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow = supportSLRDataSet.SearchResultItem.NewSearchResultItemRow();
                        newSearchResultItemRow.fk_QueryDataSourceRound_id = 6; //(int)comboBox1.SelectedValue;
                        newSearchResultItemRow.url = urlResult;
                        newSearchResultItemRow.page_content = contentResult;
                        newSearchResultItemRow.errors_onload = string.Empty;

                        // Create Id to reference on downloaded file names 
                        supportSLRDataSet.SearchResultItem.Rows.Add(newSearchResultItemRow);
                        searchResultItemTableAdapter.Update(supportSLRDataSet.SearchResultItem);
                        
                        // Find properties of the result (title, abstract, keywords, year, pages, data source type)
                        try
                        {
                            FindProperties(newSearchResultItemRow, contentResult);
                        }
                        catch (Exception ex)
                        {
                            newSearchResultItemRow.errors_onload += "FindProperties: " + ex.Message + ex.Source + System.Environment.NewLine;
                        }

                        searchResultItemTableAdapter.Update(supportSLRDataSet.SearchResultItem);
                        searchResultItemTableAdapter.Dispose();

                        numResult++;

                        
                    }
                }

                page++;

                if (page > page_end)
                    hasPages = false;
            }
        }

        private void FindProperties(SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow, string contentResult)
        {
            string temp = "name=\"citation_title\" content=\"";
            string title = contentResult.Substring(contentResult.ToLower().IndexOf(temp) + temp.Length);
            temp = "\" />";
            title = title.Substring(0, title.ToLower().IndexOf(temp)).Replace(System.Environment.NewLine, "").Trim().Replace("&ndash;", "–").Replace("&#x2010;", "-");

            temp = "name=\"citation_firstpage\" content=\"";
            string pages = string.Empty;
            if (contentResult.Contains(temp))
            {
                pages = contentResult.Substring(contentResult.ToLower().IndexOf(temp) + temp.Length);
                temp = "\" />";
                pages = pages.Substring(0, pages.ToLower().IndexOf(temp)).Replace(System.Environment.NewLine, "").Trim();

                temp = "name=\"citation_lastpage\" content=\"";
                pages += "-" + contentResult.Substring(contentResult.ToLower().IndexOf(temp) + temp.Length);
                temp = "\" />";
                pages = pages.Substring(0, pages.ToLower().IndexOf(temp)).Replace(System.Environment.NewLine, "").Trim();
            }

            string year = string.Empty;
            temp = "name=\"citation_publication_date\" content=\"";
            if (contentResult.Contains(temp))
            {
                year = contentResult.Substring(contentResult.ToLower().IndexOf(temp) + temp.Length);
                temp = "\" />";
                year = year.Substring(0, year.ToLower().IndexOf(temp)).Replace(System.Environment.NewLine, "").Trim();
                Regex regex = new Regex(@"(19|20)\d\d");
                Match match = regex.Match(year);
                if (match.Success)
                {
                    year = match.Value;
                }
            }
            else
            {
                temp = "name=\"citation_online_date\" content=\"";
                if (contentResult.Contains(temp))
                {
                    year = contentResult.Substring(contentResult.ToLower().IndexOf(temp) + temp.Length);
                    temp = "\" />";
                    year = year.Substring(0, year.ToLower().IndexOf(temp)).Replace(System.Environment.NewLine, "").Trim();
                    Regex regex = new Regex(@"(19|20)\d\d");
                    Match match = regex.Match(year);
                    if (match.Success)
                    {
                        year = match.Value;
                    }
                }
            }

            string type = string.Empty;
            temp = "citation_book_title";
            if (contentResult.IndexOf(temp) > 0)
                type = "Book Section";
            else
            {
                temp = "citation_journal_title";
                if (contentResult.IndexOf(temp) > 0)
                {
                    type = "Journal";
                }
                else
                {
                    type = "Conference proceeding";
                }
            }
            
            newSearchResultItemRow.title = title;
            newSearchResultItemRow.pages = pages;
            newSearchResultItemRow.date_publication = year;
            newSearchResultItemRow.type = type;

        }

        private string GetContentFromURL(string url)
        {
            // Create a request for the URL. 
            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                response.Close();
                return responseFromServer;
            }
            catch (Exception ex)
            {
                textBox1.Text += "Error on GetContentFromURL: " + url + System.Environment.NewLine;
            }

            return string.Empty;
        }

    }
}
