using ReaLTaiizor.Controls;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//zet het fullscreen
            this.FormBorderStyle = FormBorderStyle.None;//verwijdert de borders
            this.Bounds = Screen.PrimaryScreen.Bounds;//zet het op de borders van jou scherm
            

        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            if (lokaalTxb.Text == "112")
            {
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
                this.Closed += (s, args) => Close();
            }
        }
    }
}
