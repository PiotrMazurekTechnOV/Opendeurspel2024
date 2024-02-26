﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Opendeurspel
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
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
            int percentage = 112;
            int percentage2 = 185;
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
            int percentage3 = 90;
            int percentage4 = 140;
            int newX1 = (parentWidth * percentage3) / 100;
            int newY1 = (parentHeight * percentage4) / 100;
            this.textBox1.Location = new Point(newX1, newY1);

            this.textBox2.AutoSize = false;
            this.textBox2.Size = new Size(475, 75);
            int percentage5 = 90;
            int percentage6 = 37;
            int newX2 = (parentWidth * percentage5) / 100;
            int newY2 = (parentHeight * percentage6) / 100;
            this.textBox2.Location = new Point(newX2, newY2);

            this.textBox3.AutoSize = false;
            this.textBox3.Size = new Size(475, 75);
            int percentage7 = 90;
            int percentage8 = 62;
            int newX3 = (parentWidth * percentage7) / 100;
            int newY3 = (parentHeight * percentage8) / 100;
            this.textBox3.Location = new Point(newX3, newY3);

            this.textBox4.AutoSize = false;
            this.textBox4.Size = new Size(475, 75);
            int percentage9 = 90;
            int percentage10 = 88;
            int newX4 = (parentWidth * percentage9) / 100;
            int newY4 = (parentHeight * percentage10) / 100;
            this.textBox4.Location = new Point(newX4, newY4);

            this.textBox5.AutoSize = false;
            this.textBox5.Size = new Size(475, 75);
            int percentage11 = 90;
            int percentage12 = 115;
            int newX5 = (parentWidth * percentage11) / 100;
            int newY5 = (parentHeight * percentage12) / 100;
            this.textBox5.Location = new Point(newX5, newY5);

            this.checkBox1.AutoSize = false;
            int percentage13 = 86;
            int percentage14 = 213;
            int newX6 = (parentWidth * percentage13) / 100;
            int newY6 = (parentHeight * percentage14) / 100;
            this.checkBox1.Location = new Point(newX6, newY6);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Empty;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Empty;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Empty;
        }
    }
}
