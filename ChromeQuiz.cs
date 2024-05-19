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
    public partial class ChromeQuiz : Form
    {
        int qTotal = 10;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public ChromeQuiz()
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

                    lblQuestions.Text = "Question 1 of 10\r\n\nThe Omnibox allows you to search and navigate the Web.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 10\r\n\nYou can download apps, extensions, and themes in the Web Store.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 10\r\n\nYou can add a bookmark by clicking the SSL icon.\r\n\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 2;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 10\r\n\nUsing incognito mode prevents hackers from stealing your information.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 2;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 10\r\n\nYou can open multiple websites within the same window using tabs.\r\n\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 10\r\n\nGoogle Chrome is not a free web browser from Google.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 2;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 10\r\n\nBecause Chrome was designed with web applications in mind, performance with websites like Gmail and Facebook is especially fast and reliable.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 10\r\n\nChrome has a variety of tools to help keep you safe online. It is constantly updating, so you're always protected from the latest malware and phishing scams.\r\n\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 10\r\n\nThe Chrome Web Store makes it easy to customize Chrome with web apps, themes, and extensions.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 10\r\n\nJust like Internet Explorer or Safari, Chrome comes pre-installed with your operating system.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 2;
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
