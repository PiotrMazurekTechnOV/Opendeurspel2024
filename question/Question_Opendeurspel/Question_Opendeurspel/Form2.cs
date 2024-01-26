using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_Opendeurspel
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
            cyberTextBox1_Load(pictureBox1,e);
        }
        private void cyberTextBox1_Load(object sender, EventArgs e)
        {
            
            this.cyberTextBox1.Parent = this.pictureBox1;
            cyberTextBox1.Font = new Font("Calibri", 18);
            cyberTextBox1.Size = new Size(200, 50);
            cyberTextBox1.Padding = new Padding(9);
            this.Controls.Add(cyberTextBox1);
            cyberTextBox1.BringToFront();
            cyberTextBox1.Location = new Point(this.cyberTextBox1.Parent.Size.Width/100*270, this.cyberTextBox1.Parent.Size.Height * 100 / 11);

            EnterBtn.Location = new Point(this.cyberTextBox1.Parent.Size.Width*100/40, this.cyberTextBox1.Parent.Size.Height*100/9);
            EnterBtn.Size = new Size(100,50);
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (cyberTextBox1.Text == "1") 
            {
                pictureBox1.Visible = false;
                cyberTextBox1.Visible=false;
                EnterBtn.Visible = false;
            }
            Console.WriteLine(cyberTextBox1);

        }
    }
}
