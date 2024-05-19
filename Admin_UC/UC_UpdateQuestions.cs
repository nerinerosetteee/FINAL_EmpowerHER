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
    public partial class UC_UpdateQuestions : UserControl
    {
        DbConnect conn = new DbConnect();
        String query;
        public UC_UpdateQuestions()
        {
            InitializeComponent();
        }

        private void UC_UpdateQuestions_Load(object sender, EventArgs e)
        {
            ComboBoxSet.Items.Clear();
            query = "select distinct qset from Questions";
            DataSet ds = conn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ComboBoxSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void ComboBoxSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxQuestion.Items.Clear();
            query = "select qNo from Questions where qset ='" + ComboBoxSet.Text + "'";
            DataSet ds = conn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ComboBoxQuestion.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void ComboBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "SElECT question, optionA, optionB, optionC, optionD, ans from questions where qset = '" + ComboBoxSet.Text + "' AND qNo = '" + ComboBoxQuestion.Text + "'";
            DataSet ds = conn.getData(query);
            txtQuestion.Text = ds.Tables[0].Rows[0][0].ToString();
            txtOption1.Text = ds.Tables[0].Rows[0][1].ToString();
            txtOption2.Text = ds.Tables[0].Rows[0][2].ToString();
            txtOption3.Text = ds.Tables[0].Rows[0][3].ToString();
            txtOption3.Text = ds.Tables[0].Rows[0][4].ToString();
            txtAnswer.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
            ComboBoxSet.SelectedIndex = -1;
            ComboBoxQuestion.SelectedIndex = -1;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(ComboBoxQuestion.SelectedIndex != -1)
            {
                String qset = ComboBoxSet.Text;
                String qNo = ComboBoxQuestion.Text;
                String question = txtQuestion.Text;
                String option1 = txtOption1.Text;
                String option2 = txtOption2.Text;
                String option3 = txtOption3.Text;
                String option4 = txtOption4.Text;
                String ans = txtAnswer.Text;

                query = "UPDATE Questions SET question ='"+question+"', optionA = '"+option1+ "', optionB = '"+option2+"',  optionC = '"+option3+"', optionD = '"+option4+"', ans = '"+ans+"' WHERE qset = '"+qset+"' AND qNo = '"+qNo+"'";
                conn.setData(query, "Question No : " + qNo + " \n Question Set : " + qset + "\n is Updated");
            }
            else
            {
                MessageBox.Show("Select Question First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
