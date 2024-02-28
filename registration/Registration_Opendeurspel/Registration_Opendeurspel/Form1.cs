﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Registration_Opendeurspel
{
    public partial class Form1 : Form
    {
        static HttpClient client;
        bool changed5 = false;
        bool changed1 = false;
        bool changed2 = false;
        bool changed3 = false;
        bool changed4 = false;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("http://192.168.0.144/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

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
        private void Form1_Load(object sender, EventArgs e)
        {
            InschrijfBtn.Parent = this;
            InschrijfBtn.Cursor = Cursors.Hand;
            InschrijfBtn.FlatStyle = FlatStyle.Flat;
            InschrijfBtn.BackColor = Color.Transparent;
            InschrijfBtn.FlatAppearance.BorderSize = 0;
            InschrijfBtn.ForeColor = Color.Transparent;
            InschrijfBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            InschrijfBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            int percentage = 97;
            int percentage2 = 183;
            int parentWidth = this.ClientSize.Width;
            int parentHeight = this.ClientSize.Height;
            int newX = (parentWidth * percentage) / 100;
            int newY = (parentHeight * percentage2) / 100;
            this.InschrijfBtn.Location = new Point(newX, newY);

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.textBox1.AutoSize = false;
            this.textBox1.Size = new Size(475, 155);
            textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
            int percentage3 = 75;
            int percentage4 = 140;
            int newX1 = (parentWidth * percentage3) / 100;
            int newY1 = (parentHeight * percentage4) / 100;
            this.textBox1.Location = new Point(newX1, newY1);

            this.textBox2.AutoSize = false;
            this.textBox2.Size = new Size(475, 75);
            textBox2.Font = new Font(textBox2.Font.FontFamily, 16);
            int percentage5 = 75;
            int percentage6 = 37;
            int newX2 = (parentWidth * percentage5) / 100;
            int newY2 = (parentHeight * percentage6) / 100;
            this.textBox2.Location = new Point(newX2, newY2);

            this.textBox3.AutoSize = false;
            this.textBox3.Size = new Size(475, 75);
            textBox3.Font = new Font(textBox3.Font.FontFamily, 16);
            int percentage7 = 75;
            int percentage8 = 63;
            int newX3 = (parentWidth * percentage7) / 100;
            int newY3 = (parentHeight * percentage8) / 100;
            this.textBox3.Location = new Point(newX3, newY3);

            this.textBox4.AutoSize = false;
            this.textBox4.Size = new Size(475, 75);
            textBox4.Font = new Font(textBox4.Font.FontFamily, 16);
            int percentage9 = 75;
            int percentage10 = 89;
            int newX4 = (parentWidth * percentage9) / 100;
            int newY4 = (parentHeight * percentage10) / 100;
            this.textBox4.Location = new Point(newX4, newY4);

            this.textBox5.AutoSize = false;
            this.textBox5.Size = new Size(475, 75);
            textBox5.Font = new Font(textBox5.Font.FontFamily, 16);
            int percentage11 = 75;
            int percentage12 = 115;
            int newX5 = (parentWidth * percentage11) / 100;
            int newY5 = (parentHeight * percentage12) / 100;
            this.textBox5.Location = new Point(newX5, newY5);

            this.textBox6.AutoSize = false;
            this.textBox6.Size = new Size(200, 45);
            textBox6.Font = new Font(textBox6.Font.FontFamily, 16);
            int percentage15 = 208;
            int percentage16 = 35;
            int newX7 = (parentWidth * percentage15) / 100;
            int newY7 = (parentHeight * percentage16) / 100;
            this.textBox6.Location = new Point(newX7, newY7);

            this.label1.AutoSize = false;
            this.label1.Size = new Size(200, 45);
            label1.Font = new Font(label1.Font.FontFamily, 16);
            int percentage17 = 210;
            int percentage18 = 25;
            int newX8 = (parentWidth * percentage17) / 100;
            int newY8 = (parentHeight * percentage18) / 100;
            this.label1.Location = new Point(newX8, newY8);

            this.checkBox1.AutoSize = false;
            int percentage13 = 70;
            int percentage14 = 215;
            int newX6 = (parentWidth * percentage13) / 100;
            int newY6 = (parentHeight * percentage14) / 100;
            this.checkBox1.Location = new Point(newX6, newY6);

            this.label2.AutoSize = false;
            this.label2.Size = new Size(200, 45);
            label2.Font = new Font(label2.Font.FontFamily, 16);
            int percentage19 = 210;
            int percentage20 = 25;
            int newX9 = (parentWidth * percentage19) / 100;
            int newY9 = (parentHeight * percentage20) / 100;
            this.label1.Location = new Point(newX9, newY9);

        }
        private void check1()
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "Wat zijn uw Interesses op deze school";
            }
        }
        private void check2()
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.Text = "Voornaam";
            }
        }
        private void check3()
        {
            if (textBox3.Text == string.Empty)
            {
                textBox3.Text = "Familienaam";
            }
        }
        private void check4()
        {
            if (textBox4.Text == string.Empty)
            {
                textBox4.Text = "Leeftijd";
            }
        }
        private void check5()
        {
            if (textBox5.Text == string.Empty)
            {
                textBox5.Text = "Email";
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (changed1 == false)
            {
                textBox1.Text = string.Empty;
                changed1 = false;
            }
            check2();
            check3();
            check4();
            check5();
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            if (changed4 == false)
            {
                textBox4.Text = string.Empty;
                changed4 = false;
            }
            check2();
            check1();
            check3();
            check5();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (changed3 == false)
            {
                textBox3.Text = string.Empty;
                changed3 = false;
            }
            check2();
            check1();
            check4();
            check5();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (changed5 == false)
            {
                textBox5.Text = string.Empty;
                changed5 = false;
            }
            check2();
            check1();
            check3();
            check4();
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (changed2 == false)
            {
                textBox2.Text = string.Empty;
                changed2 = false;
            }
            check1();
            check3();
            check4();
            check5();
        }

        static async Task<string> AddUser(string firstNameN, string lastNameN, bool consentN, int ageN, string interestN, string emailN)
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

        private async void InschrijfBtn_Click(object sender, EventArgs e)
        {
            var response = await AddUser(
               textBox2.Text, //voornaam
               textBox3.Text, //familienaam
               Convert.ToBoolean(checkBox1.Checked), //consent
               Convert.ToInt32(textBox4.Text), //leeftijd
               textBox1.Text, //interesse
               textBox5.Text); //email
            pictureBox1.Visible= true;
            label2.Visible=true;
            button1.Visible=true;
            label2.Text=(response);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            changed5 = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            changed2 = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            changed3 = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            changed4 = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changed1 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
