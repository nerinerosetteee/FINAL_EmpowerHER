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
    public partial class IN : Form
    {
        DbConnect conn = new DbConnect();
        string query;
        DataSet ds;
        string username = Properties.Settings.Default.Username;
        int hasViewed;

        public IN()
        {
            InitializeComponent();
        }


        private void IN_Load(object sender, EventArgs e)
        {
            IN_LIST inlist = new IN_LIST();
            int buttonClicked = inlist.getClick;
            label1.Text = username;

            switch (buttonClicked)
            {
                case 1:
                    guna2Button1_Click(sender, e);
                    break;
                case 2:
                    guna2Button2_Click(sender, e);
                    break;
                case 3:
                    guna2Button3_Click(sender, e);
                    break;
                case 4:
                    guna2Button4_Click(sender, e);
                    break;
                case 5:
                    guna2Button5_Click(sender, e);
                    break;
                case 6:
                    guna2Button6_Click(sender, e);
                    break;
                case 7:
                    guna2Button7_Click(sender, e);
                    break;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_IN_11.Visible = true;
            uC_IN_11.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 2 AND Lesson_Id = 1";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 2, 1, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_IN_21.Visible = true;
            uC_IN_21.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 2 AND Lesson_Id = 2";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 2, 2, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_IN_31.Visible = true;
            uC_IN_31.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 2 AND Lesson_Id = 3";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 2, 3, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_IN_41.Visible = true;
            uC_IN_41.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 2 AND Lesson_Id = 4";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 2, 4, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_IN_51.Visible = true;
            uC_IN_51.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 2 AND Lesson_Id = 5";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 2, 5, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_IN_61.Visible = true;
            uC_IN_61.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 2 AND Lesson_Id = 6";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 2, 6, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            uC_IN_71.Visible = true;
            uC_IN_71.BringToFront();
            
            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 2 AND Lesson_Id = 7";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 2, 7, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            IN_LIST inav = new IN_LIST();
            inav.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            //quiz1.Visible = true;
            //quiz1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
