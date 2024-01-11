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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "112")
            {
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
                this.Closed += (s, args) => Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
