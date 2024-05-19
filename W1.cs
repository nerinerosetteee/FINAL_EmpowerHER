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
    public partial class W1 : Form
    {
        public W1()
        {
            InitializeComponent();
        }

        private void W1_Load(object sender, EventArgs e)
        {
            uC_Word_11.Visible = false;
            uC_Word_21.Visible = false;
            uC_Word_31.Visible = false;
        }

        private void btnStartWord_Click_1(object sender, EventArgs e)
        {
            uC_Word_11.Visible = true;
            uC_Word_11.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_Word_21.Visible = true;
            uC_Word_21.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_Word_31.Visible = true;
            uC_Word_31.BringToFront();
        }
    }
}
