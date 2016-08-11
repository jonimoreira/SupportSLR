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
    public partial class frmGoogleScholar : Form
    {
        public frmGoogleScholar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchGoogleScholar();
        }

        private void SearchGoogleScholar()
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
                string url = String.Format(basicURL + querystring, (page - 1)*10);

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
                    hasPages = false;

                    foreach (string result in listResults)
                    {
                        string resultTrim = result.Trim();

                        if (resultTrim.StartsWith("<a") || resultTrim.StartsWith("<span class"))
                        {
                            hasPages = true;

                            string token01 = "href=\"";
                            string urlResult = resultTrim.Substring(resultTrim.IndexOf(token01) + token01.Length);
                            urlResult = urlResult.Substring(0, urlResult.IndexOf("\""));

                            string contentResult = string.Empty;
                            contentResult = GetContentFromURL(urlResult).Trim();

                            SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter searchResultItemTableAdapter = new SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter();
                            SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow = supportSLRDataSet.SearchResultItem.NewSearchResultItemRow();
                            newSearchResultItemRow.fk_QueryDataSourceRound_id = 10; //(int)comboBox1.SelectedValue;
                            newSearchResultItemRow.url = urlResult;
                            newSearchResultItemRow.page_content = contentResult;
                            newSearchResultItemRow.errors_onload = string.Empty;

                            // Create Id to reference on downloaded file names 
                            supportSLRDataSet.SearchResultItem.Rows.Add(newSearchResultItemRow);
                            searchResultItemTableAdapter.Update(supportSLRDataSet.SearchResultItem);

                            /*
                             * Not done because on the first page of the results it iss possible to export all results in a single file (to be used afterwards to cite in Word)
                            // Find and download Endnote file (enw)
                            try
                            {
                                FindDownloadEndnoteFile(newSearchResultItemRow, contentResult, numResult, basePathSpringerLink);
                            }
                            catch (Exception ex)
                            {
                                newSearchResultItemRow.errors_onload += "FindDownloadEndnoteFile: " + ex.Message + ex.Source + System.Environment.NewLine;
                            }
                            */


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
                }

                page++;

                if (page > page_end)
                    hasPages = false;
            }
        }

        private void FindProperties(SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow, string contentResult)
        {
            string tokenTitle = "<title>";
            string token03 = "</title>";
            string title = contentResult.Substring(contentResult.ToLower().IndexOf(tokenTitle) + tokenTitle.Length);
            //title = title.Substring(title.IndexOf(token03) + token03.Length);
            title = title.Substring(0, title.ToLower().IndexOf(token03)).Replace(System.Environment.NewLine, "").Trim().Replace(" - Springer", string.Empty).Replace(" | SpringerLink", string.Empty).Replace(" | HTML", string.Empty).Replace(" | HazNet", string.Empty);

            string temp = "| Free Full-Text |";
            if (title.Contains(temp))
                title = title.Substring(title.IndexOf(temp) + temp.Length);

            temp = "<title";
            if (title.Contains(temp))
            {
                title = title.Substring(title.IndexOf(temp) + temp.Length);
                temp = ">";
                if (title.Contains(temp))
                    title = title.Substring(title.IndexOf(temp) + temp.Length);

                temp = " | ";
                if (title.Contains(temp))
                    title = title.Substring(0, title.IndexOf(temp));
            }
            string token = "<p class=\"volIssue\">";
            string volIssue = contentResult.Substring(contentResult.IndexOf(token) + token.Length);

            string tokenPages = "Pages";
            string pages = volIssue;
            if (contentResult.IndexOf(tokenPages) > 0)
            {
                temp = ", Pages ";
                if (pages.Contains(temp))
                {
                    pages = pages.Substring(pages.IndexOf(temp) + temp.Length).Trim();
                    temp = ",";
                    if (pages.Contains(temp))
                        pages = pages.Substring(0, pages.IndexOf(temp)).Trim();
                }
                else
                {
                    pages = volIssue.Substring(volIssue.IndexOf(tokenPages));
                    pages = pages.Substring(0, pages.IndexOf("</p>"));
                    pages = pages.Replace("Pages", "").Replace("pp", "").Trim();
                }

                temp = "postProcessingHook\">";
                if (pages.Contains(temp))
                    pages = pages.Substring(pages.IndexOf(temp) + temp.Length).Trim();

                temp = "page-ranges\">";
                if (pages.Contains(temp))
                    pages = pages.Substring(pages.IndexOf(temp)+temp.Length).Trim();

                temp = "</dd>";
                if (pages.Contains(temp))
                    pages = pages.Substring(0, pages.IndexOf(temp)).Trim();


                temp = "\">";
                if (pages.StartsWith(temp))
                    pages = pages.Substring(pages.IndexOf(temp)+temp.Length);

                if (pages.Contains(temp))
                    pages = pages.Substring(0, pages.IndexOf(temp));

                temp = "</";
                if (pages.Contains(temp))
                    pages = pages.Substring(0, pages.IndexOf(temp));


            }
            else
            {
                tokenPages = @"\d+(?:-\d+)?(?:,\d+(?:-\d+)?)*";

                Regex regexPages = new Regex(tokenPages);
                Match matchPages = regexPages.Match(volIssue);
                if (matchPages.Success)
                {
                    pages = matchPages.Value;
                }
            }

            if (volIssue.StartsWith("<a"))
                volIssue = volIssue.Substring(volIssue.IndexOf(">"));

            string year = volIssue;
            temp = "copyrightyear\" value=\"";
            if (year.Contains(temp))
                year = year.Substring(year.IndexOf(temp)+temp.Length);

            temp = "publicationDate\" content=\"";
            if (year.Contains(temp))
                year = year.Substring(year.IndexOf(temp) + temp.Length);

            temp = "Publication date </div><div class=\"display_record_indexing_data\"><span class=\"subjectField-postProcessingHook\">";
            if (year.Contains(temp))
                year = year.Substring(year.IndexOf(temp) + temp.Length);

            temp = "Publication History";
            if (year.Contains(temp))
                year = year.Substring(year.IndexOf(temp) + temp.Length);
            
            string tokenYear = @"(19|20)\d\d";
            Regex regex = new Regex(tokenYear);
            Match match = regex.Match(year);
            if (match.Success)
            {
                year = match.Value;
            }

            string tokenTypeBook = "book/";
            string tokenTypeJournal = "journal/";
            string type = string.Empty;
            if (contentResult.IndexOf(tokenTypeBook) > 0)
            {
                type = "Book Section";
            }
            else if (contentResult.IndexOf(tokenTypeJournal) > 0)
            {
                type = "Journal";
            }
            else
            {
                type = "Conference proceeding";
            }

            temp = "Publication title";
            if (volIssue.Contains(temp))
            {
                volIssue = volIssue.Substring(volIssue.IndexOf(temp) + temp.Length, 300);
                if (volIssue.ToLower().Contains("journal"))
                    type = "Journal";

            }

            newSearchResultItemRow.title = title;
            //newSearchResultItemRow._abstract = valAbstract;
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
