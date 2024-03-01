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
using ReaLTaiizor.Controls;

namespace Question_Opendeurspel
{
    public partial class Form2 : Form
    {
        static HttpClient client;
        private Location location;
        private Question question;
        private List<Answer> answerList;
        private User user;
        public Form2(Location location)
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.155.12/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            this.location = location;
            answerList = new List<Answer>();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            this.question = await GetQuestionByLocation(location.id);
            answerList = await GetAnswersForQuestion(question.id);
            this.WindowState = FormWindowState.Minimized;//zet het fullscreen
            this.FormBorderStyle = FormBorderStyle.None;//verwijdert de borders
            this.Bounds = Screen.PrimaryScreen.Bounds;//zet het op de borders van jou scherm
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            textBox1.Location = new Point(pictureBox3.Width * 150 / 100, pictureBox3.Height * 160 / 100);
            EnterBtn.Location = new Point(pictureBox3.Width * 152 / 100, pictureBox3.Height * 200 / 100);
            questionLbl.Location = new Point(pictureBox3.Width * 148 / 100, pictureBox3.Height * 100 / 100);
            button1.Location = new Point(pictureBox3.Width * 141 / 100, pictureBox3.Height * 185 / 100);
            button2.Location = new Point(pictureBox3.Width * 205 / 100, pictureBox3.Height * 185 / 100);
            button3.Location = new Point(pictureBox3.Width * 78 / 100, pictureBox3.Height * 185 / 100);
            dungeonTextBox1.Location = new Point(pictureBox3.Width * 135 / 100, pictureBox3.Height * 323 / 100);
            button1.Text = answerList[0].answer; 
            button2.Text = answerList[1].answer; 
            button3.Text = answerList[2].answer;
            dungeonTextBox1.Text = "Made by 6ICT";
            textBox1.Font = new Font("Calibri", 60);
            questionLbl.Font = new Font("Calibri", 18);
            questionLbl.TextAlign = ContentAlignment.MiddleCenter;
            dungeonTextBox1.Font = new Font("Comic Sans MS", 33);
            button1.Font = new Font("Calibri", 18);
            button2.Font = new Font("Calibri", 18);
            button3.Font = new Font("Calibri", 18);
            questionLbl.AutoSize = true;
            dungeonTextBox1.Size = new System.Drawing.Size(300, 150);
            textBox1.Size = new System.Drawing.Size(150, 100);
            button1.Size = new System.Drawing.Size(120, 150);
            button2.Size = new System.Drawing.Size(302, 150);
            button3.Size = new System.Drawing.Size(302,150);
            button1.BringToFront();
            button2.BringToFront();
            button3.BringToFront();
            this.questionLbl.Parent = this.pictureBox2;
            this.button1.Parent = this.pictureBox2;
            this.button2.Parent = this.pictureBox2;
            this.button3.Parent = this.pictureBox2;
            this.questionLbl.BackColor = Color.Transparent;

            questionLbl.Padding = new Padding(6);
            button1.Padding = new Padding(6);
            button2.Padding = new Padding(6);
            button3.Padding = new Padding(6);
            this.Controls.Add(questionLbl);
            questionLbl.BringToFront();
            questionLbl.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void EnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                user = await GetUserByCode();
                if (user != null)
                {
                    questionLbl.Text = "Dag " + user.firstName + " " + user.lastName + ", \n " + question.text;

                    pictureBox1.Visible = false;
                    textBox1.Visible = false;
                    EnterBtn.Visible = false;
                    pictureBox2.Visible = true;
                    questionLbl.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ResetScreen()
        {
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            EnterBtn.Visible = true;
            pictureBox2.Visible = false;
            questionLbl.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answerList[0].correct)
            {
                MessageBox.Show("Goed zo, je hebt juist geantwoord!");
                AddScore(1);
                ResetScreen();

            }
            else
            {
                MessageBox.Show("Spijtig maar je antwoord is niet correct.");
                AddScore(0);
                ResetScreen();
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (answerList[1].correct)
            {
                MessageBox.Show("Goed zo, je hebt juist geantwoord!");
                AddScore(1);
                ResetScreen();
            }
            else
            {
                MessageBox.Show("Spijtig maar je antwoord is niet correct.");
                AddScore(0);
                ResetScreen();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (answerList[2].correct)
            {
                MessageBox.Show("Goed zo, je hebt juist geantwoord!");
                AddScore(1);
                ResetScreen();
            }
            else
            {
                MessageBox.Show("Spijtig maar je antwoord is niet correct.");
                AddScore(0);
                ResetScreen();
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

        private async Task<User> GetUserByCode()
        {
            int code = Convert.ToInt32(textBox1.Text);
            var res = await client.GetAsync("user/" + code);

            var jsonResponse = await res.Content.ReadAsStringAsync();
            User user = JsonConvert.DeserializeObject<User>(jsonResponse);


            return user;
        }

        private async Task<Question> GetQuestionByLocation(int locationId)
        {
            var res = await client.GetAsync("question/" + locationId);

            var jsonResponse = await res.Content.ReadAsStringAsync();
            Question question = JsonConvert.DeserializeObject<Question>(jsonResponse);


            return question;
        }

        private async void AddScore(int correct)
        {
            try
            {
                var res = await client.GetAsync("score/" + user.id + "/" + question.id + "/" + correct);
                MessageBox.Show("Je antwoord is opgeslagen");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }

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



}
