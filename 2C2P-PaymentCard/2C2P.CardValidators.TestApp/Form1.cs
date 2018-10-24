using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace _2C2P.CardValidators.TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          //  Uri requestUri = new Uri("http://localhost/2C2P.CardAPI/api/CardCheck");
          //  CardRequest res = new CardRequest { CardNumber = "4", ValidMonth = 1, ValidYear = 2011 };
          //  string output = JsonConvert.SerializeObject(res);
          //  string json = Newtonsoft.Json.JsonConvert.SerializeObject(myDetails);
            
          ////  var client = new System.Net.Http.HttpClient();
          ////  objClint.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          ////  HttpResponseMessage response = client.GetAsync(requestUri)

          ////System.Net.Http.HttpResponseMessage respon = await objClint.PostAsync(requestUri, new StringContent(json, System.Text.Encoding.UTF8, "application/json"));
          ////  //string responJsonText = await respon.Content.ReadAsStringAsync();
          ////  //txtResponse.Text = responJsonText;






            //CardValidators.CheckCard obj = new CheckCard(txtCardNumber.Text, int.Parse(cboMonth.Text), int.Parse(cboYear.Text));
            //lblResponse.Text = string.Format("{0} - {1}", obj.Response.CardResult, obj.Response.CardType);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost/2C2P.CardAPI/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            HttpResponseMessage response = client.GetAsync("api/Card/GetCardDetails").Result;

            
            if (response.IsSuccessStatusCode)
            {

                var products = response.Content.ReadAsStringAsync().Result;
                lblResponse.Text = products;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i =2018;i<2050;i++)
            {
                cboYear.Items.Add(i);
            }
        }
    }
}
