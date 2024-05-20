using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOOP_EmpowerHER.Admin_UC
{
    public partial class UC_View_Delete : UserControl
    {
        DbConnect conn = new DbConnect();
        String query;
        int qset, qno, qset1;
        public UC_View_Delete()
        {
            InitializeComponent();
        }

        private void UC_View_Delete_Load(object sender, EventArgs e)
        {
            ComboBoxSet.Items.Clear();
            ComboBoxSet.Items.Add("All Questions");
            query = "SELECT DISTINCT qset FROM Questions";
            DataSet ds = conn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ComboBoxSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void ComboBoxSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSet.SelectedIndex != 0)
            {
                query = "SELECT qSet AS 'QUESTION SET', qNo AS 'QUESTION NO.', Question AS QUESTION, optionA AS 'OPTION A', optionB AS 'OPTION B', optionC AS 'OPTION C', optionD AS 'OPTION D', ans AS ANSWER FROM Questions WHERE qset = '" + ComboBoxSet.Text + "'";
                DataSet ds = conn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "SELECT qSet AS 'QUESTION SET', qNo AS 'QUESTION NO.', Question AS QUESTION, optionA AS 'OPTION A', optionB AS 'OPTION B', optionC AS 'OPTION C', optionD AS 'OPTION D', ans AS ANSWER FROM Questions";
                DataSet ds = conn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            qset1 = ComboBoxSet.SelectedIndex;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM Questions WHERE qSet = '" + qset + "' AND qNo = '" + qno + "'";
                conn.setData(query, "Questions Deleted.");
                ComboBoxSet.SelectedIndex = qset1;
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                qset = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                qno = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch
            {

            }
        }
    }
}
