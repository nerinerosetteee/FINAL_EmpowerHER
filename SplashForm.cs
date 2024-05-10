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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private int startPoint = 0;

        private void InitializeTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 100; 
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            guna2ProgressBar1.Value = startPoint;
            if (guna2ProgressBar1.Value >= 100)
            {
                guna2ProgressBar1.Value = 0;
                timer1.Stop();
                this.Hide(); 
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value = 0;
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
