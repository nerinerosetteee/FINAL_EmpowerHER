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
    public partial class BasicComputerSkills : Form
    {
        public BasicComputerSkills()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BasicComputerSkills_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BCS_1 fr1 = new BCS_1();
            fr1.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BCS_2 fr2 = new BCS_2();
            fr2.ShowDialog();
        }
    }
}
