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
    public partial class InternetBasicsQuiz : Form
    {
        int qTotal = 10;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public InternetBasicsQuiz()
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

                    lblQuestions.Text = "Question 1 of 10\r\n\nWhat is the Internet?\r\n";
                    btn1.Text = "A type of web browser";
                    btn2.Text = "A global collection of different websites";
                    btn3.Text = "A folder on your computer that stores important files";
                    btn4.Text = "A global network of computers and electronic devices";

                    correctAnswer = 4;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 10\r\n\nWhat is social media?\r\n";
                    btn1.Text = "A type of online game";
                    btn2.Text = "A type of email service";
                    btn3.Text = "A program used to search for information on the Internet";
                    btn4.Text = "A platform that allows users to connect and share content with others";

                    correctAnswer = 4;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 10\r\n\nWhich of the following is NOT a web browser?\r\n\r\n";
                    btn1.Text = "Windows";
                    btn2.Text = "Firefox";
                    btn3.Text = "Edge";
                    btn4.Text = "Chrome";

                    correctAnswer = 1;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 10\r\n\nWhen talking about the Web, \"link\" is an abbreviation for ________.\r\n";
                    btn1.Text = "chain-link";
                    btn2.Text = "hyperlink";
                    btn3.Text = "superlink";
                    btn4.Text = "blink";

                    correctAnswer = 2;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 10\r\n\nWhat are browser tabs mainly used for?\r\n\r\n";
                    btn1.Text = "Selecting a Wi-Fi network to connect to";
                    btn2.Text = "Viewing two webpages side-by-side";
                    btn3.Text = "Ensuring that your personal information cannot be seen by hackers";
                    btn4.Text = "Opening multiple webpages in the same browser window";

                    correctAnswer = 4;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 10\r\n\nWhat is a router used for?\r\n\r\n";
                    btn1.Text = "Creating driving directions";
                    btn2.Text = "Connecting several devices to a single Internet connection";
                    btn3.Text = "Ensuring that your personal information is secure\r\n";
                    btn4.Text = "Providing power to the computer";

                    correctAnswer = 2;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 10\r\n\nIf a file is stored in the cloud but you want to copy it to your computer, you'll need to ________ it.\r\n";
                    btn1.Text = "print";
                    btn2.Text = "download";
                    btn3.Text = "bookmark";
                    btn4.Text = "upload";

                    correctAnswer = 2;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 10\r\n\nWhat is Wi-Fi?\r\n";
                    btn1.Text = "A type of sound card";
                    btn2.Text = "A type of software that scans for viruses";
                    btn3.Text = "A wireless network connection";
                    btn4.Text = "An extra-wide computer case used by servers";

                    correctAnswer = 3;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 10\r\n\nWhat is an IP address?\r\n";
                    btn1.Text = "A program used to search for information on the Internet.";
                    btn2.Text = "A standard protocol used for sending email.";
                    btn3.Text = "A code used to encrypt data sent over the Internet.";
                    btn4.Text = "A unique identifier assigned to every device connected to the Internet.";

                    correctAnswer = 4;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 10\r\n\nWhat is telecommuting?\r\n";
                    btn1.Text = "Playing video games with others over the Internet";
                    btn2.Text = "Streaming music online";
                    btn3.Text = "Working from home or another remote location using the Internet";
                    btn4.Text = "Sharing photos on social media";

                    correctAnswer = 3;
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
                    btn3.Enabled = true;
                    btn4.Enabled = true;
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
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    // Disable the Next button until the user answers the current question
                    btnNext.Enabled = false;
                }
            }
        }

    }
}
