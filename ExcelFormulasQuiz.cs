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
    public partial class ExcelFormulasQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public ExcelFormulasQuiz()
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

                    lblQuestions.Text = "Question 1 of 20\r\n\nA group of cells is called a ________.\r\n";
                    btn1.Text = "chart";
                    btn2.Text = "cell cluster";
                    btn3.Text = "cell range";
                    btn4.Text = "multicell";

                    correctAnswer = 3;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\nWhat is the formula to add up a column of numbers in Excel?\r\n";
                    btn1.Text = "=TOTAL(A1:A10)";
                    btn2.Text = "=SUM(A1:A10)";
                    btn3.Text = "=COLUMN(A1:A10)";
                    btn4.Text = "=ADD(A1:A10)";

                    correctAnswer = 2;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nWhat is the default type of cell reference in Excel?\r\n";
                    btn1.Text = "Constant";
                    btn2.Text = "Absolute";
                    btn3.Text = "Mixed";
                    btn4.Text = "Relative";

                    correctAnswer = 4;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nWhich of the following is an absolute cell reference?\r\n";
                    btn1.Text = "$B$2";
                    btn2.Text = "B2";
                    btn3.Text = "B$2$";
                    btn4.Text = "$B2$";

                    correctAnswer = 1;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nWhich of the formulas below are valid?\r\n";
                    btn1.Text = "=J5+C21/D21";
                    btn2.Text = "C8+C7";
                    btn3.Text = "=A+B+C";
                    btn4.Text = "=M2+M3";

                    correctAnswer = 1;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 20\r\n\nIn the order of operations, which of the following comes first?\r\n";
                    btn1.Text = "Operations enclosed in parentheses";
                    btn2.Text = "Operations involving large numbers";
                    btn3.Text = "Exponential calculations";
                    btn4.Text = "Multiplication";

                    correctAnswer = 1;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nWhat is a number format in Excel?\r\n";
                    btn1.Text = "A feature that automatically adds numbers in Excel";
                    btn2.Text = "A format that tells Excel how to display data in a cell";
                    btn3.Text = "A function that rounds numbers up or down in Excel";
                    btn4.Text = "A formula that performs mathematical calculations in Excel";

                    correctAnswer = 2;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\n\nWhat is a \"Custom\" number format in Excel?\r\n";
                    btn1.Text = "A number format that is automatically applied to every cell in a worksheet";
                    btn2.Text = "A number format that you create to fit your specific needs";
                    btn3.Text = "A number format that rounds numbers up or down\r\n";
                    btn4.Text = "A number format that only displays negative numbers";

                    correctAnswer = 2;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nWhat does the \"General\" number format do in Excel?\r\n";
                    btn1.Text = "It displays numbers with no decimal places";
                    btn2.Text = "It displays numbers as text.";
                    btn3.Text = "It displays numbers as dates.";
                    btn4.Text = "It applies the default number format to a cell.";

                    correctAnswer = 4;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nWhat formula would you use to find the average of the values in cell range A1 to A10?\r\n";
                    btn1.Text = "=MEAN(A1:A10)";
                    btn2.Text = "=AVG(A1:A10)";
                    btn3.Text = "=TOTAL/A10";
                    btn4.Text = "=AVERAGE(A1:A10)";

                    correctAnswer = 4;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nIf you want to restart page numbering partway through your document, what do you need to do first?\r\n";
                    btn1.Text = "-";
                    btn2.Text = "x";
                    btn3.Text = "*";
                    btn4.Text = "+";

                    correctAnswer = 3;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nWhat does the \"Evaluate Formula\" tool in Excel do?\r\n";
                    btn1.Text = "It highlights any errors in the formula.\r\n";
                    btn2.Text = "It checks the formula for spelling errors.";
                    btn3.Text = "It shows the formula and its results step-by-step.";
                    btn4.Text = "It checks the formula for circular references.";

                    correctAnswer = 3;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nWhich function would you use to add several numeric values?\r\n";
                    btn1.Text = "TOTAL";
                    btn2.Text = "AVERAGE";
                    btn3.Text = "SUM";
                    btn4.Text = "COUNTA";

                    correctAnswer = 3;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nSuppose you want to copy a formula while keeping one of the cell references locked on the same cell. Which of the following would you use?\r\n";
                    btn1.Text = "PivotTable";
                    btn2.Text = "ReferenceLock";
                    btn3.Text = "Relative reference";
                    btn4.Text = "Absolute reference";

                    correctAnswer = 4;
                    break;
                case 15:
                    lblQuestions.Text = "Question 16 of 20\r\n\nWhich function can find the highest value in a cell range?\r\n";
                    btn1.Text = "TOP";
                    btn2.Text = "MAXVALUE";
                    btn3.Text = "HIGHEST";
                    btn4.Text = "MAX";

                    correctAnswer = 4;
                    break;
                case 16:
                    lblQuestions.Text = "Question 16 of 20\r\n\nWhat does the formula =A1&\" \"&A2 do in Excel?\r\n";
                    btn1.Text = "Adds the value in A2 to the value in A1";
                    btn2.Text = "Multiplies the values in cells A1 and A2";
                    btn3.Text = "Subtracts the value in A2 from the value in A1";
                    btn4.Text = "Combines the values in cells A1 and A2 into a single cell with a space between them";

                    correctAnswer = 4;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nWhich function can display a different value depending on a condition?\r\n";
                    btn1.Text = "CONDITION";
                    btn2.Text = "AVERAGE";
                    btn3.Text = "TEST";
                    btn4.Text = "IF";

                    correctAnswer = 4;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\n\nWhat is the purpose of the parentheses in a formula like =(A1+A2)*B1 in Excel?\r\n";
                    btn1.Text = "They tell Excel to ignore the values in cells A1 and A2.";
                    btn2.Text = "They indicate the order in which operations should be performed.";
                    btn3.Text = "They are not necessary and can be omitted.";
                    btn4.Text = "They make the formula easier to read.";

                    correctAnswer = 2;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\nWhich of the following VLOOKUP functions is using the correct arguments?\r\n";
                    btn1.Text = "=VLOOKUP(G5, 3, FALSE)";
                    btn2.Text = "=VLOOKUP(Products!$A$2:$C$20, G5, 3, FALSE)";
                    btn3.Text = "=VLOOKUP(G5=3, TRUE, FALSE)";
                    btn4.Text = "=VLOOKUP(G5, Products!$A$2:$C$20, 3, FALSE)";

                    correctAnswer = 4;
                    break;
                case 20:
                    lblQuestions.Text = "Question 20 of 20\r\n\nWhat symbol do you use for division in Excel?\r\n";
                    btn1.Text = "-";
                    btn2.Text = "\\";
                    btn3.Text = "/";
                    btn4.Text = "+";


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
