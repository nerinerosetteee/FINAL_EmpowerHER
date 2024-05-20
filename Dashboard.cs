using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AOOP_EmpowerHER
{
    public partial class Dashboard : Form
    {
        DbConnect conn = new DbConnect();
        string query;
        DataSet ds;
        string username = Properties.Settings.Default.Username;
        public static int bcsProg = 0;
        public static int inProg = 0;
        public static int mosProg = 0;
        public static int ecProg = 0;
        public static int qSetNo;

        public Dashboard()
        {
            InitializeComponent();
        }

        public int getqSetNo
        {
            get { return qSetNo; }
        }

        public int getbcsProg
        {
            get { return bcsProg; }
        }

        public int getinProg
        {
            get { return inProg; }
        }

        public int getmosProg
        {
            get { return mosProg; }
        }

        public int getecProg
        {
            get { return ecProg; }
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ECProg_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
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

            bcsProg = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
            inProg = Convert.ToInt32(ds.Tables[0].Rows[1][1]);
            mosProg = Convert.ToInt32(ds.Tables[0].Rows[2][1]) + Convert.ToInt32(ds.Tables[0].Rows[3][1]) + Convert.ToInt32(ds.Tables[0].Rows[4][1]);
            ecProg = Convert.ToInt32(ds.Tables[0].Rows[5][1]) + Convert.ToInt32(ds.Tables[0].Rows[6][1]);

            bcsProgBar.Value = bcsProg * 100 / 7;
            BCSProg.Text = bcsProgBar.Value.ToString() + "% COMPLETED";
            inProgBar.Value = inProg * 100 / 7;
            INProg.Text = inProgBar.Value.ToString() + "% COMPLETED";
            mosProgBar.Value = mosProg * 100 / 7;
            MOSProg.Text = mosProgBar.Value.ToString() + "% COMPLETED";
            ecProgBar.Value = ecProg * 100 / 7;
            ECProg.Text = ecProgBar.Value.ToString() + "% COMPLETED";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            qSetNo = 1;
            BCS_LIST bcslist = new BCS_LIST();
            bcslist.Show(); this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            qSetNo = 2;
            IN_LIST inlist = new IN_LIST();
            inlist.Show(); this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }
    }
}
