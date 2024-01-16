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
                List<Question> list = await GetTest();
                foreach(Question question in list)
                {
                    MessageBox.Show(question.text + " " + question.location_id);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private async void addUserBtn_Click(object sender, EventArgs e)
        {
            var response = await AddUser("test", "test2", 20, true, "testtest", "test@test.com");

            MessageBox.Show(response);
        }

        static async Task<List<Question>> GetTest()
        {
            var res = await client.GetAsync("questions");
            var jsonResponse = await res.Content.ReadAsStringAsync();
            List<Question> questionList = JsonConvert.DeserializeObject<List<Question>>(jsonResponse);

            return questionList;
        }
        static async Task<string> AddUser(string firstNameN, string lastNameN, int ageN, bool consentN, string interestN, string emailN)
        {
            User user = new User
            {
                firstName = firstNameN,
                lastName = lastNameN,
                age = ageN,
                consent = consentN,
                interest = interestN,
                email = emailN
            };

            StringContent json = new StringContent(JsonConvert.SerializeObject(user, Formatting.Indented), Encoding.UTF8,
        "application/json");

            var response = await client.PostAsync(
                "user/add",
                json);

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            return jsonResponse;
        }

        private async void locationTestBtn_Click(object sender, EventArgs e)
        {
            var response = await AddLocation("ICT", "112");

            MessageBox.Show(response);
        }

        static async Task<string> AddLocation(string nameN, string roomN)
        {
            Location location = new Location
            {
                room = roomN,
                name = nameN
            };

            StringContent json = new StringContent(JsonConvert.SerializeObject(location, Formatting.Indented), Encoding.UTF8,
        "application/json");

            var response = await client.PostAsync(
                "location/add",
                json);

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            return jsonResponse;
        }
    }



    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public bool consent { get; set; }
        public string email { get; set; }
        public string interest { get; set; }

    }

    public class Question
    {
        public string text { get; set; }

        public int location_id { get; set; }

    }

    public class Location
    {
        public string name { get; set; }

        public string room { get; set; }

    }
}
