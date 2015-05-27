using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Xml;
using System.Data;


namespace Gmailfeed2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Gmail Username and Password Section*/
            string username = "/*______Replace With Your Gmail Username__________*/";
            string password = "/*______Replace with your Gmail Password__________*/";
            string url = (@"https://gmail.google.com/gmail/feed/atom");
            
            
            var request = (HttpWebRequest)WebRequest.Create(url);
            var encoded = TextToBase64(username + ":" + password);

            var myWebRequest = HttpWebRequest.Create(url);
            myWebRequest.Method = "POST";
            myWebRequest.ContentLength = 0;
            myWebRequest.Headers.Add("Authorization", "Basic " + encoded);

            var response = myWebRequest.GetResponse();
            var stream = response.GetResponseStream();

            DataSet dt = new DataSet();

            dt.ReadXml(stream);
            DataTable DT = dt.Tables[3];
            // DT.Merge(dt.Tables[1]);
            DT.Merge(dt.Tables[2]);
            feedGrid.DataSource = DT;
            DataBind();

        }

        public static string TextToBase64(string sAscii)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(sAscii);
            return System.Convert.ToBase64String(bytes, 0, bytes.Length);
        }


    }
}
