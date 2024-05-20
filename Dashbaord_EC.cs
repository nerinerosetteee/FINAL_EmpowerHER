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
    public partial class Dashbaord_EC : Form
    {
        DbConnect conn = new DbConnect();
        string query;
        DataSet ds;
        string username = Properties.Settings.Default.Username;
        public static int emailProg = 0;
        public static int gmailProg = 0;
        public static int qSetNo;

        public Dashbaord_EC()
        {
            InitializeComponent();
        }

        public int getqSetNo
        {
            get { return qSetNo; }
        }

        public int getEmailProg
        {
            get { return emailProg; }
        }

        public int getGmailProg
        {
            get { return gmailProg; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.qSetNo = 6;
            Properties.Settings.Default.Save();
            EMAIL email = new EMAIL();
            email.Show(); this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.qSetNo = 7;
            Properties.Settings.Default.Save();
            GMAIL gmail = new GMAIL();
            gmail.Show(); this.Hide();
        }

        private void Dashbaord_EC_Load(object sender, EventArgs e)
        {
            string query = $@"
                                WITH PossibleQsets AS (
                                    SELECT 1 AS qset UNION ALL
                                    SELECT 2 UNION ALL
                                    SELECT 3 UNION ALL
                                    SELECT 4 UNION ALL
                                    SELECT 5 UNION ALL
                                    SELECT 6 UNION ALL
                                    SELECT 7 UNION ALL
                                    SELECT 8
                                )
                                SELECT pq.qset, COALESCE(COUNT(p.Student_Username), 0) AS count
                                FROM PossibleQsets pq
                                LEFT JOIN Progress p ON pq.qset = p.qset AND p.Student_Username = '{username}'
                                GROUP BY pq.qset
                                ORDER BY pq.qset;";
            ds = conn.getData(query);

            emailProg = Convert.ToInt32(ds.Tables[0].Rows[5][1]);
            gmailProg = Convert.ToInt32(ds.Tables[0].Rows[6][1]);

            gmailProgressBar.Value = gmailProg * 100 / 3;
            gmail.Text = gmailProgressBar.Value.ToString() + "% COMPLETED";
            emailProgressBar.Value = emailProg * 100 / 3;
            email.Text = emailProgressBar.Value.ToString() + "% COMPLETED";
        }
    }
}
