﻿namespace AOOP_EmpowerHER
{
    partial class UseInformationQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestions
            // 
            this.lblQuestions.Font = new System.Drawing.Font("Trebuchet MS", 19.8F);
            this.lblQuestions.Location = new System.Drawing.Point(53, 42);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(624, 324);
            this.lblQuestions.TabIndex = 2;
            this.lblQuestions.Text = "label1";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(60, 393);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(290, 87);
            this.btn1.TabIndex = 5;
            this.btn1.Tag = "1";
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(387, 393);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(290, 87);
            this.btn2.TabIndex = 6;
            this.btn2.Tag = "2";
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(26, 500);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(233, 68);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Tag = "";
            this.btnPrevious.Text = "button1";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(475, 500);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(233, 68);
            this.btnNext.TabIndex = 10;
            this.btnNext.Tag = "";
            this.btnNext.Text = "button1";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // UseInformationQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 592);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblQuestions);
            this.Name = "UseInformationQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UseInformationQuiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}