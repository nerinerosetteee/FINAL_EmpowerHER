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
    public partial class PowerpointTipsQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public PowerpointTipsQuiz()
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

                    lblQuestions.Text = "Question 1 of 20\r\n\nWhat is the Quick Access Toolbar in PowerPoint?\r\n";
                    btn1.Text = "A contextual toolbar";
                    btn2.Text = "A toolbar that appears only in slideshow mode";
                    btn3.Text = "A fixed toolbar";
                    btn4.Text = "A customizable toolbar";

                    correctAnswer = 4;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\nHow can you temporarily hide a presentation in PowerPoint?\r\n";
                    btn1.Text = "Any of these actions will work.";
                    btn2.Text = "Click on the \"Slide Show\" tab and select \"Hide Slide.\"";
                    btn3.Text = "Press \"H\" on your keyboard.";
                    btn4.Text = "Right-click on a slide and select \"Hide Slide.\"";

                    correctAnswer = 1;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nHow can you open a PowerPoint file directly in slideshow mode?\r\n";
                    btn1.Text = "Right-click on the file and select \"Open in slideshow mode.\"";
                    btn2.Text = "Double-click the file while holding down the \"Ctrl\" key.";
                    btn3.Text = "Double-click the file while holding down the \"Shift\" key.";
                    btn4.Text = "Double-click the file while holding down the \"Alt\" key.";

                    correctAnswer = 1;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nHow can you jump to a specific slide in PowerPoint?\r\n";
                    btn1.Text = "Right-click on a slide and select \"Go to Slide.\" ";
                    btn2.Text = "Any of these actions will work.";
                    btn3.Text = "Press \"Ctrl\" + \"S\" and select the slide number.";
                    btn4.Text = "Type the slide number and press \"Enter.\"";

                    correctAnswer = 2;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nYHow can you keep objects aligned while moving them in PowerPoint?\r\n";
                    btn1.Text = "Any of these actions will work.";
                    btn2.Text = "Right-click on the objects and select \"Align.\"";
                    btn3.Text = "Click on \"View\" > \"Gridlines\" and snap the objects to the grid.";
                    btn4.Text = "Hold down the \"Shift\" key while dragging the objects.";

                    correctAnswer = 1;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 20\r\n\nHow can you match the color of an object to another object in PowerPoint?\r\n";
                    btn1.Text = "None of these actions will work.";
                    btn2.Text = "Right-click on the object and select \"Match Frame.\"";
                    btn3.Text = "Click on \"Format\" > \"Eyedropper\" and click on the object to match.";
                    btn4.Text = "Click on \"Design\" > \"Colors\" and select a color to match.";

                    correctAnswer = 3;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nWhat is the purpose of embedding fonts in a PowerPoint presentation?\r\n";
                    btn1.Text = "It's a way to ensure that fonts used in the presentation are included in the file, regardless of the device you're using.";
                    btn2.Text = "It's a way to add new font styles to PowerPoint.";
                    btn3.Text = "It's a way to edit the font settings for a slide.";
                    btn4.Text = "It's a way to store fonts outside of the presentation.";

                    correctAnswer = 1;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\n\nWhat is the keyboard shortcut to duplicate an animation?\r\n";
                    btn1.Text = "Ctrl + Alt + F9\r\n";
                    btn2.Text = "Ctrl + D";
                    btn3.Text = "Ctrl + A";
                    btn4.Text = "Ctrl + C";

                    correctAnswer = 2;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nHow can you play audio across your entire slideshow in PowerPoint?\r\n";
                    btn1.Text = "Use the \"Play across slides\" option in the audio settings.";
                    btn2.Text = "None of these actions will work.";
                    btn3.Text = "Add audio to each individual slide.";
                    btn4.Text = "Use the \"Loop until stopped\" option in the audio settings.";

                    correctAnswer = 1;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nWhat is the first rule for better PowerPoint presentations?\r\n";
                    btn1.Text = "Use readable text.";
                    btn2.Text = "Use random colors.";
                    btn3.Text = "Use flashy animations.";
                    btn4.Text = "Use complex charts.";

                    correctAnswer = 1;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nWhat is the second rule for better PowerPoint presentations?\r\n";
                    btn1.Text = "Use distracting backgrounds.";
                    btn2.Text = "Use high-quality images.";
                    btn3.Text = "Use long paragraphs.";
                    btn4.Text = "Use small fonts.";

                    correctAnswer = 2;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nWhat is one tip for creating an engaging PowerPoint presentation?\r\n";
                    btn1.Text = "Use bullet points and avoid lengthy text.";
                    btn2.Text = "Choose a font that is difficult to read.";
                    btn3.Text = "Use clip art for all visual aids.";
                    btn4.Text = "Use only one slide throughout the presentation.";

                    correctAnswer = 1;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nWhat is one tip for using images in a PowerPoint presentation?\r\n";
                    btn1.Text = "Use images that are unrelated to the topic.";
                    btn2.Text = "Use low-resolution images.";
                    btn3.Text = "Use charts as opposed to clip art.";
                    btn4.Text = "Use high-quality, relevant images.";

                    correctAnswer = 4;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nWhich of the following is a good way to add visual interest to a slide?\r\n";
                    btn1.Text = "Using a unique font for every slide";
                    btn2.Text = "Adding a variety of images and graphics";
                    btn3.Text = "Adding multiple transitions between slides";
                    btn4.Text = "Using a lot of bullet points";

                    correctAnswer = 2;
                    break;
                case 15:
                    lblQuestions.Text = "Question 15 of 20\r\n\nWhich of the following is a good way to create contrast on a slide?\r\n";
                    btn1.Text = "Using contrasting colors for text and objects";
                    btn2.Text = "Using the same font for all text";
                    btn3.Text = "Using only images and no text";
                    btn4.Text = "Using different shades of the same color for all objects";

                    correctAnswer = 1;
                    break;
                case 16:
                    lblQuestions.Text = "Question 16 of 20\r\n\nWhat is the purpose of the Format Painter in PowerPoint?\r\n";
                    btn1.Text = "To change the font color of a specific word or phrase";
                    btn2.Text = "Click and drag over the cells you want to select.";
                    btn3.Text = "To format text and images consistently throughout a presentatio";
                    btn4.Text = "To create new templates for use in future presentations";

                    correctAnswer = 3;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nIn order to apply the formatting of a single object to multiple objects using the Format Painter, first you should click on the object to be copied. Then you should...\r\n";
                    btn1.Text = "click the Format Painter button, and press Ctrl + V to paste the formatting.";
                    btn2.Text = "click the Format Painter button, and click on each object to apply the formatting.";
                    btn3.Text = "click the Format Painter button, and drag it over the objects to apply the formatting.";
                    btn4.Text = "click the Format Painter button, and press Ctrl + C to copy the formatting.";

                    correctAnswer = 3;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\n\nWhich of the following steps are recommended when compressing media files in PowerPoint?\r\n";
                    btn1.Text = "Make a backup copy of your presentation before compression.";
                    btn2.Text = "Share your presentation without compressing media files.";
                    btn3.Text = "Immediately close PowerPoint after compressing media files.";
                    btn4.Text = "Skip the compression process to maintain high-quality media.";

                    correctAnswer = 1;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\n To start spell check, press the____ key on your keyboard.\r\n";
                    btn1.Text = "F6";
                    btn2.Text = "F7";
                    btn3.Text = "F8";
                    btn4.Text = "F9";

                    correctAnswer = 2;
                    break;
                case 20:
                    lblQuestions.Text = "Question 20 of 20\r\n\nWhich key can you press during a PowerPoint presentation to temporarily hide the slide?\r\n";
                    btn1.Text = "W";
                    btn2.Text = "S";
                    btn3.Text = "P";
                    btn4.Text = "Q";


                    correctAnswer = 1;
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
