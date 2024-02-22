using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Opendeurspel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//zet het fullscreen
            this.FormBorderStyle = FormBorderStyle.None;//verwijdert de borders
            this.Bounds = Screen.PrimaryScreen.Bounds;//zet het op de borders van jou scherm
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage ;
            questionLbl.Location = new Point(pictureBox3.Width*70/100, pictureBox3.Height*80/100);
            button1. Location = new Point(pictureBox3.Width *55 / 100, pictureBox3.Height * 125 / 100);
            button2.Location = new Point(pictureBox3.Width * 95 / 100, pictureBox3.Height * 125 / 100);
            button3.Location = new Point(pictureBox3.Width * 140 / 100, pictureBox3.Height * 125 / 100);
            questionLbl.Text = "hoeveel onderbroeken draagth John Doe";
            button1.Text = "3"; button2.Text = "2"; button3.Text = "1";
            questionLbl.Font = new Font("Calibri", 18);
            button1.Font = new Font("Calibri", 18);
            button2.Font = new Font("Calibri", 18);
            button3.Font = new Font("Calibri", 18);
            questionLbl.AutoSize = true;
            button1.Size = new System.Drawing.Size(200, 90); 
            button2.Size = new System.Drawing.Size(200, 90); 
            button3.Size = new System.Drawing.Size(200, 90); 
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

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
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


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Juist Antwoord");
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
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fout Antwoord");
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
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fout Antwoord");
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Fout Antwoord");
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
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Fout Antwoord");
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
    }
}
