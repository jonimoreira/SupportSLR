using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportSLR
{
    public partial class frmSpringer : Form
    {
        public frmSpringer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchSpringerLink();
            
        }

        private void SearchSpringerLink()
        {
            string basicURL = textBox3.Text;
            string querystring = textBox2.Text;
            string titleLocator = textBox4.Text;
            string basicURLforResult = "http://link.springer.com/";

            int page = 1;
            int page_end = 1;
            int numResult = 1;
            bool hasPages = true;
            page = int.Parse(textBox5.Text);
            page_end = int.Parse(textBox6.Text);

            while (hasPages)
            {
                string resultsFromSearch = string.Empty;
                try
                {
                    resultsFromSearch = GetContentFromURL(String.Format(basicURL, page) + querystring);
                }
                catch (Exception ex)
                {
                    textBox1.Text += "Error on: " + String.Format(basicURL, page) + querystring + System.Environment.NewLine;
                }

                if (resultsFromSearch != string.Empty)
                {
                    List<string> listResults = resultsFromSearch.Split(new string[] { titleLocator }, StringSplitOptions.None).ToList();
                    hasPages = false;
                    foreach (string result in listResults)
                    {
                        string resultTrim = result.Trim();
                        if (resultTrim.StartsWith("href="))
                        {
                            hasPages = true;

                            string token01 = "href=\"";
                            string urlResult = resultTrim.Substring(resultTrim.IndexOf(token01) + token01.Length, resultTrim.IndexOf("\">") - token01.Length);

                            string contentResult = string.Empty;
                            contentResult = GetContentFromURL(basicURLforResult + urlResult).Trim();
                            
                            SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter searchResultItemTableAdapter = new SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter();
                            SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow = supportSLRDataSet.SearchResultItem.NewSearchResultItemRow();
                            newSearchResultItemRow.fk_QueryDataSourceRound_id = 9; // (int)comboBox1.SelectedValue;
                            newSearchResultItemRow.url = urlResult;
                            newSearchResultItemRow.page_content = contentResult;
                            newSearchResultItemRow.errors_onload = string.Empty;

                            // Create Id to reference on downloaded file names 
                            supportSLRDataSet.SearchResultItem.Rows.Add(newSearchResultItemRow);
                            searchResultItemTableAdapter.Update(supportSLRDataSet.SearchResultItem);

                            // Find and download Endnote file (enw)
                            try
                            {
                                FindDownloadEndnoteFile(newSearchResultItemRow, contentResult, numResult, basePathSpringerLink);
                            }
                            catch (Exception ex)
                            {
                                newSearchResultItemRow.errors_onload += "FindDownloadEndnoteFile: " + ex.Message + ex.Source + System.Environment.NewLine;
                            }

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
        }

        private void FindProperties(SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow, string contentResult)
        {
            string token02 = "<title>";
            string token03 = "</title>";
            string title = contentResult.Substring(contentResult.IndexOf(token02) + token02.Length);
            title = title.Substring(0, title.IndexOf(token03));
            title = title.Replace(" - Springer", string.Empty).Replace(" | SpringerLink", string.Empty);

            string token04 = "<h2 class=\"Heading\">Abstract</h2>";
            string valAbstract = contentResult.Substring(contentResult.IndexOf(token04) + token04.Length).Trim();

            string token05 = "<p class=\"Para\">";
            valAbstract = valAbstract.Replace(token05, string.Empty);

            string token06 = "</p>";
            valAbstract = valAbstract.Substring(0, valAbstract.IndexOf(token06));

            string token07 = "<span class=\"Keyword\">";
            List<string> tempKeywords = contentResult.Split(new string[] { token07 }, StringSplitOptions.None).ToList();
            List<string> keywords = new List<string>();
            int idxKeywords = 0;
            foreach (string tempKeyword in tempKeywords)
            {
                if (idxKeywords > 0)
                {
                    string token08 = "</span>";
                    string keyword = tempKeyword.Substring(0, tempKeyword.IndexOf(token08));
                    keywords.Add(keyword);
                }
                idxKeywords++;
            }

            string tokenPages = "<input type=\"hidden\" name=\"pages\" value=\"";
            string pages = string.Empty;
            if (contentResult.IndexOf(tokenPages) > 0)
            {
                pages = contentResult.Substring(contentResult.IndexOf(tokenPages));
                pages = pages.Substring(0, pages.IndexOf("\""));
            }
            else
            {
                tokenPages = "span class=\"ArticleCitation_Pages\">";
                if (contentResult.IndexOf(tokenPages) > 0)
                {
                    pages = contentResult.Substring(contentResult.IndexOf(tokenPages) + tokenPages.Length);
                    pages = pages.Substring(0, pages.IndexOf("</span>"));
                }
            }

            string tokenYear = "<input type=\"hidden\" name=\"year\" value=\"";
            string year = string.Empty;
            if (contentResult.IndexOf(tokenYear) > 0)
            {
                year = contentResult.Substring(contentResult.IndexOf(tokenYear));
                year = year.Substring(0, year.IndexOf("\""));
            }
            else
            {
                tokenYear = "<time>";
                if (contentResult.IndexOf(tokenYear) > 0)
                {
                    year = contentResult.Substring(contentResult.IndexOf(tokenYear) + tokenYear.Length);
                    year = year.Substring(0, year.IndexOf("</time>"));
                }
            }

            string tokenType = "<input type=\"hidden\" name=\"type\" value=\"";
            if (contentResult.IndexOf(tokenType) > 0)
            {
                string type = contentResult.Substring(contentResult.IndexOf(tokenType));
                type = type.Substring(0, type.IndexOf("\""));
                newSearchResultItemRow.type = type;
            }

            newSearchResultItemRow.title = title;
            newSearchResultItemRow._abstract = valAbstract;
            newSearchResultItemRow.pages = pages;
            newSearchResultItemRow.date_publication = year;
            

        }

        private void FindDownloadEndnoteFile(SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow, string contentResult, int numResult, string basePath)
        {
            string token02 = "endnote&amp;";
            List<string> partsUrlEndnote = contentResult.Split(new string[] { token02 }, StringSplitOptions.None).ToList();
            if (partsUrlEndnote.Count == 2)
            {
                string token03 = "href=\"";
                List<string> temp = partsUrlEndnote[0].Split(new string[] { token03 }, StringSplitOptions.None).ToList();
                string part1 = temp[temp.Count - 1];

                string token04 = "\"";
                temp = partsUrlEndnote[1].Split(new string[] { token04 }, StringSplitOptions.None).ToList();
                string part2 = temp[0];

                string path = basePath + "SearchResultItemRow_id_" + newSearchResultItemRow.id.ToString("0000") + ".enw";
                string urlDownload = part1 + token02 + part2;
                urlDownload = urlDownload.Replace("&#x3D", string.Empty);
                DownloadFile(newSearchResultItemRow, urlDownload, path);

                newSearchResultItemRow.endnote_url = urlDownload;
                
            }

        }

        private static string basePathSpringerLink = @"C:\Users\joao.moreira\Documents\SLR\App\SupportSLR\FilesDownloaded\SpringerLink\";

        private void DownloadFile(SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow, string url, string filepath)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.QueryString.Add("filepath", filepath);
            webClient.QueryString.Add("SearchResultItem.id", newSearchResultItemRow.id.ToString());
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri(url), filepath);
            webClient.Dispose();
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //progressBar.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("Download completed!");
            string filepath = ((System.Net.WebClient)(sender)).QueryString["filepath"];
            int id = int.Parse(((System.Net.WebClient)(sender)).QueryString["SearchResultItem.id"]);

            textBox1.Text += "download completed: " + filepath + System.Environment.NewLine;
            
            // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader(filepath))
            {
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter searchResultItemTableAdapter = new SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter();
                SupportSLRDataSet.SearchResultItemRow searchResultItemRow = supportSLRDataSet.SearchResultItem.FindByid(id);
                searchResultItemRow.endnote_content = line;
                searchResultItemTableAdapter.Update(supportSLRDataSet.SearchResultItem);
                searchResultItemTableAdapter.Dispose();
            }
            
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
            catch(Exception ex)
            {
                textBox1.Text += "Error on GetContentFromURL: " + url + System.Environment.NewLine;
            }

            return string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void queryDataSourceRoundBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.queryDataSourceRoundBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.supportSLRDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supportSLRDataSet.QueryDataSourceRound' table. You can move, or remove it, as needed.
            this.queryDataSourceRoundTableAdapter.Fill(this.supportSLRDataSet.QueryDataSourceRound);

        }
    }
}
