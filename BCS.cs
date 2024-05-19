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
    public partial class BCS : Form
    {
        public BCS()
        {
            InitializeComponent();
        }


        private void BCS_Load(object sender, EventArgs e)
        {
            uC_BCS_11.Visible = false;
            uC_BCS_21.Visible = false;
            uC_BCS_31.Visible = false;
            uC_BCS_41.Visible = false;
            uC_BCS_51.Visible = false;
            uC_BCS_61.Visible = false;
            uC_BCS_71.Visible = false;

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_BCS_11.Visible = true;
            uC_BCS_11.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_BCS_21.Visible = true;
            uC_BCS_21.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_BCS_31.Visible = true;
            uC_BCS_31.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_BCS_41.Visible = true;
            uC_BCS_41.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_BCS_51.Visible = true;
            uC_BCS_51.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_BCS_61.Visible = true;
            uC_BCS_61.BringToFront();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            uC_BCS_71.Visible = true;
            uC_BCS_71.BringToFront();
        }
    }
}
