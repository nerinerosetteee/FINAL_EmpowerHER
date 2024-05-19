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
    public partial class UC_AddNewQuestionscs : UserControl
    {

        DbConnect conn = new DbConnect();
        String query;
        DataSet ds;
        Int64 questionNo = 1;
         
        public UC_AddNewQuestionscs()
        {
            InitializeComponent();
        }

        private void UC_AddNewQuestionscs_Load(object sender, EventArgs e)
        {
            query = "SELECT MAX(qset) from Questions";
            ds = conn.getData(query);
            if (ds.Tables[0].Rows.Count !=0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtSet.Text = (id + 1).ToString();  
            }
            else
            {
                txtSet.Text = "1";
            }
            questionLabel.Text = questionNo.ToString();
            labelNOSET.Visible = false;

        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String qset = txtSet.Text;
            String qNo = questionNo.ToString();
            String question = txtQuestion.Text;
            String option1 = txtOption1.Text;
            String option2 = txtOption2.Text;
            String option3 = txtOption3.Text;
            String option4 = txtOption4.Text;
            String ans = txtAnswer.Text;

            query = "INSERT INTO Questions (qset, qNo, question, optionA, optionB, optionC, optionD, ans) VALUES ('"+qset+ "', '"+qNo+"', '"+question+"', '"+option1+"', '"+option2+ "', '"+option3+"', '"+option4+"', '"+ans+"')";
            conn.setData(query, "Question Added.");

            clearAll();
            questionNo++;
            questionLabel.Text = question.ToString();
        }

        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Unsaved Data will be lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearAll();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Set will be changed.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtSet.Text = (Int64.Parse(txtSet.Text.ToString()) + 1).ToString();
                questionLabel.Text = "1";
            }
        }

        private void txtSet_TextChanged(object sender, EventArgs e)
        {
            if(txtSet.Text != "")
            {
                clearAll();
                query = "SELECT qNo FROM Questions WHERE qset = '"+txtSet.Text+"'";
                ds = conn.getData(query);
                ds = conn.getData(query);

                if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    questionLabel.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                    questionNo = Int64.Parse(questionLabel.Text.ToString());
                    labelNOSET.Visible = false;
                }
                else
                {
                    questionLabel.Text = "1";
                    questionNo = Int64.Parse(questionLabel.Text.ToString());
                    labelNOSET.Visible = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
