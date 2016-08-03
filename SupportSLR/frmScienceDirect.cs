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
    public partial class frmScienceDirect : Form
    {
        public frmScienceDirect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchScienceDirect();
        }

        private void SearchScienceDirect()
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
                string url = String.Format(basicURL + querystring, page - 2);

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

                        if (resultTrim.StartsWith("<H2>"))
                        {
                            hasPages = true;

                            string token01 = "href=\"";
                            string urlResult = resultTrim.Substring(resultTrim.IndexOf(token01) + token01.Length);
                            urlResult = urlResult.Substring(0, urlResult.IndexOf("\""));

                            string contentResult = string.Empty;
                            contentResult = GetContentFromURL(urlResult).Trim();

                            SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter searchResultItemTableAdapter = new SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter();
                            SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow = supportSLRDataSet.SearchResultItem.NewSearchResultItemRow();
                            newSearchResultItemRow.fk_QueryDataSourceRound_id = 2; //(int)comboBox1.SelectedValue;
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
            title = title.Substring(0, title.ToLower().IndexOf(token03)).Replace(System.Environment.NewLine, "").Trim();

            string token04 = "<h2 class=\"Heading\">Abstract</h2>";
            /*string valAbstract = contentResult.Substring(contentResult.IndexOf(token04) + token04.Length).Trim();

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
             */

            string token = "<p class=\"volIssue\">";
            string volIssue = contentResult.Substring(contentResult.IndexOf(token) + token.Length);

            string tokenPages = "Pages";
            string pages = string.Empty;
            if (contentResult.IndexOf(tokenPages) > 0)
            {
                pages = volIssue.Substring(volIssue.IndexOf(tokenPages));
                pages = pages.Substring(0, pages.IndexOf("</p>"));
                pages = pages.Replace("Pages", "").Trim();
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

            string tokenYear = @"(19|20)\d\d";
            string year = string.Empty;
            Regex regex = new Regex(tokenYear);
            Match match = regex.Match(volIssue);
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

        private void ReprocessSearchScienceDirect()
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

            List<string> lstUrls = new List<string>();
            //lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0196064403008217");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S1386505606002000");
            //lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S1072751501007694");
            //lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0169260700001358");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S1386505615000660");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0146000509001104");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0196064408018982");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0140673613621509");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0029655408001589");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S1072751507006953");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0140673609603159");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S1471491414000628");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0196064411015502");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S1072751512004474");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0002817714623369");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S1386505605000730");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S1473309909701768");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0196655304003645");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S1932227511000449");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0033350616000093");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S0736467912010980");
            lstUrls.Add("http://www.sciencedirect.com/science/article/pii/S1067991X14000765");

            foreach (string url in lstUrls)
            {

                string contentResult = string.Empty;
                contentResult = GetContentFromURL(url).Trim();

                SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter searchResultItemTableAdapter = new SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter();
                SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow = supportSLRDataSet.SearchResultItem.NewSearchResultItemRow();
                newSearchResultItemRow.fk_QueryDataSourceRound_id = 2; //(int)comboBox1.SelectedValue;
                newSearchResultItemRow.url = url;
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

        private void frmScienceDirect_Load(object sender, EventArgs e)
        {
            //ReprocessSearchScienceDirect();
        }
    }

}
