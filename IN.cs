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
    public partial class IN : Form
    {
        public IN()
        {
            InitializeComponent();
        }


        private void IN_Load(object sender, EventArgs e)
        {
            uC_IN_11.Visible = false;
            uC_IN_21.Visible = false;
            uC_IN_31.Visible = false;
            uC_IN_41.Visible = false;
            uC_IN_51.Visible = false;
            uC_IN_61.Visible = false;
            uC_IN_71.Visible = false;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_IN_11.Visible = true;
            uC_IN_11.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_IN_21.Visible = true;
            uC_IN_21.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_IN_31.Visible = true;
            uC_IN_31.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_IN_41.Visible = true;
            uC_IN_41.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_IN_51.Visible = true;
            uC_IN_51.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_IN_61.Visible = true;
            uC_IN_61.BringToFront();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            uC_IN_71.Visible = true;
            uC_IN_71.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            IN_LIST inav = new IN_LIST();
            inav.Show();
        }
    }
}
