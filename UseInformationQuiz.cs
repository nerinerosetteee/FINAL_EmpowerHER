using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOOP_EmpowerHER
{
    public partial class UseInformationQuiz : Form
    {
        int qTotal = 10;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;

        public UseInformationQuiz()
        {
            InitializeComponent();
            setOfQuestions(qNumber);
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender; ;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            // Check if the user has answered the question
            if (!answered)
            {
                if (buttonTag == correctAnswer)
                {
                    scoreNum++;
                }


                // Set answered flag to true
                answered = true;

                // Enable the Next button
                btnNext.Enabled = true;
            }
        }

        private void setButtonLabels()
        {
            // Update button labels based on current question number
            if (qNumber == 1)
            {
                btnPrevious.Text = "Previous";
                btnPrevious.Enabled = false; // Display "Previous" on the first question
            }
            else
            {
                btnPrevious.Text = "Previous"; // Display "Back" on subsequent questions
                btnPrevious.Enabled = true;
            }

            if (qNumber == qTotal)
            {
                btnNext.Text = "Submit"; // Display "Submit" on the last question
            }
            else
            {
                btnNext.Text = "Next"; // Display "Next" on other questions
            }
        }

        private void setOfQuestions(int question_number)
        {
            setButtonLabels();
            switch (question_number)
            {
                case 1:

                    lblQuestions.Text = "Question 1 of 10\r\n\nAn example of synthesis is combining others' ideas with your own to create something new?\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 10\r\n\nAn original work is automatically protected by Creative Commons the moment it's created.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 2;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 10\r\n\nYou can easily avoid plagiarism by simply changing a few words from the original source.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 2;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 10\r\n\nIt is important to cite your sources to avoid plagiarism\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 10\r\n\nIn order to use Creative Commons content, you will need to follow certain rules.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 10\r\n\nBefore you dive in, you should not take a moment to organize your thoughts and maybe don’t even examine your own thought process.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 2;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 10\r\n\nYou can bookmark your sources using your browser's built-in bookmarks feature (sometimes called the favorites feature).\r\n\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 10\r\n\nTo use information properly, you have to synthesize it.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 10\r\n\nSynthesis is not important when it comes to finding and using information online.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 2;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 10\r\n\nPlagiarism is presenting someone else's work as your own.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 1;
                    break;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (qNumber > 1) // Check if not on the first question
            {
                qNumber--; // Decrement the question number
                setOfQuestions(qNumber); // Set previous question
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (answered)
            {
                qNumber++;
                if (qNumber <= qTotal)
                {
                    setOfQuestions(qNumber);
                    // Clear the answered flag for the next question
                    answered = false;
                    // Enable all answer buttons for the new question
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    // Disable the Next button until the user answers the current question
                    btnNext.Enabled = false;
                }
                else
                {
                    MessageBox.Show(
                        "Quiz Ended!" + Environment.NewLine +
                        "Your Score: " + scoreNum + " / " + qTotal + Environment.NewLine +
                        "Click OK to play again."
                        );
                    scoreNum = 0;
                    qNumber = 1;
                    setOfQuestions(qNumber);
                    // Clear the answered flag for the new quiz
                    answered = false;
                    // Enable all answer buttons for the new quiz
                    btn1.Enabled = true;
                    btn2.Enabled = true;

                    // Disable the Next button until the user answers the current question
                    btnNext.Enabled = false;
                }
            }
        }

    }
}
