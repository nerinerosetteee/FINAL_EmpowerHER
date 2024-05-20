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
    public partial class WORD : Form
    {
        public static int buttonClick;

        public WORD()
        {
            InitializeComponent();
        }
        public int getClick
        {
            get { return buttonClick; }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            buttonClick = 1;
            W1 word = new W1();
            word.Show(); this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            buttonClick = 2;
            W1 word = new W1();
            word.Show(); this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            buttonClick = 3;
            W1 word = new W1();
            word.Show(); this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            buttonClick = 4;
            W1 word = new W1();
            word.Show(); this.Hide();
        }

        private void WORD_Load(object sender, EventArgs e)
        {
            Dashboard_MS ms = new Dashboard_MS();
            int progress = ms.getwordProg;

            guna2ProgressBar1.Value = progress * 100 / 3;
            button4.Text = guna2ProgressBar1.Value.ToString() + "% COMPLETED";
        }
    }
}
