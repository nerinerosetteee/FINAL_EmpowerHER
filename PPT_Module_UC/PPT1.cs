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
    public partial class PPT1 : Form
    {
        DbConnect conn = new DbConnect();
        string query;
        DataSet ds;
        string username = Properties.Settings.Default.Username;
        int hasViewed;

        public PPT1()
        {
            InitializeComponent();
        }
        private void PPT1_Load(object sender, EventArgs e)
        {
            label2.Text = username;
            POWERPOINT ppt = new POWERPOINT();
            int buttonClicked = ppt.getClick;

            switch (buttonClicked)
            {
                case 1:
                    btnGetStartPPT_Click(sender, e);
                    break;
                case 2:
                    guna2Button5_Click(sender, e);
                    break;
                case 3:
                    guna2Button6_Click(sender, e);
                    break;
            }
        }
        private void btnGetStartPPT_Click(object sender, EventArgs e)
        {
            uC_PPT_11.Visible = true;
            uC_PPT_11.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 4 AND Lesson_Id = 1";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 4, 1, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_PPT_21.Visible = true;
            uC_PPT_21.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 4 AND Lesson_Id = 2";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 4, 2, 'YES')";
                conn.setData(query, "Okay");
            }
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_PPT_31.Visible = true;
            uC_PPT_31.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 4 AND Lesson_Id = 3";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 4, 3, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            quiz_MS1.Visible = true;
            quiz_MS1.BringToFront();
        }
    }
}
