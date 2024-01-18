using System;
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
            //InschrijfBtn.FlatAppearance.BorderSize = 0;
            InschrijfBtn.ForeColor = Color.Red;
            InschrijfBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            InschrijfBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            int percentage = 29;
            int percentage2 = 74;
            int parentWidth = this.ClientSize.Width;
            int parentHeight = this.ClientSize.Height;
            int newX = (parentWidth * percentage) / 100;
            int newY = (parentHeight * percentage2) / 100;
            InschrijfBtn.Location = new Point(newX, newY);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
