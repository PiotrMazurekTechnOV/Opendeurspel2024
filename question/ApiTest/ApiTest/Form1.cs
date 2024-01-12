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
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ApiTest
{
    public partial class Form1 : Form
    {
        static HttpClient client;

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }

        private async void testBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(await GetTest());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static async Task<string> GetTest()
        {
            string test = null;
            var res = await client.GetAsync("test");
            if (res.IsSuccessStatusCode)
            {
                test = await res.Content.ReadAsAsync<string>();
            }
            return test;
        }


    }
}
