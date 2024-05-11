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
    public partial class BCS_1 : Form
    {
        public BCS_1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void GetStarted_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BCS_1 lect1 = new BCS_1();
            lect1.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            BCS_2 lect2 = new BCS_2();
            lect2.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            BCS_3 lect3 = new BCS_3();
            lect3.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            BCS_4 lect4 = new BCS_4();
            lect4.ShowDialog(); 
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            BCS_5 lect5 = new BCS_5();
            lect5.ShowDialog(); 
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            BCS_6 lect6 = new BCS_6();
            lect6.ShowDialog();
        }
    }
}
