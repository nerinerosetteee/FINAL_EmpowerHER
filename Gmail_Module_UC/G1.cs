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
    public partial class G1 : Form
    {
        public G1()
        {
            InitializeComponent();
        }
        private void G1_Load(object sender, EventArgs e)
        {
            uC_Gmail_11.Visible = false;
            uC_Gmail_21.Visible = false;
            uC_Gmail_31.Visible = false;
        }
        private void btnIntroGmail_Click(object sender, EventArgs e)
        {
            uC_Gmail_11.Visible = true;
            uC_Gmail_11.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_Gmail_21.Visible = true;
            uC_Gmail_21.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_Gmail_31.Visible = true;
            uC_Gmail_31.BringToFront();
        }
    }
}
