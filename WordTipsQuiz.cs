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
    public partial class WordTipsQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public WordTipsQuiz()
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

                    lblQuestions.Text = "Question 1 of 20\r\n\nHow can you insert a self-updating date stamp in a Word document?\r\n";
                    btn1.Text = "By inserting a date and time field";
                    btn2.Text = "By importing a date from another document";
                    btn3.Text = "By copying and pasting a date stamp";
                    btn4.Text = "By typing the date manually";

                    correctAnswer = 1;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\nHow can you reduce eye strain while reading a Word document?\r\n";
                    btn1.Text = "By using a colored background";
                    btn2.Text = "By using the Read mode";
                    btn3.Text = "By turning off the monitor";
                    btn4.Text = "By decreasing the font size";

                    correctAnswer = 2;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nWhich shortcut key can be used to insert a bulleted list in a Word document?\r\n";
                    btn1.Text = "Ctrl + L";
                    btn2.Text = "Ctrl + 1";
                    btn3.Text = "Ctrl + B";
                    btn4.Text = "Ctrl + Shift + L";

                    correctAnswer = 1;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nHow can you quickly translate a word or a phrase in a Word document?\r\n";
                    btn1.Text = "By using the Smart Lookup feature";
                    btn2.Text = "By using the Thesaurus";
                    btn3.Text = "By using the Translate feature";
                    btn4.Text = "By using the Research pane";

                    correctAnswer = 3;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nWhich shortcut key can be used to make text bold in a Word document?\r\n";
                    btn1.Text = "Ctrl + B";
                    btn2.Text = "Ctrl + U";
                    btn3.Text = "Ctrl + I";
                    btn4.Text = "Ctrl + K";

                    correctAnswer = 1;
                    break;
                case 6:
                    lblQuestions.Text = "Question 7 of 20\r\n\nHow can you remove all formatting from a block of text in a Word document?\r\n";
                    btn1.Text = "By using the Styles pane";
                    btn2.Text = "By using the Font dialog box";
                    btn3.Text = "By using the Clear Formatting command";
                    btn4.Text = "By using the Paragraph dialog box";

                    correctAnswer = 3;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nHow can you recover an unsaved Word document?\r\n";
                    btn1.Text = "By using the AutoRecover feature";
                    btn2.Text = "By restoring a previous version of the document";
                    btn3.Text = "By searching for the document in the Recycle Bin";
                    btn4.Text = "By using the Recover Unsaved Documents feature";

                    correctAnswer = 4;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\n\nWhat's the best way to recover a corrupted Word document?\r\n";
                    btn1.Text = "By re-creating the document from scratch";
                    btn2.Text = "By using the built-in repair tool in Word";
                    btn3.Text = "By opening the document in a different program";
                    btn4.Text = "By copying and pasting the content into a new document";

                    correctAnswer = 2;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nHow can you create a link to another section within the same Word document?\r\n";
                    btn1.Text = "By using the Insert Hyperlink dialog box";
                    btn2.Text = "By using the Bookmark feature";
                    btn3.Text = "By using the Reference tab in the Ribbon";
                    btn4.Text = "By copying and pasting the section into a new location";

                    correctAnswer = 2;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nWhich keyboard shortcut is used to save a document in Word?\r\n";
                    btn1.Text = "Ctrl + F";
                    btn2.Text = "Ctrl + N";
                    btn3.Text = "Ctrl + P";
                    btn4.Text = "Ctrl + S";

                    correctAnswer = 4;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nWhat is a table of contents in Microsoft Word?\r\n";
                    btn1.Text = "A list of authors contributing to a document";
                    btn2.Text = "A list of keywords used in a document";
                    btn3.Text = "A list of all the headings in a document\r\n";
                    btn4.Text = "A list of references used in a document";

                    correctAnswer = 3;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nWhat are the two options for formatting a table of contents?\r\n";
                    btn1.Text = "Classic and Modern";
                    btn2.Text = "Automatic and Manual";
                    btn3.Text = "Bold and Italics";
                    btn4.Text = "Vertical and Horizontal";

                    correctAnswer = 2;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nWhat is a bibliography?\r\n";
                    btn1.Text = "A summary of a research paper";
                    btn2.Text = "A list of research questions";
                    btn3.Text = "A list of sources used in a research paper";
                    btn4.Text = "A summary of a book";

                    correctAnswer = 3;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nWhat is the purpose of a hanging indent in a bibliography?\r\n";
                    btn1.Text = "To make the citation stand out";
                    btn2.Text = "To differentiate between different types of sources";
                    btn3.Text = "To make the list of citations easier to read";
                    btn4.Text = "To save space";

                    correctAnswer = 3;
                    break;
                case 15:
                    lblQuestions.Text = "Question 15 of 20\r\n\nWhat is the difference between a bibliography and a Works Cited page?\r\n";
                    btn1.Text = "A bibliography only includes sources cited in the text, while a Works Cited page includes all sources consulted.\r\n";
                    btn2.Text = "A Works Cited page only includes sources cited in the text, while a bibliography includes all sources consulted.\r\n";
                    btn3.Text = "They are the same thing.";
                    btn4.Text = "A Works Cited page includes summaries of the sources consulted, while a bibliography only includes the list of sources consulted\r\n";

                    correctAnswer = 2;
                    break;
                case 16:
                    lblQuestions.Text = "Question 17 of 20\r\n\nHow do you change the default font in Word?\r\n";
                    btn1.Text = "By going to the File tab and clicking Options, then selecting General and choosing the default font";
                    btn2.Text = "By right-clicking on the text and selecting Font from the context menu";
                    btn3.Text = "By using the Ctrl + Shift + F shortcut";
                    btn4.Text = "By going to the Home tab and clicking the Font dialog box launcher";

                    correctAnswer = 1;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nWhat is the purpose of creating forms in Word?\r\n";
                    btn1.Text = "To insert images";
                    btn2.Text = "To collect data from people";
                    btn3.Text = "To format text";
                    btn4.Text = "To write a letter";

                    correctAnswer = 2;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\n\nHow can you protect a form from being edited by unauthorized users?\r\n\r\n";
                    btn1.Text = "Save the file under a different name.";
                    btn2.Text = "Use track changes.";
                    btn3.Text = "Use password protection.";
                    btn4.Text = "Use a digital signature.";

                    correctAnswer = 3;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\nWhat is the advantage of using the Format Painter in Word?\r\n";
                    btn1.Text = "It can be used to create custom styles.";
                    btn2.Text = "It allows you to edit text without losing formatting.";
                    btn3.Text = "It saves time by allowing you to quickly copy formatting.";
                    btn4.Text = "It automatically corrects spelling and grammar errors.";

                    correctAnswer = 3;
                    break;
                case 20:
                    lblQuestions.Text = "Question 20 of 20\r\n\nWhat's the best way to reduce the amount of ink or toner used when printing a Word document?\r\n\r\n";
                    btn1.Text = "Print in color.";
                    btn2.Text = "Print in draft mode.";
                    btn3.Text = "Use a high-quality print setting.";
                    btn4.Text = "Use a larger font size.";

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
