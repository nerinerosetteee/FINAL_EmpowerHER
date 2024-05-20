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
    public partial class GMAIL : Form
    {
        public int buttonClick;

        public GMAIL()
        {
            InitializeComponent();
        }

        public int getClick
        {
            get { return buttonClick; }
        }

        private void Gmail_Load(object sender, EventArgs e)
        {
            Dashbaord_EC dec = new Dashbaord_EC();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            buttonClick = 1;
            G1 em = new G1();
            em.Show(); this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            buttonClick = 2;
            G1 em = new G1();
            em.Show(); this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            buttonClick = 3;
            G1 em = new G1();
            em.Show(); this.Hide();
        }
    }
}
