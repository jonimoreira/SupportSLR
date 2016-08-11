using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using FSBlog.GoogleSearch.GoogleClient;

namespace SupportSLR
{
    public partial class frmScopus : Form
    {
        public frmScopus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchScopus();
        }

        private void SearchScopus()
        {
            string filepath = textBox3.Text;
            string typeLocator = textBox4.Text;

            string resultsFromFile = string.Empty;

            try
            {
                resultsFromFile = GetContentFromFile(filepath);
            }
            catch (Exception ex)
            {
                textBox1.Text += "Error on: " + filepath + Environment.NewLine;
            }
            
            List<string> listResults = resultsFromFile.Split(new string[] { typeLocator }, StringSplitOptions.None).ToList();

            listResults.RemoveAt(0);

            foreach (string result in listResults)
            {
                string resultTrim = result.Trim();

                SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter searchResultItemTableAdapter = new SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter();
                SupportSLRDataSet.SearchResultItemRow newSearchResultItemRow = supportSLRDataSet.SearchResultItem.NewSearchResultItemRow();
                newSearchResultItemRow.fk_QueryDataSourceRound_id = 11; //(int)comboBox1.SelectedValue;

                string line_break = "\n";

                string temp = resultTrim;
                string type = temp.Substring(0, temp.IndexOf(line_break)).Trim();
                type = (type == "JOUR") ? "Journal" : (type == "CONF") ? "Conference proceeding" : "Book Section";
                temp = temp.Substring(temp.IndexOf(line_break));

                string temp2 = "TI  - ";
                temp = temp.Substring(temp.IndexOf(temp2) + temp2.Length);
                string title = temp.Substring(0, temp.IndexOf(line_break)).Trim();

                string pages = string.Empty;
                temp2 = "SP  - ";
                if (temp.Contains(temp2))
                {
                    temp = temp.Substring(temp.IndexOf(temp2) + temp2.Length);
                    pages = temp.Substring(0, temp.IndexOf(line_break)).Trim();

                    temp2 = "EP  - ";
                    temp = temp.Substring(temp.IndexOf(temp2) + temp2.Length);
                    pages += "-" + temp.Substring(0, temp.IndexOf(line_break)).Trim();
                }

                temp2 = "PY  - ";
                temp = temp.Substring(temp.IndexOf(temp2) + temp2.Length);
                string year = temp.Substring(0, temp.IndexOf(line_break)).Trim();

                temp2 = "UR  - ";
                temp = temp.Substring(temp.IndexOf(temp2) + temp2.Length);
                string url = temp.Substring(0, temp.IndexOf(line_break)).Trim();

                newSearchResultItemRow.type = type;
                newSearchResultItemRow.title = title;
                newSearchResultItemRow.pages = pages;
                newSearchResultItemRow.date_publication = year;
                newSearchResultItemRow.url = url;

                supportSLRDataSet.SearchResultItem.Rows.Add(newSearchResultItemRow);
                searchResultItemTableAdapter.Update(supportSLRDataSet.SearchResultItem);

                try
                {                 // Search by title in Google 
                    string query = "\"" + title + "\"";
                    var client = new SearchClient(query);
                    string content = string.Empty;

                    foreach (var hit in client.Query())
                    {
                        string urlResult = hit.CleanUri.ToString();
                        try
                        {
                            content = GetContentFromURL(urlResult);
                        }
                        catch (Exception ex)
                        {
                            textBox1.Text += "Error on: " + url + Environment.NewLine;
                        }

                        //if (!content.StartsWith("%PDF") && content.ToLower().Contains("abstract"))
                        break;
                    }

                    newSearchResultItemRow.page_content = content;
                }
                catch (Exception ex)
                {
                    textBox1.Text += "Error on Googling: " + ex.Message + Environment.NewLine;
                }

                newSearchResultItemRow.errors_onload = string.Empty;

                searchResultItemTableAdapter.Update(supportSLRDataSet.SearchResultItem);
                searchResultItemTableAdapter.Dispose();
            }               
    
        }

        private string GetContentFromFile(string filepath)
        {
            // Create a request for the URL. 
            try
            {
                string responseFromServer = string.Empty;
                using (StreamReader sr = new StreamReader(filepath))
                {
                    responseFromServer = sr.ReadToEnd();
                }
                return responseFromServer;
            }
            catch (Exception ex)
            {
                textBox1.Text += "Error on GetContentFromFile: " + filepath + System.Environment.NewLine;
            }

            return string.Empty;
        }

        private string GetContentFromURL(string url)
        {
            // Create a request for the URL. 
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                //request.ServicePoint.BindIPEndPointDelegate = new BindIPEndPoint(BindIPEndPointCallback);

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

        public static IPEndPoint BindIPEndPointCallback(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount)
        {

            IPAddress address = IPAddress.Parse("104.16.103.29");
            if (retryCount == 99)
                return null;
            return new IPEndPoint(address, 8080);

        }


    }

}
