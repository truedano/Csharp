using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpAction
{
    class Http
    {
        public string httpGetGetStatus(string url)
        {
            HttpWebResponse response = null;

            try
            {
                WebRequest request = WebRequest.Create(url);

                response = (HttpWebResponse)request.GetResponse();

                HttpStatusCode statuscode = ((HttpWebResponse)response).StatusCode;
                string status = ((HttpWebResponse)response).StatusDescription;
                string ret = (int)statuscode + " " + status;

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

        public string httpGet(String url)
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

        public string httpPostGetStatus(string url, string parms)
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
            catch (WebException we)
            {
                response = (HttpWebResponse)we.Response;
                HttpStatusCode statuscode = ((HttpWebResponse)response).StatusCode;
                string status = ((HttpWebResponse)response).StatusDescription;
                string ret = (int)statuscode + " " + status;
                return ret;
            }
        }

        public string httpPost(string url, string parms)
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
    }
}
