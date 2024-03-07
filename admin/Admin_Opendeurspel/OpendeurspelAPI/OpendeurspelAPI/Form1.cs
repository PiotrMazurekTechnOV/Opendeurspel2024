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
using System.Drawing.Printing;
using Newtonsoft.Json;

namespace OpendeurspelAPI
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








        // wanneer je op een question drukt -> answers opvragen

        public class User
        {
            public int id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int age { get; set; }
            public bool consent { get; set; }
            public string email { get; set; }
            public string interest { get; set; }
            public string code { get; set; }

        }

        public class Question
        {
            public int id { get; set; }
            public string text { get; set; }

            public int location_id { get; set; }

        }
        public class Answer
        {
            public int id { get; set; }
            public string answer { get; set; }

            public int question_id { get; set; }
            public bool correct { get; set; }

        }

        public class Locations
        {
            public int id { get; set; }
            public string name { get; set; }

            public string room { get; set; }

        }
        public class Score
        {
            public int id { get; set; }
            public int score { get; set; }
            public int question_id { get; set; }

            public int user_id { get; set; }

        }

        private async void GETquestions_Click(object sender, EventArgs e)
        {
            try
            {
                List<Question> list = await GetQuestions();

                foreach (Question question in list)
                {
                    Questions.Items.Add(question.id + " " + question.location_id + " " + question.text);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static async Task<List<Question>> GetQuestions()
        {
            var res = await client.GetAsync("questions");
            var jsonResponse = await res.Content.ReadAsStringAsync();
            List<Question> questionList = JsonConvert.DeserializeObject<List<Question>>(jsonResponse);
            System.Console.WriteLine(jsonResponse);

            return questionList;
        }





        private async void Questions_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selected = (string)Questions.SelectedItem;
            int selectedId = Convert.ToInt32(selected.Split(' ')[0]);

            try
            {
                //add question id param
                List<Answer> list = await GetAnswersForQuestion(selectedId);
                Answers.Items.Clear();
                foreach (Answer answer in list)
                {
                    Answers.Items.Add(answer.answer + ((answer.correct) ? " C" : " NC"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //opvragen van answers op basis van question ID
        static async Task<List<Answer>> GetAnswersForQuestion(int question_id)
        {
            var res = await client.GetAsync("answers/" + question_id);
            var jsonResponse = await res.Content.ReadAsStringAsync();
            List<Answer> answerList = JsonConvert.DeserializeObject<List<Answer>>(jsonResponse);

            return answerList;
        }

        private async void GETlocations_Click(object sender, EventArgs e)
        {
            try
            {
                List<Locations> list = await Getlocations();

                foreach (Locations locations in list)
                {
                    Location.Items.Add(locations.id + " " + locations.name + " " + locations.room);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static async Task<List<Locations>> Getlocations()
        {
            var res = await client.GetAsync("locations");
            var jsonResponse = await res.Content.ReadAsStringAsync();
            List<Locations> LocationList = JsonConvert.DeserializeObject<List<Locations>>(jsonResponse);

            return LocationList;
        }

        private async void GETusers_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> list = await Getusers();

                foreach (User users in list)
                {
                    Users.Items.Add(users.id + " " + users.firstName + " " + users.lastName + " " + users.age + " " + users.interest + " " + users.email + " " + users.consent + " " + users.code);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static async Task<List<User>> Getusers()
        {
            var res = await client.GetAsync("users");
            var jsonResponse = await res.Content.ReadAsStringAsync();
            List<User> Userslist = JsonConvert.DeserializeObject<List<User>>(jsonResponse);

            return Userslist;
        }

        private async void Users_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selected = (string)Users.SelectedItem;
            int selectedId = Convert.ToInt32(selected.Split(' ')[0]);

            try
            {

                List<Score> list = await GetScoreForUser(selectedId);
                Scorelistbx.Items.Clear();
                foreach (Score score in list)
                {
                    Scorelistbx.Items.Add(score.score + ((score.user_id)));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static async Task<List<Score>> GetScoreForUser(int user_id)
        {
            var res = await client.GetAsync("score/" + user_id);
            var jsonResponse = await res.Content.ReadAsStringAsync();
            List<Score> scoreList = JsonConvert.DeserializeObject<List<Score>>(jsonResponse);

            return scoreList;
        }

        private async void GETscore_Click(object sender, EventArgs e)
        {
            try
            {
                List<Score> list = await Getscore();
                Scorelistbx.Items.Clear();

                foreach (Score score in list)
                {
                    Scorelistbx.Items.Add(score.id + " " + score.score + " " + score.question_id + " " + score.user_id);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static async Task<List<Score>> Getscore()
        {
            var res = await client.GetAsync("score/");
            var jsonResponse = await res.Content.ReadAsStringAsync();
            List<Score> scoreList = JsonConvert.DeserializeObject<List<Score>>(jsonResponse);

            return scoreList;
        }



        private async void Adduser_Click(object sender, EventArgs e)
        {


            var response = await AddUser(
                firstNametxt.Text,
                lastNametxt.Text,
                Convert.ToBoolean(Consentbx.Checked),
                Convert.ToInt32(agetxt.Text),
                interest.Text,
                email.Text);

            MessageBox.Show(response);
        }
        static async Task<string> AddUser(string firstNameN, string lastNameN,bool consentN, int ageN, string interestN, string emailN)
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

        private async void Addquestionbttn_Click(object sender, EventArgs e)
        {
            var response = await AddQuestion(
                  Vraagbx.Text,
                  Convert.ToInt32(location_idbx.Text));
                  

            MessageBox.Show(response);

        }
        static async Task<string> AddQuestion(string QuestionN, int location_idN)
        {
            Question question= new Question
            {
                text = QuestionN,
                location_id = location_idN,
                


            };
            StringContent json = new StringContent(JsonConvert.SerializeObject(question, Formatting.Indented), Encoding.UTF8,
       "application/json");

            var response = await client.PostAsync(
                "questions/add",
                json);

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            return jsonResponse;

        }

       
    }
}
