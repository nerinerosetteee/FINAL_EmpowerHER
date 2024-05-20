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
    public partial class GMAIL_LIST : Form
    {
        public int buttonClick;

        public GMAIL_LIST()
        {
            InitializeComponent();
        }

        public int getClick
        {
            get { return buttonClick; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            buttonClick = 1;
            G1 gmail = new G1();
            gmail.Show(); this.Hide();
        }

        private void GMAIL_LIST_Load(object sender, EventArgs e)
        {
            Dashbaord_EC email = new Dashbaord_EC();
            int progress = email.getGmailProg;

            guna2ProgressBar1.Value = progress * 100 / 3;
            label2.Text = guna2ProgressBar1.Value.ToString() + "% COMPLETED";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            buttonClick = 2;
            G1 gmail = new G1();
            gmail.Show(); this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            buttonClick = 3;
            G1 gmail = new G1();
            gmail.Show(); this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            buttonClick = 4;
            G1 gmail = new G1();
            gmail.Show(); this.Hide();
        }
    }
}
