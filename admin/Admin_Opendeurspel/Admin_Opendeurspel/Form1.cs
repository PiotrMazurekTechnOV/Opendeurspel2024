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

namespace Admin_Opendeurspel
{
    public partial class Form1 : Form
    {
        static HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.0.144/api/");
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

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "112")
            {
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
                this.Closed += (s, args) => Close();
            }
        }

        private async Task<Question> GetUserByCode()
        {
            int code = Convert.ToInt32(textBox1.Text);
            var res = await client.GetAsync("user/" + code);

            var jsonResponse = await res.Content.ReadAsStringAsync();
            MessageBox.Show(jsonResponse);
            User user = JsonConvert.DeserializeObject<User>(jsonResponse);


            return user;


        }
    }
}
