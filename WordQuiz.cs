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
    public partial class WordQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public WordQuiz()
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

                    lblQuestions.Text = "Question 1 of 20\r\n\nWhich of the following best describes the Ribbon?\r\n";
                    btn1.Text = "A toolbar with various commands";
                    btn2.Text = "A cable that connects your computer to a printer";
                    btn3.Text = "A slider that you can use to zoom the document";
                    btn4.Text = "A feature that can translate text into any language";

                    correctAnswer = 1;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\nWhat is the keyboard shortcut for making text bold in Word 2016?\r\n";
                    btn1.Text = "Ctrl + B";
                    btn2.Text = "Ctrl + U";
                    btn3.Text = "Ctrl + I";
                    btn4.Text = "Ctrl + Shift + B";

                    correctAnswer = 1;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nWhich of the following is NOT a way to create a new document in Word?\r\n";
                    btn1.Text = "Double-clicking the Word desktop icon";
                    btn2.Text = "Clicking the \"New\" button on the toolbar";
                    btn3.Text = "Clicking the \"Open\" button on the toolbar";
                    btn4.Text = "Pressing Ctrl + N";

                    correctAnswer = 3;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nWhat is line spacing in Word?\r\n";
                    btn1.Text = "The amount of space between lines of text\r\n";
                    btn2.Text = "The number of lines of text";
                    btn3.Text = "The amount of space between the text and the margin";
                    btn4.Text = "The amount of space between paragraphs";

                    correctAnswer = 1;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nSuppose you made an error while creating your document. You used the word “maroon” instead of “burgundy” in several places. What is the quickest way for you to correct your mistake?\r\n";
                    btn1.Text = "Use the Spelling and Grammar feature.";
                    btn2.Text = "Delete all of the text and start over.";
                    btn3.Text = "Use the Find and Replace feature.";
                    btn4.Text = "Insert SmartArt.";

                    correctAnswer = 3;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 20\r\n\nHow can you replace all occurrences of a word or phrase in Word?\r\n";
                    btn1.Text = "By using the Find and Replace dialog box";
                    btn2.Text = "By clicking the Replace button on the Home tab";
                    btn3.Text = "By using the Navigation Pane";
                    btn4.Text = "By manually deleting and replacing each occurrence";

                    correctAnswer = 1;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nIf you are printing multiple copies of a document and want the pages to be sorted 1, 2, 3, 1, 2, 3, which option would you use?\r\n";
                    btn1.Text = "Portrait Orientation";
                    btn2.Text = "Collated";
                    btn3.Text = "Uncollated";
                    btn4.Text = "Export";

                    correctAnswer = 2;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\n\nSuppose you've created a bulleted list, but the bullets are too close to the text. What is the best way to fix this?\r\n";
                    btn1.Text = "Adjust the indent markers on the Ruler.";
                    btn2.Text = "Change the page orientation.";
                    btn3.Text = "Press the Tab key to indent the text.";
                    btn4.Text = "Press the Caps Lock key on your keyboard.";

                    correctAnswer = 1;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nWhat is the main advantage of using a text box?\r\n";
                    btn1.Text = "It gives you more freedom to move the text around.";
                    btn2.Text = "It allows you to change the page orientation.";
                    btn3.Text = "It automatically appears on every page of your document.";
                    btn4.Text = "It automatically makes the text larger.";

                    correctAnswer = 1;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nWhat is a bulleted list in Word?\r\n";
                    btn1.Text = "A list of items that are in the center of the page";
                    btn2.Text = "A list of items that are highlighted with a bullet";
                    btn3.Text = "A list of items that are sorted in alphabetical order";
                    btn4.Text = "A list of items that are numbered";

                    correctAnswer = 2;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nIf you want to add text to the top of every page in your document, which feature would you use?\r\n";
                    btn1.Text = "Page layout";
                    btn2.Text = "Backstage view";
                    btn3.Text = "Footer";
                    btn4.Text = "Header";

                    correctAnswer = 4;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nIf you want to restart page numbering partway through your document, what do you need to do first?\r\n";
                    btn1.Text = "Add a section break.";
                    btn2.Text = "Turn off Track Changes.";
                    btn3.Text = "Create a table of contents.";
                    btn4.Text = "Close and reopen the document.";

                    correctAnswer = 1;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nWhat is a hyperlink?\r\n";
                    btn1.Text = "A way to add a note to a document";
                    btn2.Text = "A type of font style";
                    btn3.Text = "A button used to close a document";
                    btn4.Text = "A link from one document to another or to a web page or other URL";

                    correctAnswer = 4;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nWhat does the \"Ctrl + Enter\" keyboard shortcut do?\r\n";
                    btn1.Text = "Add a line break";
                    btn2.Text = "Close the current document";
                    btn3.Text = "Save the document";
                    btn4.Text = "Add a page break";

                    correctAnswer = 4;
                    break;
                case 15:
                    lblQuestions.Text = "Question 16 of 20\r\n\nWhat is the keyboard shortcut to create a new document?\r\n";
                    btn1.Text = "Ctrl + P";
                    btn2.Text = "Ctrl + O";
                    btn3.Text = "Ctrl + N";
                    btn4.Text = "Ctrl + S";

                    correctAnswer = 3;
                    break;
                case 16:
                    lblQuestions.Text = "Question 16 of 20\r\n\nHow do you save a document with a new name?\r\n";
                    btn1.Text = "Click Format and select \"Save As.\"";
                    btn2.Text = "Press Ctrl + S and enter a new name.";
                    btn3.Text = "Click the Save As button.";
                    btn4.Text = "Type Ctrl + V and enter a new name.";

                    correctAnswer = 3;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nWhat is the keyboard shortcut to undo an action in Word?\r\n";
                    btn1.Text = "Ctrl + C";
                    btn2.Text = "Ctrl + Z";
                    btn3.Text = "Ctrl + X";
                    btn4.Text = "Ctrl + Y";

                    correctAnswer = 2;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\n\nWhat is the default file extension for Word documents?\r\n";
                    btn1.Text = ".jpg";
                    btn2.Text = ".pdf";
                    btn3.Text = ".docx";
                    btn4.Text = ".txt";

                    correctAnswer = 3;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\nHow can you protect a document from unwanted changes?\r\n";
                    btn1.Text = "By using a password to open the documen";
                    btn2.Text = "By hiding the document";
                    btn3.Text = "By disabling the \"Track Changes\" feature";
                    btn4.Text = "By enabling the \"Read-only\" feature";

                    correctAnswer = 4;
                    break;
                case 20:
                    lblQuestions.Text = "Question 20 of 20\r\n\nWhat is the easiest way to share and edit a Word document with other people?\r\n";
                    btn1.Text = "None of these would work";
                    btn2.Text = "By sending the document as an email attachment";
                    btn3.Text = "By printing the document and mailing it";
                    btn4.Text = "By uploading the document to a cloud storage service";

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
