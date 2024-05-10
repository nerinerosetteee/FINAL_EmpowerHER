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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Internet_Navigation internetnav= new Internet_Navigation();
            internetnav.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BasicComputerSkills fr2 = new BasicComputerSkills();
            fr2.ShowDialog(); 
        }


    }
}
