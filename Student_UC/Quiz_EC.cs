﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOOP_EmpowerHER.Student_UC
{
    public partial class Quiz_EC : UserControl
    {
        DbConnect conn = new DbConnect();
        String query, ans, selectedValue;
        int score = 0, qNo = 1, qNoMax;
        DataSet ds;
        string username = Properties.Settings.Default.Username;
        int qSetNo;

        public Quiz_EC()
        {
            InitializeComponent();
        }

        public int getScore
        {
            get { return score; }
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            Dashbaord_EC dashboard = new Dashbaord_EC();
            qSetNo = dashboard.getqSetNo;

            query = $"SELECT optionA, optionB, optionC, optionD, ans, question FROM Questions WHERE qSet = {qSetNo} AND qNo = {qNo}";
            ds = conn.getData(query);

            ans = ds.Tables[0].Rows[0][4].ToString();
            OptionA.Text = ds.Tables[0].Rows[0][0].ToString();
            OptionB.Text = ds.Tables[0].Rows[0][1].ToString();
            OptionC.Text = ds.Tables[0].Rows[0][2].ToString();
            OptionD.Text = ds.Tables[0].Rows[0][3].ToString();
            Question.Text = ds.Tables[0].Rows[0][5].ToString();

            query = $"SELECT COUNT(*) FROM Questions WHERE qSet = {qSetNo}";
            ds = conn.getData(query);
            qNoMax = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            QuestionNo.Text = qNo.ToString() + " / " + qNoMax.ToString();
            sc.Text = score.ToString();
        }

        private void OptionB_Click(object sender, EventArgs e)
        {
            OptionA.Checked = false;
            OptionB.Checked = true;
            OptionC.Checked = false;
            OptionD.Checked = false;
            selectedValue = OptionB.Text;
        }

        private void QuestionNo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void OptionC_Click(object sender, EventArgs e)
        {
            OptionA.Checked = false;
            OptionB.Checked = false;
            OptionC.Checked = true;
            OptionD.Checked = false;
            selectedValue = OptionC.Text;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(qNo < qNoMax)
            {
                if(selectedValue == ans)
                {
                    score++;
                }
                MessageBox.Show($"Current Score: {score}");

                if (qNo == qNoMax -1) Next.Text = "Finish";
                qNo++;
                Quiz_Load(this, null);
            }
            else
            {
                if (selectedValue == ans)
                {
                    score++;
                }
                MessageBox.Show($"Current Score: {score}");
                int hasTaken;

                query = $"SELECT COUNT(*) FROM Score WHERE Student_Username = '{username}' AND qset = {qSetNo}";
                ds = conn.getData(query);
                hasTaken = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                if (hasTaken > 0)
                {
                    query = $"UPDATE Score SET Score = {score} WHERE Student_Username = '{username}' AND qSet = {qSetNo}";
                    conn.setData(query, "Okay");
                }

                else
                {
                    query = $"INSERT INTO Score (Student_Username, qSet, Score) Values ('{username}', {qSetNo}, {score})";
                    conn.setData(query, "Okay");
                }
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
        }

        private void OptionD_Click(object sender, EventArgs e)
        {
            OptionA.Checked = false;
            OptionB.Checked = false;
            OptionC.Checked = false;
            OptionD.Checked = true;
            selectedValue = OptionD.Text;
        }

        private void OptionA_Click(object sender, EventArgs e)
        {
            OptionA.Checked = true;
            OptionB.Checked = false;
            OptionC.Checked = false;
            OptionD.Checked = false;
            selectedValue = OptionA.Text;
        }
    }
}