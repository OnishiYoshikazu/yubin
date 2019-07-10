using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace yubin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient();
            var request = new RestRequest();
            client.BaseUrl = new Uri("http://zipcloud.ibsnet.co.jp/api/search");

            request.Method = Method.GET;
            request.AddParameter("zipcode", textBox1.Text, ParameterType.GetOrPost);

            var response = client.Execute(request);
            string json = response.Content.ToString();
            var ret = JsonConvert.DeserializeObject<yubincode>(json);

            if (ret.message == null) {
                label2.Text = ret.results[0].address1 + ret.results[0].address2 + ret.results[0].address3;
            }
            else
            {
                label2.Text = "エラー！";
            }
        }
    }
}
