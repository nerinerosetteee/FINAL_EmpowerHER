using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AOOP_EmpowerHER
{
    public partial class Dashboard_MS : Form
    {
        DbConnect conn = new DbConnect();
        string query;
        DataSet ds;
        string username = Properties.Settings.Default.Username;
        public static int excProg = 0;
        public static int pptProg = 0;
        public static int wordProg = 0;
        public static int qSetNo;

        public Dashboard_MS()
        {
            InitializeComponent();
        }

        public int getqSetNo
        {
            get { return qSetNo; }
        }

        public int getexcelProg
        {
            get { return excProg; }
        }

        public int getpptProg
        {
            get { return pptProg; }
        }

        public int getwordProg
        {
            get { return wordProg; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dshbrd = new Dashboard();
            dshbrd.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.qSetNo = 3;
            Properties.Settings.Default.Save();
            WORD word = new WORD();
            word.Show(); this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.qSetNo = 4;
            Properties.Settings.Default.Save();
            POWERPOINT ppt = new POWERPOINT();
            ppt.Show(); this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.qSetNo = 5;
            Properties.Settings.Default.Save();
            EXCEL exc = new EXCEL();
            exc.Show(); this.Hide();
        }

        private void Dashboard_MS_Load(object sender, EventArgs e)
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

            wordProg = Convert.ToInt32(ds.Tables[0].Rows[2][1]);
            pptProg = Convert.ToInt32(ds.Tables[0].Rows[3][1]);
            excProg = Convert.ToInt32(ds.Tables[0].Rows[4][1]);

            wordProgBar.Value = wordProg * 100 / 3;
            wordLab.Text = wordProgBar.Value.ToString() + "% COMPLETED";
            pptProgBar.Value = pptProg * 100 / 3;
            pptLab.Text = pptProgBar.Value.ToString() + "% COMPLETED";
            excProgBar.Value = excProg * 100 / 3;
            excLab.Text = excProgBar.Value.ToString() + "% COMPLETED";
        }
    }
}
