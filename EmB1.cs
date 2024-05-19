using AOOP_EmpowerHER.Email_Module_UC;
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
    public partial class EmB1 : Form
    {
        public EmB1()
        {
            InitializeComponent();
        }

        private void EmB1_Load(object sender, EventArgs e)
        {
           uC_Email_11.Visible = false;
           uC_Email_21.Visible = false;
           uC_Email_31.Visible = false;
        }

        private void btnIntroEmail_Click(object sender, EventArgs e)
        {
            uC_Email_11.Visible = true;
            uC_Email_11.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_Email_21.Visible = true;
            uC_Email_21.BringToFront();

        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_Email_31.Visible = true;
            uC_Email_31.BringToFront();
        }
    }
}
