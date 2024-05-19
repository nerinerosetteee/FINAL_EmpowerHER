using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOOP_EmpowerHER
{
    public partial class PowerpointQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public PowerpointQuiz()
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

                    lblQuestions.Text = "Question 1 of 20\r\n\nThe New Slide command on the Ribbon lets you choose ________.\r\n";
                    btn1.Text = "slide dimensions";
                    btn2.Text = "slide layouts";
                    btn3.Text = "transitions";
                    btn4.Text = "print settings";

                    correctAnswer = 2;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\nMost slide layouts include at least one ________ by default.\r\n";
                    btn1.Text = "animation";
                    btn2.Text = "transition";
                    btn3.Text = "action button";
                    btn4.Text = "placeholder";

                    correctAnswer = 4;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nWhat is a background style in PowerPoint?\r\n";
                    btn1.Text = "a type of font";
                    btn2.Text = "a type of animatione";
                    btn3.Text = "a predefined set of colors and effects applied to a slide background";
                    btn4.Text = "a type of slide transition";

                    correctAnswer = 3;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nSuppose you're sharing a presentation with several coworkers, but you're not sure if they all have PowerPoint. What's the best way to ensure everyone will still be able to view your presentation?\r\n";
                    btn1.Text = "Describe each slide over the phone";
                    btn2.Text = "Export as a PDF";
                    btn3.Text = "Print handouts and mail them";
                    btn4.Text = "Save as a Rich Text File";

                    correctAnswer = 2;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nWhat is the Slide Sorter view in PowerPoint?\r\n";
                    btn1.Text = "a view that displays a single slide at a time";
                    btn2.Text = "a view that displays the outline of a presentation";
                    btn3.Text = "a view that displays all the slides in a presentation in a grid format";
                    btn4.Text = "a view that displays the speaker notes for a slide";

                    correctAnswer = 3;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 20\r\n\nHow can you access the \"Find\" feature in PowerPoint?\r\n";
                    btn1.Text = "Press \"Ctrl + F.\"";
                    btn2.Text = "Right-click on a slide and select \"Find.\"";
                    btn3.Text = "Click on the \"Find\" button in the \"Editing\" section of the Ribbon.";
                    btn4.Text = "Type \"Find\" in the menu's search bar.";

                    correctAnswer = 1;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nWhat is the difference between \"Portrait\" and \"Landscape\" mode?\r\n";
                    btn1.Text = "Portrait mode prints the slide vertically, while landscape mode prints the slide horizontally.";
                    btn2.Text = "Landscape mode prints the slide in grayscale, while portrait mode prints the slide in color.";
                    btn3.Text = "Portrait mode prints the slide in grayscale, while landscape mode prints the slide in color.";
                    btn4.Text = "Landscape mode prints the slide vertically, while portrait mode prints the slide horizontally.";

                    correctAnswer = 1;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\n\nWhat is a motion path?\r\n";
                    btn1.Text = "An animation that moves an object along a path";
                    btn2.Text = "A feature that controls the timing of an animation";
                    btn3.Text = "A timeline that lets you reorder animations";
                    btn4.Text = "A feature that lets you trim a video";

                    correctAnswer = 1;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nHow do you end a slide show in PowerPoint?\r\n";
                    btn1.Text = "Click the \"View\" tab on the ribbon, and then click \"End Slide Show.\"";
                    btn2.Text = "Click the \"Slide Show\" tab on the ribbon, and then click \"End Slide Show.\"";
                    btn3.Text = "Press the \"ESC\" key on your keyboard.";
                    btn4.Text = "any of these will work";

                    correctAnswer = 4;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nWhat types of image files can you insert into a PowerPoint presentation?\r\n";
                    btn1.Text = "GIF";
                    btn2.Text = "all of these types of image files";
                    btn3.Text = "PNG";
                    btn4.Text = "JPEG";

                    correctAnswer = 2;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nIf you add background music and want it to continue playing for the entire presentation, which feature should you use?\r\n";
                    btn1.Text = "Slide Master view";
                    btn2.Text = "Trim audio.";
                    btn3.Text = "Play across slides";
                    btn4.Text = "Rewind after playing";

                    correctAnswer = 3;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nLet's say you want to add a company logo to the bottom-right corner of every slide. What's the most efficient way to do this?\r\n";
                    btn1.Text = "Insert the logo once, copy it, then paste it to the other slides";
                    btn2.Text = "Use the pen tool to draw the logo";
                    btn3.Text = "Copy the picture, select all of the slides in the Navigation Pane, right-click, and choose Paste";
                    btn4.Text = "Insert the logo on the Slide Master";

                    correctAnswer = 4;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nWhat is the purpose of the \"Rotate\" tool for shapes?\r\n";
                    btn1.Text = "to change the shape's fill color";
                    btn2.Text = "to erase the shape";
                    btn3.Text = "to resize the shape proportionally";
                    btn4.Text = "to change the angle of the shape";

                    correctAnswer = 4;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nIn order to start a slideshow from the beginning, you can press \"Shift + ____.\"\r\n";
                    btn1.Text = "F8";
                    btn2.Text = "F5";
                    btn3.Text = "F7";
                    btn4.Text = "F6";

                    correctAnswer = 2;
                    break;
                case 15:
                    lblQuestions.Text = "Question 15 of 20\r\n\nWhat is the default file extension for PowerPoint presentations?\r\n";
                    btn1.Text = ".pdf";
                    btn2.Text = ".docx";
                    btn3.Text = ".pptx";
                    btn4.Text = ".xlsx";

                    correctAnswer = 3;
                    break;
                case 16:
                    lblQuestions.Text = "Question 16 of 20\r\n\nWhat can you do with the \"Save As\" function in PowerPoint?\r\n";
                    btn1.Text = "create a copy of the current presentation";
                    btn2.Text = "all of these things";
                    btn3.Text = "save the current presentation with a different name";
                    btn4.Text = "save the current presentation in a different file format";

                    correctAnswer = 2;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nHow can you compress the images in a presentation to reduce file size?\r\n\r\n";
                    btn1.Text = "Click on \"Compress Pictures\" in the ribbon.";
                    btn2.Text = "You cannot compress the images.";
                    btn3.Text = "Press \"Ctrl + C.\"";
                    btn4.Text = "Right-click and select \"Compress Pictures.\"";

                    correctAnswer = 1;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\n\nWhat is a slide in PowerPoint?\r\n";
                    btn1.Text = "a type of animation";
                    btn2.Text = "a type of font";
                    btn3.Text = "a transition between slides";
                    btn4.Text = "a single page of a presentation";

                    correctAnswer = 4;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\nWhat is a placeholder in PowerPoint?\r\n";
                    btn1.Text = "a type of transition";
                    btn2.Text = "a type of font";
                    btn3.Text = "a type of animation";
                    btn4.Text = "a box on a slide that holds text or objects";

                    correctAnswer = 4;
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
