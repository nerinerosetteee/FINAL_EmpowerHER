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
    public partial class admin_Main : Form
    {
        public admin_Main()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            uC_AddNewQuestionscs1.Visible = true;
            uC_AddNewQuestionscs1.BringToFront();
        }

        private void admin_Main_Load(object sender, EventArgs e)
        {
            uC_AddNewQuestionscs1.Visible = false;
            uC_UpdateQuestions1.Visible = false;
            uC_View_Delete1.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            uC_UpdateQuestions1.Visible=true;
            uC_UpdateQuestions1.BringToFront();
        }

        private void uC_View_Delete1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewDelete_Click(object sender, EventArgs e)
        {
            uC_View_Delete1.Visible=true;
            uC_View_Delete1.BringToFront();
        }
    }
}
