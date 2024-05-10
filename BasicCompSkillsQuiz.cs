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
    public partial class BasicCompSkillsQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public BasicCompSkillsQuiz()
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

                    lblQuestions.Text = "Question 1 of 20\r\n\nWhat is the role of an operating system?\r\n";
                    btn1.Text = "to provide power to the computer";
                    btn2.Text = "To delete unnecessary information";
                    btn3.Text = "To create documents and files";
                    btn4.Text = "To manage a computer's hardware and software";

                    correctAnswer = 4;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\nWhat is a folder on a computer?\r\n";
                    btn1.Text = "An external device that stores information";
                    btn2.Text = "A type of file";
                    btn3.Text = "A program that performs a specific task";
                    btn4.Text = "A container for files and other folders";

                    correctAnswer = 4;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nWhat type of information can you find in the help system?\r\n";
                    btn1.Text = "Information about how to use programs and features";
                    btn2.Text = "Updates for your computer's operating system";
                    btn3.Text = "Music and videos";
                    btn4.Text = "Files and folders";

                    correctAnswer = 1;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nWhat’s the EASIEST way to get additional help if you can’t find what you need?\r\n";
                    btn1.Text = "hire a professional computer technician.";
                    btn2.Text = "Give up and try again later.";
                    btn3.Text = "Search online for answers to your question.";
                    btn4.Text = "Contact the manufacturer's customer support service.";

                    correctAnswer = 3;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nIf you're working in a document and use \"Undo,\" but then realize you didn’t want to undo your most recent change, _____ will restore it.\r\n";
                    btn1.Text = "Redo";
                    btn2.Text = "Undo";
                    btn3.Text = "Save";
                    btn4.Text = "Open";

                    correctAnswer = 1;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 20\r\n\nWhat is a file extension?\r\n";
                    btn1.Text = "The first part of a file name which you selected";
                    btn2.Text = "The number of bytes in a file";
                    btn3.Text = "The last part of a file name, which indicates the type of file";
                    btn4.Text = "The date the file was created";

                    correctAnswer = 3;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nWhat is a common file extension for a digital image?\r\n";
                    btn1.Text = ".pdf";
                    btn2.Text = ".jpg";
                    btn3.Text = ".exe";
                    btn4.Text = ".doc";

                    correctAnswer = 2;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\n\nWhat is a common file extension for a video?\r\n";
                    btn1.Text = ".ppt";
                    btn2.Text = ".mp4";
                    btn3.Text = ".xls";
                    btn4.Text = ".txt";

                    correctAnswer = 2;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nWhat is downloading?\r\n";
                    btn1.Text = "The process of copying a file from your computer to a remote server.";
                    btn2.Text = "The process of deleting a file from your computer.";
                    btn3.Text = "The process of copying a file from a remote server to your computer.";
                    btn4.Text = "The process of renaming a file on your computer.";

                    correctAnswer = 3;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nWhat is uploading?\r\n";
                    btn1.Text = "The process of creating a file on your computer";
                    btn2.Text = "The process of copying a file from your computer to a remote server";
                    btn3.Text = "The process of compressing a file on your computer";
                    btn4.Text = "The process of copying a file from a remote server to your computer";

                    correctAnswer = 2;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nWhat is open source software?\r\n";
                    btn1.Text = "Software with source code that's hidden";
                    btn2.Text = "Software that can be installed without permission";
                    btn3.Text = "Software that can only be installed with a special license";
                    btn4.Text = "Software with source code that's publicly available";

                    correctAnswer = 4;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nWhat does PDF stand for?\r\n";
                    btn1.Text = "Professional Document Format";
                    btn2.Text = "Personal Data Format";
                    btn3.Text = "Public Domain Format";
                    btn4.Text = "Portable Document Format";

                    correctAnswer = 4;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nWhat is the purpose of a Wi-Fi password?\r\n";
                    btn1.Text = "To make your network slower";
                    btn2.Text = "To prevent unauthorized access to your network";
                    btn3.Text = "To make your network faster";
                    btn4.Text = "To connect your devices to the Internet";

                    correctAnswer = 2;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nWhat is software?\r\n";
                    btn1.Text = "The physical components of a computer";
                    btn2.Text = "A type of virus\r\n";
                    btn3.Text = "Programs and apps that run on a computer";
                    btn4.Text = "The Internet";

                    correctAnswer = 3;
                    break;
                case 15:
                    lblQuestions.Text = "Question 15 of 20\r\n\nHow can you check for updates on a Mac computer?\r\n";
                    btn1.Text = "Through the App Store or System Preferences";
                    btn2.Text = "By clearing your browsing history";
                    btn3.Text = "By calling Apple support";
                    btn4.Text = "By defragmenting your hard drive";

                    correctAnswer = 1;
                    break;
                case 16:
                    lblQuestions.Text = "Question 17 of 20\r\n\nWhat is malware?\r\n";
                    btn1.Text = "A general term for any software that is designed to harm your computer";
                    btn2.Text = "A type of virus that infects your computer through email attachments";
                    btn3.Text = "A program that helps you clean up your computer";
                    btn4.Text = "A type of computer virus that spreads through USB drives";

                    correctAnswer = 1;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nWhat should you do if you suspect that your computer has a virus?\r\n";
                    btn1.Text = "Call your Internet provider.";
                    btn2.Text = "Pay a ransom to the hackers who infected your computer and hope they remove the virus for you";
                    btn3.Text = "Ignore it and hope the problem goes away.";
                    btn4.Text = "Install a free antivirus program and run a scan on your computer.";

                    correctAnswer = 4;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\n\nWhat is power cycling?\r\n";
                    btn1.Text = "A process to update the firmware of a device";
                    btn2.Text = "A process to shut down and restart a device";
                    btn3.Text = "A process to change the battery of a device";
                    btn4.Text = "A process to increase the screen brightness of a device";

                    correctAnswer = 2;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\nWhat happens during defragmentation?\r\n";
                    btn1.Text = "Files and folders are rearranged to optimize performance";
                    btn2.Text = "Files and folders are encrypted for security.";
                    btn3.Text = "Files and folders are compressed to save space.";
                    btn4.Text = "Files and folders are deleted from the hard drive.";

                    correctAnswer = 1;
                    break;
                case 20:
                    lblQuestions.Text = "Question 20 of 20\r\n\nIn Safe Mode, which type of drivers are loaded?\r\n";
                    btn1.Text = "No drivers";
                    btn2.Text = "All drivers.";
                    btn3.Text = "Only essential drivers";
                    btn4.Text = "Only third-party drivers";

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
