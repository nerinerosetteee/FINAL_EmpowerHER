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
    public partial class PPT1 : Form
    {
        public PPT1()
        {
            InitializeComponent();
        }
        private void PPT1_Load(object sender, EventArgs e)
        {
            uC_PPT_11.Visible = false;
            uC_PPT_21.Visible = false;
            uC_PPT_31.Visible = false;
        }
        private void btnGetStartPPT_Click(object sender, EventArgs e)
        {
            uC_PPT_11.Visible = true;
            uC_PPT_11.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_PPT_21.Visible = true;
            uC_PPT_21.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_PPT_31.Visible = true;
            uC_PPT_31.BringToFront();
        }
    }
}
