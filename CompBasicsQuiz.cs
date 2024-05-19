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
    public partial class CompBasicsQuiz : Form
    {
        int qTotal = 20;
        int correctAnswer;
        int qNumber = 1;
        int scoreNum;
        bool answered = false;
        public CompBasicsQuiz()
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
                    
                    lblQuestions.Text = "Question 1 of 20\r\n\nWhat is software?\r\n";
                    btn1.Text = "Any part of the computer that has a physical structure";
                    btn2.Text = "Instructions that tell the hardware what to do";
                    btn3.Text = "Flexible parts of a computer case";
                    btn4.Text = "Clothing designed to be worn by computer users";

                    correctAnswer = 2;
                    break;
                case 2:
                    lblQuestions.Text = "Question 2 of 20\r\n\nWhat is an app?\r\n";
                    btn1.Text = "A type of hardware you can install";
                    btn2.Text = "A keyboard that you can easily transport";
                    btn3.Text = "A type of software that allows you to perform specific tasks";
                    btn4.Text = "A type of touch-sensitive screen";

                    correctAnswer = 3;
                    break;
                case 3:
                    lblQuestions.Text = "Question 3 of 20\r\n\nWhat is the function of a surge protector?\r\n";
                    btn1.Text = "It increases the overall speed of your computer.";
                    btn2.Text = "It protects your computer from electrical surges.";
                    btn3.Text = "It connects your computer to the Internet.";
                    btn4.Text = "It provides temporary power if there is a power outage.";

                    correctAnswer = 2;
                    break;
                case 4:
                    lblQuestions.Text = "Question 4 of 20\r\n\nWhen something is “in the cloud,” this means it’s stored…\r\n";
                    btn1.Text = "On a web browser.";
                    btn2.Text = "On a hotspot.";
                    btn3.Text = "On your computer’s hard drive.";
                    btn4.Text = "Remotely, on Internet servers.";

                    correctAnswer = 4;
                    break;
                case 5:
                    lblQuestions.Text = "Question 5 of 20\r\n\nIf you spill liquid on your keyboard, shut down your computer, disconnect the keyboard, and…\r\n";
                    btn1.Text = "Turn the keyboard upside down.";
                    btn2.Text = "Call your Internet provider immediately.";
                    btn3.Text = "Toss it in the trash, since the damage is irreversible.";
                    btn4.Text = "Use a paper towel in between the keys.";

                    correctAnswer = 1;
                    break;
                case 6:
                    lblQuestions.Text = "Question 6 of 20\r\n\nErgonomic keyboards and chairs are designed to…\r\n";
                    btn1.Text = "Be more comfortable, in order to avoid injury.";
                    btn2.Text = "Be less comfortable, in order to increase productivity.";
                    btn3.Text = "More cheaply made.";
                    btn4.Text = "vibrate, in order to signal when you need to take a break.";

                    correctAnswer = 1;
                    break;
                case 7:
                    lblQuestions.Text = "Question 7 of 20\r\n\nThe computer’s main circuit board is called a ________.\r\n";
                    btn1.Text = "Monitor";
                    btn2.Text = "Hard drive";
                    btn3.Text = "Motherboard";
                    btn4.Text = "Bluetooth card";

                    correctAnswer = 3;
                    break;
                case 8:
                    lblQuestions.Text = "Question 8 of 20\r\nWhat is another name for a USB adapter?\r\n\r\n";
                    btn1.Text = "A dongle";
                    btn2.Text = "A GPU, or graphics processing unit";
                    btn3.Text = "A wireless network card";
                    btn4.Text = "A power supply unit";

                    correctAnswer = 1;
                    break;
                case 9:
                    lblQuestions.Text = "Question 9 of 20\r\n\nRAM is like a computer’s ________, while a hard drive is like a computer’s ________.\r\n";
                    btn1.Text = "long-term memory/short-term memory";
                    btn2.Text = "short-term memory/long-term memory";
                    btn3.Text = "brain/nervous system";
                    btn4.Text = "nervous system/brain";

                    correctAnswer = 2;
                    break;
                case 10:
                    lblQuestions.Text = "Question 10 of 20\r\n\nWhat is an Ethernet port used for?\r\n";
                    btn1.Text = "Connecting to the Internet";
                    btn2.Text = "Providing power to the computer";
                    btn3.Text = "Connecting smartphones and other peripherals";
                    btn4.Text = "Creating new user accounts";

                    correctAnswer = 1;
                    break;
                case 11:
                    lblQuestions.Text = "Question 11 of 20\r\n\nWhat is Wi-Fi?\r\n";
                    btn1.Text = "An extra-wide computer case used by servers";
                    btn2.Text = "A type of wireless network";
                    btn3.Text = "A type of sound card";
                    btn4.Text = "A type of software that scans for viruses";

                    correctAnswer = 2;
                    break;
                case 12:
                    lblQuestions.Text = "Question 12 of 20\r\n\nWindows, macOS, and Linux are examples of ________.\r\n";
                    btn1.Text = "Internet Service Providers";
                    btn2.Text = "Web Browsers";
                    btn3.Text = "Operating Systems";
                    btn4.Text = "Mobile Devices";

                    correctAnswer = 3;
                    break;
                case 13:
                    lblQuestions.Text = "Question 13 of 20\r\n\nWhat does \"GUI\" stand for?\r\n";
                    btn1.Text = "Good used iPhone";
                    btn2.Text = "Graphical user interface";
                    btn3.Text = "Gateway using Intel";
                    btn4.Text = "Global user index";

                    correctAnswer = 2;
                    break;
                case 14:
                    lblQuestions.Text = "Question 14 of 20\r\n\nFitness trackers and smartwatches are examples of…\r\n";
                    btn1.Text = "TVs";
                    btn2.Text = "Game consoles";
                    btn3.Text = "Smartphones";
                    btn4.Text = "Wearables";

                    correctAnswer = 4;
                    break;
                case 15:
                    lblQuestions.Text = "Question 15 of 20\r\n\nWhich operating system is MOST typically found on PC computers?\r\n";
                    btn1.Text = "macOS";
                    btn2.Text = "iOS";
                    btn3.Text = "Windows";
                    btn4.Text = "Linux";

                    correctAnswer = 3;
                    break;
                case 16:
                    lblQuestions.Text = "Question 16 of 20\r\n\nWhat is the main function of a computer case?\r\n";
                    btn1.Text = "To control the pointer by making a drawing motion";
                    btn2.Text = "To contain the main components of the computer";
                    btn3.Text = "To display text and images on the screen";
                    btn4.Text = "To allow you to point to objects on the screen";

                    correctAnswer = 2;
                    break;
                case 17:
                    lblQuestions.Text = "Question 17 of 20\r\n\nNewer monitors usually have LCD or LED displays, also known as _________ displays.\r\n";
                    btn1.Text = "Video Card";
                    btn2.Text = "Control-Button";
                    btn3.Text = "Flat-Panel";
                    btn4.Text = "Cathode Ray Tube (or CRT)";

                    correctAnswer = 3;
                    break;
                case 18:
                    lblQuestions.Text = "Question 18 of 20\r\nWhat is the purpose of a scanner?\r\n";
                    btn1.Text = "To record sound";
                    btn2.Text = "To control computer games using some of the hardware";
                    btn3.Text = "To print documents";
                    btn4.Text = "To copy physical images/documents and save them as digital images";

                    correctAnswer = 4;
                    break;
                case 19:
                    lblQuestions.Text = "Question 19 of 20\r\n\nIf your computer is sluggish when you have several programs open, this could be a sign that…\r\n";
                    btn1.Text = "To control the computer’s Internet connection";
                    btn2.Text = "To carry out commands";
                    btn3.Text = "To control the computer’s power supply";
                    btn4.Text = "To send information to the printer or scanner";

                    correctAnswer = 2;
                    break;
                case 20:
                    lblQuestions.Text = "Question 20 of 20\r\n\nIf your computer is sluggish when you have several programs open, this could be a sign that…\r\n\r\n";
                    btn1.Text = "The hard drive can only store software, but not other documents and files.";
                    btn2.Text = "Static electricity is building up.";
                    btn3.Text = "It doesn’t have a network card.";
                    btn4.Text = "It doesn’t have enough RAM.";

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
