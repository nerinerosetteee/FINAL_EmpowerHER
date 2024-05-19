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
    public partial class EmailBasicsQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public EmailBasicsQuiz()
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

                    lblQuestions.Text = "Question 1 of 20\r\n\nGenerally, when you receive an email, it will appear in your compose pane.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 2;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\n\"jane@gmail.com\" is a correctly written email address.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nServices such as Gmail offer free email accounts\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 1;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nThe subject is a brief description of what the email is about.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nAn email can have the following features or fields: Subject, Recipients, Body, Cc, Attachments, Bcc.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 20\r\n\nAfter sending an email, it is usually delivered in 2-3 business days\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 2;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nIf you want to share an email you've received, you can forward it.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 1;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\n\nThe term \"phishing\" refers to the process of creating a new email address.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 2;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nAttachment is another term for junk email.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";


                    correctAnswer = 2;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nYou create an email signature, it's best to include your preferred contact info.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 1;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nEmail (electronic mail) is a way to send and receive messages across the Internet.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 1;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nEmail similar to traditional mail, but it also has some key differences\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 1;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nTraditional mail is delivered electronically across the internet, while the Email is delivered to a home or post office box by a mail carrier.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 2;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nEmail is delivered instantly while Traditional mail is delivered between a couple of days, to a couple of weeks, depending on where it’s been sent.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 2;
                    break;
                case 15:
                    lblQuestions.Text = "Question 15 of 20\r\n\nEmail is usually packaged with a calendar, address book, instant messaging, and more for convenience and productivity.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 1;
                    break;
                case 16:
                    lblQuestions.Text = "Question 16 of 20\r\n\nEmail service providers do not have tools that allow you to file, label, prioritize, find, group, and filter your emails for easy management.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 1;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nYour email is delivered to your own personal and private account with a password required to access and view emails.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 2;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\n\nYou have to be at home to get your mail. You cannot access it from any computer or mobile device that has an Internet connection.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 2;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\nYou can send an email to multiple people at once, giving you the option to include as few as or as many people as you want in a conversation.\r\n";
                    btn1.Text = "True";
                    btn2.Text = "False";

                    correctAnswer = 1;
                    break;
                case 20:
                    lblQuestions.Text = "Question 20 of 20\r\n\nIf you want to sign up for an account like Facebook or order products from services like Amazon, you will need an email address so you can be safely identified and contacted.\r\n\r\n";
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
