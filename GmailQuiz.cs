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
    public partial class GmailQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public GmailQuiz()
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

                    lblQuestions.Text = "Question 1 of 20\r\n\nWhich of the following statements is true about Gmail?\r\n";
                    btn1.Text = "Gmail is a paid email service provided by Google.";
                    btn2.Text = "Gmail does not allow users to send or receive emails.";
                    btn3.Text = "Gmail offers features like blocking spam and creating an address book.\r\n";
                    btn4.Text = "Gmail does not have any unique features compared to other email services.";

                    correctAnswer = 3;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\nWhen you're organizing your messages, you can apply one or more ________ to categorize them.\r\n";
                    btn1.Text = "spam";
                    btn2.Text = "stickies";
                    btn3.Text = "replies";
                    btn4.Text = "labels";

                    correctAnswer = 4;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nIf you want to remove a message from your inbox without getting rid of it, use the ________ button.\r\n";
                    btn1.Text = "Delete";
                    btn2.Text = "Archive";
                    btn3.Text = "Report Spam";
                    btn4.Text = "Label";

                    correctAnswer = 2;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nHow does Gmail handle spam emails?\r\n";
                    btn1.Text = "Gmail forwards all spam emails to your inbox.";
                    btn2.Text = "Gmail deletes spam emails immediately upon arrival.";
                    btn3.Text = "Gmail automatically sends spam emails to a separate spam folder.";
                    btn4.Text = "Gmail stores spam emails indefinitely without deleting them.";

                    correctAnswer = 3;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nIf you want to respond to a group of people, you should use the ________ option.\r\n";
                    btn1.Text = "Forward";
                    btn2.Text = "Reply to all";
                    btn3.Text = "Signature";
                    btn4.Text = "Reply";

                    correctAnswer = 2;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 20\r\n\nTo get to your settings, you'll first need to click the ________ icon.\r\n";
                    btn1.Text = "envelope";
                    btn2.Text = "notifications";
                    btn3.Text = "lock";
                    btn4.Text = "gear";

                    correctAnswer = 4;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nTo sign out of Gmail, you'll first need to click ________.\r\n";
                    btn1.Text = "your name/profile icon";
                    btn2.Text = "the gear icon";
                    btn3.Text = "Reply";
                    btn4.Text = "Contacts";

                    correctAnswer = 1;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\n\nWhy would you want to create an email filter?\r\n";
                    btn1.Text = "to automatically label certain messages";
                    btn2.Text = "to automatically open certain messages";
                    btn3.Text = "to automatically forward certain messages";
                    btn4.Text = "to automatically reply to incoming messages";

                    correctAnswer = 1;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nWhat is the maximum size for attachments in Gmail?\r\n";
                    btn1.Text = "10 MB";
                    btn2.Text = "50 MB";
                    btn3.Text = "30 MB";
                    btn4.Text = "25 MB";

                    correctAnswer = 4;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nWhat is the purpose of the Spam folder in Gmail?\r\n";
                    btn1.Text = "to organize emails by sender";
                    btn2.Text = "to keep important emails safe";
                    btn3.Text = "to put unwanted messages";
                    btn4.Text = "to keep a backup of all emails";

                    correctAnswer = 3;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nHow can you schedule an email to be sent at a later time in Gmail?\r\n";
                    btn1.Text = "Click the arrow next to the Send button.";
                    btn2.Text = "Click the Forward button.";
                    btn3.Text = "Click the Reply button.";
                    btn4.Text = "Click the Attach button.";

                    correctAnswer = 1;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nWhat is the purpose of the recovery email address in Gmail?\r\n";
                    btn1.Text = "to send spam messages";
                    btn2.Text = "to recover deleted emails";
                    btn3.Text = "to reset your password";
                    btn4.Text = "to forward emails";

                    correctAnswer = 3;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nWhat is a \"canned response\" in Gmail?\r\n";
                    btn1.Text = "a message that is automatically deleted";
                    btn2.Text = "a spam email that is sent to multiple recipients";
                    btn3.Text = "a pre-written email message that can be reused";
                    btn4.Text = "a message that is automatically marked as \"read\"";

                    correctAnswer = 3;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nHow long do you have to unsend an email in Gmail?\r\n";
                    btn1.Text = "15 seconds";
                    btn2.Text = "20 seconds";
                    btn3.Text = "5 seconds";
                    btn4.Text = "10 seconds";

                    correctAnswer = 4;
                    break;
                case 15:
                    lblQuestions.Text = "Question 15 of 20\r\n\nWhat is the purpose of the \"CC\" field in Gmail?\r\n";
                    btn1.Text = "to send a \"read receipt\" to the sender";
                    btn2.Text = "to attach a file to the email";
                    btn3.Text = "to include another recipient in the email thread";
                    btn4.Text = "to send a \"blind copy\" to someone";

                    correctAnswer = 3;
                    break;
                case 16:
                    lblQuestions.Text = "Question 16 of 20\r\n\nHow do you attach a file to an email in Gmail?\r\n";
                    btn1.Text = "Copy and paste the file.";
                    btn2.Text = "Drag and drop the file.";
                    btn3.Text = "Type the file name.";
                    btn4.Text = "Click on the \"Attach file\" icon.";

                    correctAnswer = 4;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nWhat is the purpose of archiving an email in Gmail?\r\n\r\n";
                    btn1.Text = "to save the email for later reference";
                    btn2.Text = "to forward the email to someone\r\n";
                    btn3.Text = "to delete the email permanently";
                    btn4.Text = "to mark the email as important";

                    correctAnswer = 1;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\n\nHow do you search for an email in Gmail?\r\n";
                    btn1.Text = "Type the search query in the address bar.";
                    btn2.Text = "Type the search query in the search bar.";
                    btn3.Text = "Click on the \"Advanced search\" button.";
                    btn4.Text = "Click on the \"Search\" button.";

                    correctAnswer = 2;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\nIf you want to select every email on your inbox page, you can...\r\n\r\n";
                    btn1.Text = "right-click and drag a box over them.";
                    btn2.Text = "type \"delete\" into the search bar.";
                    btn3.Text = "click the Select All button.";
                    btn4.Text = "move them to the archive section.";

                    correctAnswer = 3;
                    break;
                case 20:
                    lblQuestions.Text = "Question 20 of 20\r\n\nWhat is the purpose of Gmail's \"Priority Inbox\" feature?\r\n";
                    btn1.Text = "to filter out spam emails";
                    btn2.Text = "to automatically sort emails based on importance";
                    btn3.Text = "to create custom email signatures";
                    btn4.Text = "to organize emails by sender";


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
