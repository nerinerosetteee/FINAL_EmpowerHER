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
    public partial class E1 : Form
    {
        public E1()
        {
            InitializeComponent();
        }

        private void E1_Load(object sender, EventArgs e)
        {
            uC_Excel_11.Visible = false;
            uC_Excel_21.Visible = false;
            uC_Excel_31.Visible = false;
        }

        private void btnExcelStarted_Click(object sender, EventArgs e)
        {
            uC_Excel_11.Visible = true;
            uC_Excel_11.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_Excel_21.Visible = true;
            uC_Excel_21.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_Excel_31.Visible = true;
            uC_Excel_31.BringToFront();
        }
    }
}
