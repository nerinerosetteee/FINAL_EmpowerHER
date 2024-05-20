using AOOP_EmpowerHER.Email_Module_UC;
using AOOP_EmpowerHER.Student_UC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AOOP_EmpowerHER
{
    public partial class EmB1 : Form
    {
        DbConnect conn = new DbConnect();
        string query;
        DataSet ds;
        string username = Properties.Settings.Default.Username;
        int hasViewed;

        public EmB1()
        {
            InitializeComponent();
        }

        private void EmB1_Load(object sender, EventArgs e)
        {
            EMAIL email = new EMAIL();
            int buttonClicked = email.getClick;

            switch (buttonClicked)
            {
                case 1:
                    btnIntroEmail_Click(sender, e);
                    break;
                case 2:
                    guna2Button5_Click(sender, e);
                    break;
                case 3:
                    guna2Button6_Click(sender, e);
                    break;
            }
        }

        private void btnIntroEmail_Click(object sender, EventArgs e)
        {
            uC_Email_11.Visible = true;
            uC_Email_11.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 6 AND Lesson_Id = 1";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 6, 1, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_Email_21.Visible = true;
            uC_Email_21.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 6 AND Lesson_Id = 2";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 6, 2, 'YES')";
                conn.setData(query, "Okay");
            }
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_Email_31.Visible = true;
            uC_Email_31.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 6 AND Lesson_Id = 3";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 6, 3, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        { 

        }
    }
}
