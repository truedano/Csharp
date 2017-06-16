using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections.Specialized;

namespace HttpAction
{
    public partial class HttpAction : Form
    {
        public HttpAction()
        {
            InitializeComponent();
        }

        private void FormHttpAction_Load(object sender, EventArgs e)
        {
            comboBoxHttpType.SelectedItem = "get";
            label_post_parm.Hide();
            textBox_post_parm.Hide();
        }

        string httpGet(String url)
        {
            try
            {
                WebClient webclient = new WebClient();
                byte[] myDataBuffer = webclient.DownloadData(url);
                string download = Encoding.ASCII.GetString(myDataBuffer);
                return download;
            }
            catch
            {
                return "";
            }
        }

        string httpPostGetStatus(string url, string parms)
        {
            WebResponse response = null;
            try
            {
                WebRequest request = WebRequest.Create(url);

                request.Method = "POST";
                string postData = parms;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;

                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                response = request.GetResponse();
                HttpStatusCode statuscode = ((HttpWebResponse)response).StatusCode;
                string status = ((HttpWebResponse)response).StatusDescription;
                string ret = (int)statuscode + " " + status;

                response.Close();

                return ret;
            }
            catch(WebException we)
            {
                response = (HttpWebResponse)we.Response;
                HttpStatusCode statuscode = ((HttpWebResponse)response).StatusCode;
                string status = ((HttpWebResponse)response).StatusDescription;
                string ret = (int)statuscode + " " + status;
                return ret;
            }
        }

        string httpPost(string url,string parms)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);

                request.Method = "POST";
                string postData = parms;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();
                //string status = ((HttpWebResponse)response).StatusDescription;
                //Console.WriteLine(status);

                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                //Console.WriteLine(responseFromServer);

                reader.Close();
                dataStream.Close();
                response.Close();

                return responseFromServer;
            }
            catch
            {
                return "";
            }
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            String text_ip = textBox_ip.Text;
            String post_parms = textBox_post_parm.Text;
            textBox_show_http_data.Text = "";
            //Console.WriteLine(text_ip);
            if (comboBoxHttpType.Text == "get")
            {
                textBox_show_http_data.Text = httpGet(text_ip);
            }
            else if (comboBoxHttpType.Text == "post")
            {
                string status = httpPostGetStatus(text_ip, post_parms);
                if(status == "200 OK")
                {
                    var post_result = httpPost(text_ip, post_parms);

                    textBox_show_http_data.Text = post_result;
                }
                label_http_status.Text = status;
            }
        }

        private void comboBoxHttpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string http_type = (string)comboBoxHttpType.SelectedItem;
            if (http_type == "get")
            {
                label_post_parm.Hide();
                textBox_post_parm.Hide();
            }
            else if(http_type == "post")
            {
                label_post_parm.Show();
                textBox_post_parm.Show();
            }
        }
    }
}
