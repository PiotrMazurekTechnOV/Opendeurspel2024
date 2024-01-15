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
            }
        }
    }
}
