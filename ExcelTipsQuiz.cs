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
    public partial class ExcelTipsQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public ExcelTipsQuiz()
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

                    lblQuestions.Text = "Question 1 of 20\r\n\nWhich formula is used to insert the current date in a cell?\r\n";
                    btn1.Text = "=DATE()";
                    btn2.Text = "=NOW()";
                    btn3.Text = "=TODAY()";
                    btn4.Text = "=TIME()";

                    correctAnswer = 3;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\nWhat is the shortcut key to use the Fill Handle in Excel?\r\n";
                    btn1.Text = "Ctrl + E";
                    btn2.Text = "Ctrl + C";
                    btn3.Text = "Ctrl + V";
                    btn4.Text = "Ctrl + X";

                    correctAnswer = 1;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nHow can you quickly fill a series of numbers in Excel?\r\n";
                    btn1.Text = "By copying and pasting";
                    btn2.Text = "By using the Fill Handle";
                    btn3.Text = "By typing each number manually";
                    btn4.Text = "By using a formula";

                    correctAnswer = 2;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nHow can you apply the formatting of one cell to another cell?\r\n";
                    btn1.Text = "By manually copying and pasting";
                    btn2.Text = "By using the Fill Handle";
                    btn3.Text = "By using the Format Painter";
                    btn4.Text = "By using a formula";

                    correctAnswer = 3;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nHow can you quickly add a column of numbers in Excel using AutoSum??\r\n";
                    btn1.Text = "By typing the formula manually";
                    btn2.Text = "By using a function";
                    btn3.Text = "By using the AutoSum feature";
                    btn4.Text = "By using the Fill Handle";

                    correctAnswer = 3;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 20\r\n\nWhich of the following is the Quick Access Toolbar in Excel?\r\n";
                    btn1.Text = "The formula bar";
                    btn2.Text = "The toolbar at the top of the screen";
                    btn3.Text = "The ribbon";
                    btn4.Text = "The status bar";

                    correctAnswer = 2;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nHow can you quickly duplicate a sheet in Excel?\r\n";
                    btn1.Text = "By using the Fill Handle\r\n";
                    btn2.Text = "By creating a new sheet";
                    btn3.Text = "By copying and pasting the sheet";
                    btn4.Text = "By right-clicking the sheet tab";

                    correctAnswer = 4;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\n\nHow can you quickly navigate to a specific sheet in Excel?\r\n";
                    btn1.Text = "By using the \"Go To\" dialog box";
                    btn2.Text = "By scrolling through the sheet tabs";
                    btn3.Text = "By using the Format Painter";
                    btn4.Text = "By using the Ribbon";

                    correctAnswer = 1;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nWWhat happens when you merge cells in Excel?\r\n";
                    btn1.Text = "The merged cells become uneditable.";
                    btn2.Text = "The merged cells lose data.";
                    btn3.Text = "The merged cells create a new file.";
                    btn4.Text = "The merged cells create a new sheet.";

                    correctAnswer = 2;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nWhat is the Quick Analysis tool in Excel?\r\n";
                    btn1.Text = "A tool for formatting cells";
                    btn2.Text = "A tool for merging cells";
                    btn3.Text = "A tool for analyzing data";
                    btn4.Text = "A tool for creating charts";

                    correctAnswer = 3;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nWhich of the following is an advantage of linking a chart to the data using a formula?\r\n\r\n";
                    btn1.Text = "It creates a backup of the data.";
                    btn2.Text = "It allows you to customize the chart.";
                    btn3.Text = "It makes the chart easier to read.";
                    btn4.Text = "It allows the chart to automatically update.";

                    correctAnswer = 4;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nWhich of the following is an example of when you might want to use the Transpose feature?\r\n";
                    btn1.Text = "When you want to merge cells";
                    btn2.Text = "When you want to create a chart";
                    btn3.Text = "When you want to convert data to a table";
                    btn4.Text = "When you want to flip data on its side";

                    correctAnswer = 4;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nWhat is the purpose of using absolute cell references in Excel?\r\n";
                    btn1.Text = "To make the formulas more flexible";
                    btn2.Text = "To automatically calculate the sum of a range of cells";
                    btn3.Text = "To ensure that a specific cell reference stays constant";
                    btn4.Text = "To make it easier to copy formulas to other cells";

                    correctAnswer = 3;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nWhich of the following steps can also be used to insert a new row in Excel?\r\n";
                    btn1.Text = "Press the \"Delete\" key on your keyboard.";
                    btn2.Text = "Right-click on the row number and select \"Insert.\"";
                    btn3.Text = "Click on \"Edit\" in the toolbar and select \"Insert Row.\"";
                    btn4.Text = "Click on \"Format\" in the toolbar and select \"Insert Row.\" ";

                    correctAnswer = 2;
                    break;
                case 15:
                    lblQuestions.Text = "Question 16 of 20\r\n\nWhat are named ranges used for?\r\n";
                    btn1.Text = "To format cells with a specific name";
                    btn2.Text = "To group cells together";
                    btn3.Text = "To assign a name to a cell range";
                    btn4.Text = "To highlight cells";

                    correctAnswer = 3;
                    break;
                case 16:
                    lblQuestions.Text = "Question 16 of 20\r\n\nHow can you identify inconsistent data in Excel?\r\n";
                    btn1.Text = "Use the \"SUM\" function.";
                    btn2.Text = "Use the \"IF\" function.";
                    btn3.Text = "Check the spelling in each cell.";
                    btn4.Text = "Look for cells highlighted with a green triangle in the corner.";

                    correctAnswer = 4;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nWhat does the VLOOKUP function do?\r\n";
                    btn1.Text = "Looks for values in a vertical column";
                    btn2.Text = "Calculates a total sum";
                    btn3.Text = "Sorts data alphabetically";
                    btn4.Text = "Looks for values in a horizontal row";

                    correctAnswer = 1;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\n\nWhat does the PROPER function do in Excel?\r\n";
                    btn1.Text = "Converts text to all lowercase letters";
                    btn2.Text = "Removes all spaces from a text string";
                    btn3.Text = "Capitalizes the first letter of each word in a text string";
                    btn4.Text = "Converts text to all uppercase letters";

                    correctAnswer = 3;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\nWhat does the CONCATENATE function do in Excel?\r\n\r\n";
                    btn1.Text = "Converts a value to text in a specific format";
                    btn2.Text = "Returns the number of characters in a cell or range";
                    btn3.Text = "Combines the contents of two or more cells into one cell";
                    btn4.Text = "Searches for a value in a table or range and returns a corresponding value";

                    correctAnswer = 3;
                    break;
                case 20:
                    lblQuestions.Text = "Question 20 of 20\r\n\nWhat is a good practice to follow when printing an Excel spreadsheet?\r\n";
                    btn1.Text = "Print in color to make it stand out.";
                    btn2.Text = "Print multiple copies at once.";
                    btn3.Text = "Use a tiny font size.";
                    btn4.Text = "Print only the parts you need.";


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
