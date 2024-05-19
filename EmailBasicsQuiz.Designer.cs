namespace AOOP_EmpowerHER
{
    partial class EmailBasicsQuiz
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(458, 492);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(233, 68);
            this.btnNext.TabIndex = 14;
            this.btnNext.Tag = "";
            this.btnNext.Text = "button1";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(40, 492);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(233, 68);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Tag = "";
            this.btnPrevious.Text = "button1";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(381, 380);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(290, 87);
            this.btn2.TabIndex = 12;
            this.btn2.Tag = "2";
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(54, 380);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(290, 87);
            this.btn1.TabIndex = 11;
            this.btn1.Tag = "1";
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // lblQuestions
            // 
            this.lblQuestions.Font = new System.Drawing.Font("Trebuchet MS", 19.8F);
            this.lblQuestions.Location = new System.Drawing.Point(47, 32);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(624, 324);
            this.lblQuestions.TabIndex = 10;
            this.lblQuestions.Text = "label1";
            // 
            // EmailBasicsQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 592);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblQuestions);
            this.Name = "EmailBasicsQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailBasicsQuiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblQuestions;
    }
}