using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOOP_EmpowerHER
{
    public partial class ExcelQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public ExcelQuiz()
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

                    lblQuestions.Text = "Question 1 of 20\r\n\nThe intersection of a row and a column is called a ________.\r\n";
                    btn1.Text = "chart";
                    btn2.Text = "cell";
                    btn3.Text = "sum";
                    btn4.Text = "worksheet";

                    correctAnswer = 2;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\nA group of cells is called a ________.\r\n";
                    btn1.Text = "multicell";
                    btn2.Text = "cell range";
                    btn3.Text = "cell cluster";
                    btn4.Text = "chart";

                    correctAnswer = 2;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nWhere is the fill handle located?\r\n";
                    btn1.Text = "at the beginning of any formula or function";
                    btn2.Text = "in the bottom-right corner of the selected cell";
                    btn3.Text = "on the right side of the Home tab on the Ribbon";
                    btn4.Text = "in Backstage view";

                    correctAnswer = 2;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nWhich of the following is NOT a type of alignment in Excel?\r\n";
                    btn1.Text = "forward";
                    btn2.Text = "right";
                    btn3.Text = "center";
                    btn4.Text = "left";

                    correctAnswer = 1;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nYou can click the tabs at the bottom of a workbook to switch between ________.\r\n";
                    btn1.Text = "worksheets";
                    btn2.Text = "permissions";
                    btn3.Text = "number formats";
                    btn4.Text = "formulas";

                    correctAnswer = 1;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 20\r\n\nWhat is the purpose of grouping worksheets in Excel?\r\n";
                    btn1.Text = "all of these functions";
                    btn2.Text = "to apply formatting changes to multiple worksheets at once";
                    btn3.Text = "to move or copy data between multiple worksheets at once";
                    btn4.Text = "to perform calculations across multiple worksheets at once";

                    correctAnswer = 1;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nWhat is the formula to calculate the sum of cells A1 through A5?\r\n";
                    btn1.Text = "=SUM(A1:A5)";
                    btn2.Text = "SUM(A1, A5)";
                    btn3.Text = "A1:A5";
                    btn4.Text = "A1+A5";

                    correctAnswer = 1;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\n\nWhich of the following is an absolute cell reference?\r\n";
                    btn1.Text = "A:2";
                    btn2.Text = "$A$2";
                    btn3.Text = "#A2";
                    btn4.Text = "A2";

                    correctAnswer = 2;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nWhat is an example of a relative cell reference?\r\n";
                    btn1.Text = "$A$1";
                    btn2.Text = "$A1";
                    btn3.Text = "A1";
                    btn4.Text = "A$1";

                    correctAnswer = 3;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nWhat value would Excel return for this formula? =(82-32)/5+8*2\r\n";
                    btn1.Text = "26";
                    btn2.Text = "7.69";
                    btn3.Text = "91.6";
                    btn4.Text = "36";

                    correctAnswer = 1;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nWhich option allows you to lock certain rows or columns in place while scrolling through a large worksheet?\r\n";
                    btn1.Text = "Split Panes";
                    btn2.Text = "Lock Panes";
                    btn3.Text = "View Options";
                    btn4.Text = "Freeze Panes";

                    correctAnswer = 4;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nWhat is the main advantage of selecting the Mark as Final option?\r\n";
                    btn1.Text = "It discourages other users from editing the workbook.";
                    btn2.Text = "It prevents other users from editing the workbook.";
                    btn3.Text = "It ensures that the workbook is free of errors.";
                    btn4.Text = "It prevents other users from viewing the workbook.";

                    correctAnswer = 1;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nWWhat is filtering in Excel?\r\n";
                    btn1.Text = "arranging data into categories";
                    btn2.Text = "removing blank cells from a worksheet";
                    btn3.Text = "viewing data based on certain criteria";
                    btn4.Text = "sorting data alphabetically";

                    correctAnswer = 3;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nWhich feature starts with a desired result, then calculates the input value that will give that result?\r\n";
                    btn1.Text = "Goal seek";
                    btn2.Text = "SmartArt";
                    btn3.Text = "Data validation";
                    btn4.Text = "Reverse formula";

                    correctAnswer = 1;
                    break;
                case 15:
                    lblQuestions.Text = "Question 15 of 20\r\n\nWhat is a workbook in Excel?\r\n";
                    btn1.Text = "a collection of files in a folder\r\n";
                    btn2.Text = "a type of chart";
                    btn3.Text = "a file that stores one or more worksheets";
                    btn4.Text = "a sheet of paper with printed data on it";

                    correctAnswer = 3;
                    break;
                case 16:
                    lblQuestions.Text = "Question 16 of 20\r\n\nHow can you select multiple cells at once in Excel?\r\n";
                    btn1.Text = "Hold down the Shift key while clicking the cells you want to select.";
                    btn2.Text = "Click and drag over the cells you want to select.";
                    btn3.Text = "all of these ways";
                    btn4.Text = "Hold down the Ctrl key while clicking the cells you want to select.";

                    correctAnswer = 3;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nHow do you resize a column or row in Excel?\r\n";
                    btn1.Text = "Click and drag the border of the column or row.";
                    btn2.Text = "Use the Format Cells dialog box.";
                    btn3.Text = "none of these ways";
                    btn4.Text = "Double-click the border of the column or row.";

                    correctAnswer = 1;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\n\nWhich chart type would be best for comparing values across categories?\r\n";
                    btn1.Text = "line chart";
                    btn2.Text = "column chart";
                    btn3.Text = "area chart";
                    btn4.Text = "scatter chart";

                    correctAnswer = 2;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\nWhat number format(s) can you use in Excel?\r\n";
                    btn1.Text = "percentage";
                    btn2.Text = "fraction";
                    btn3.Text = "decimal";
                    btn4.Text = "all of these formats";

                    correctAnswer = 4;
                    break;
                case 20:
                    lblQuestions.Text = "Question 20 of 20\r\n\nWhat is a PivotTable?\r\n";
                    btn1.Text = "a type of formula";
                    btn2.Text = "a type of chart";
                    btn3.Text = "a tool used to summarize data";
                    btn4.Text = "a way to create macros";


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
