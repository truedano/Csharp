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

        private void button_start_Click(object sender, EventArgs e)
        {
            String text_ip = textBox_ip.Text;
            String post_parms = textBox_post_parm.Text;
            textBox_show_http_data.Text = "";
            Http http = new Http();

            if (comboBoxHttpType.Text == "get")
            {
                textBox_show_http_data.Text = http.httpGet(text_ip);
            }
            else if (comboBoxHttpType.Text == "post")
            {
                string status = http.httpPostGetStatus(text_ip, post_parms);
                if(status == "200 OK")
                {
                    var post_result = http.httpPost(text_ip, post_parms);

                    textBox_show_http_data.Text = post_result;

                    label_http_status.BackColor = Color.Yellow;
                }
                else
                {
                    label_http_status.BackColor = Color.IndianRed;
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
