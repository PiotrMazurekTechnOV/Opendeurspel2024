using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Question_Opendeurspel
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void enterBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vul een klaslokaal in.");
            }
            else
            {
                try
                {
                    Location location = await GetLocationByRoom();
                    Form2 form2 = new Form2(location);
                    form2.Show();
                    Hide();
                    this.Closed += (s, args) => Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task<Location> GetLocationByRoom()
        {
            int room = Convert.ToInt32(textBox1.Text);
            var res = await client.GetAsync("location/" + room);

            var jsonResponse = await res.Content.ReadAsStringAsync();
            MessageBox.Show(jsonResponse);
            Location location = JsonConvert.DeserializeObject<Location>(jsonResponse);

            return location;
        }
    }
    public class Location
    {
        public int id { get; set; }
        public string name { get; set; }

        public string room { get; set; }

    }
}
