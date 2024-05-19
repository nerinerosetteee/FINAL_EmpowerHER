using AOOP_EmpowerHER.Student_UC;
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
    public partial class Student_Quizcs : Form
    {
        DbConnect conn = new DbConnect();
        string query;
        DataSet ds = new DataSet();
        public Student_Quizcs()
        {
            InitializeComponent();
        }

        private void Student_Quizcs_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quiz1_Load(object sender, EventArgs e)
        {

        }
    }
}
