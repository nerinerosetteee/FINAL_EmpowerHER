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
    public partial class TechSavvy : Form
    {
        int qTotal = 10;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public TechSavvy()
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

                    lblQuestions.Text = "Question 1 of 10\r\n\nWhat is the purpose of taking a screenshot?\r\n";
                    btn1.Text = "To delete unwanted files";
                    btn2.Text = "To visually share information with others";
                    btn3.Text = "To print a copy of a webpage";
                    btn4.Text = "To create a backup of important files";

                    correctAnswer = 2;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 10\r\n\nWhat is the purpose of the Downloads folder in Windows?\r\n";
                    btn1.Text = "To store files you want to keep";
                    btn2.Text = "To store files that are too large";
                    btn3.Text = "To store files you want to delete";
                    btn4.Text = "To store data about your computer";

                    correctAnswer = 1;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 10\r\n\nHow can you access the Print dialog box in most programs?\r\n";
                    btn1.Text = "Ctrl + V";
                    btn2.Text = "Ctrl + S";
                    btn3.Text = "Ctrl + P";
                    btn4.Text = "Ctrl + C";

                    correctAnswer = 3;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 10\r\n\nWhich type of printer uses ink cartridges?\r\n";
                    btn1.Text = "Thermal printer";
                    btn2.Text = "Laser printer";
                    btn3.Text = "Inkjet printer";
                    btn4.Text = "Dot matrix printer";

                    correctAnswer = 3;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 10\r\n\nWhich option in the Print dialog box allows you to print on both sides of the paper?\r\n";
                    btn1.Text = "Two-Sided";
                    btn2.Text = "Colors/Grayscale";
                    btn3.Text = "Orientation";
                    btn4.Text = "Paper Size";

                    correctAnswer = 1;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 10\r\n\nWhat is a ZIP file?\r\n";
                    btn1.Text = "A file format only for audio";
                    btn2.Text = "Multiple files compressed into one";
                    btn3.Text = "A file format only for images";
                    btn4.Text = "None of these things";

                    correctAnswer = 2;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 10\r\n\nHow can you extract files from a ZIP file?\r\n";
                    btn1.Text = "By renaming the ZIP file";
                    btn2.Text = "By copying and pasting the ZIP file";
                    btn3.Text = "By deleting the ZIP file";
                    btn4.Text = "By using a file extraction program";

                    correctAnswer = 4;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 10\r\n\nWhat is a screencast?\r\n";
                    btn1.Text = "A video recording of a computer screen";
                    btn2.Text = "A type of image file";
                    btn3.Text = "A type of music file";
                    btn4.Text = "A video game console";

                    correctAnswer = 1;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 10\r\n\nWhat is the benefit of using screen recording software?\r\n";
                    btn1.Text = "It has a virtual assistant feature.";
                    btn2.Text = "It does not require an internet connection.";
                    btn3.Text = "It doesn't take up space on your computer.";
                    btn4.Text = "It can record audio and video simultaneously.";

                    correctAnswer = 4;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 10\r\n\nWhat is a PDF?\r\n";
                    btn1.Text = "A type of video file";
                    btn2.Text = "A type of audio file";
                    btn3.Text = "A type of software";
                    btn4.Text = "A type of document file";

                    correctAnswer = 4;
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
