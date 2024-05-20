using System;
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
    public partial class G1 : Form
    {
        DbConnect conn = new DbConnect();
        string query;
        DataSet ds;
        string username = Properties.Settings.Default.Username;
        int hasViewed;

        public G1()
        {
            InitializeComponent();
        }

        private void G1_Load(object sender, EventArgs e)
        {
            label1.Text = username;
            GMAIL_LIST gmail = new GMAIL_LIST();
            int buttonClicked = gmail.getClick;

            switch (buttonClicked)
            {
                case 1:
                    btnIntroGmail_Click(sender, e);
                    break;
                case 2:
                    guna2Button5_Click(sender, e);
                    break;
                case 3:
                    guna2Button6_Click(sender, e);
                    break;
                case 4:
                    guna2Button7_Click(sender, e);
                    break;
            }
        }
        private void btnIntroGmail_Click(object sender, EventArgs e)
        {
            uC_Gmail_11.Visible = true;
            uC_Gmail_11.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 7 AND Lesson_Id = 1";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 7, 1, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_Gmail_21.Visible = true;
            uC_Gmail_21.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 7 AND Lesson_Id = 2";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 7, 2, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_Gmail_31.Visible = true;
            uC_Gmail_31.BringToFront();

            query = $"SELECT COUNT(*) FROM Progress WHERE Student_Username = '{username}' AND qset = 7 AND Lesson_Id = 3";
            ds = conn.getData(query);
            hasViewed = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            MessageBox.Show($"User has taken: {hasViewed}");

            if (hasViewed == 0)
            {
                query = $"INSERT INTO Progress (Student_Username, qSet, Lesson_Id, isViewed) Values ('{username}', 7, 3, 'YES')";
                conn.setData(query, "Okay");
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            quiz_EC1.Visible = true;
            quiz_EC1.BringToFront();
        }
    }
}
