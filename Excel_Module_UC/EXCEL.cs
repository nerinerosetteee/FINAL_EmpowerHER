using AOOP_EmpowerHER;
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
    public partial class EXCEL : Form
    {
        public static int buttonClick;
        public EXCEL()
        {
            InitializeComponent();
        }

        public int getClick
        {
            get { return buttonClick; }
        }

        private void EXCEL_Load(object sender, EventArgs e)
        {
            Dashboard_MS ms = new Dashboard_MS();
            int progress = ms.getexcelProg;

            guna2ProgressBar1.Value = progress * 100 / 3;
            button4.Text = guna2ProgressBar1.Value.ToString() + "% COMPLETED";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            buttonClick = 1;
            E1 ex = new E1();
            ex.Show(); this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            buttonClick = 2;
            E1 ex = new E1();
            ex.Show(); this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            buttonClick = 3;
            E1 ex = new E1();
            ex.Show(); this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            buttonClick = 4;
            E1 ex = new E1();
            ex.Show(); this.Hide();
        }
    }
}