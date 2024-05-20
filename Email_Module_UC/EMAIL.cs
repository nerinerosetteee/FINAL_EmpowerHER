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
    public partial class EMAIL : Form
    {
        public static int buttonClick;
        public EMAIL()
        {
            InitializeComponent();
        }

        public int getClick
        {
            get { return buttonClick; }
        }

        private void EMAIL_Load(object sender, EventArgs e)
        {
            Dashbaord_EC email = new Dashbaord_EC();
            int progress = email.getEmailProg;

            guna2ProgressBar1.Value = progress * 100 / 3;
            button4.Text = guna2ProgressBar1.Value.ToString() + "% COMPLETED";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            buttonClick = 1;
            EmB1 em = new EmB1();
            em.Show(); this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            buttonClick = 2;
            EmB1 em = new EmB1();
            em.Show(); this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            buttonClick = 3;
            EmB1 em = new EmB1();
            em.Show(); this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            buttonClick = 4;
            EmB1 em = new EmB1();
            em.Show(); this.Hide();
        }
    }
}
