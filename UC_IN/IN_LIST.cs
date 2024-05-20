using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOOP_EmpowerHER
{
    public partial class IN_LIST : Form
    {
        public static int buttonClick;

        public IN_LIST()
        {
            InitializeComponent();
        }

        public int getClick
        {
            get { return buttonClick; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            buttonClick = 1;
            MessageBox.Show($"{buttonClick}");
            var in_LIST = new IN();
            in_LIST.Show(); this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            buttonClick = 2;
            MessageBox.Show($"{buttonClick}");
            var in_LIST = new IN();
            in_LIST.Show(); this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            buttonClick = 3;
            MessageBox.Show($"{buttonClick}");
            var in_LIST = new IN();
            in_LIST.Show(); this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            buttonClick = 4;
            MessageBox.Show($"{buttonClick}");
            var in_LIST = new IN();
            in_LIST.Show(); this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            buttonClick = 5;
            MessageBox.Show($"{buttonClick}");
            var in_LIST = new IN();
            in_LIST.Show(); this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            buttonClick = 6;
            MessageBox.Show($"{buttonClick}");
            var in_LIST = new IN();
            in_LIST.Show(); this.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            buttonClick = 7;
            MessageBox.Show($"{buttonClick}");
            var in_LIST = new IN();
            in_LIST.Show(); this.Hide();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }
    }
}
