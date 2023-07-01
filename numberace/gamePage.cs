using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberace
{
    public partial class gamePage : Form
    {
        public gamePage()
        {
            InitializeComponent();
        }

        int seconds;  //create an int(numbers) variable named seconds
        int colourSeconds=0;
        bool op1; // create a bool(true or false) variable named op1
        bool op2; // create a bool variable named op2
        bool op3; // create a bool variable named op3
        bool op4; // create a bool variable named op4
        int score; // create an int variable names score
        SoundPlayer ding = new SoundPlayer(@"C:\Users\jinny\Downloads\ding-1-14705.wav");
        SoundPlayer horn = new SoundPlayer(@"C:\Users\jinny\Downloads\truck-signal-153263.wav.wav");
        SoundPlayer gameMusic = new SoundPlayer(@"C:\Users\jinny\Downloads\RPReplay-Final1687929196.wav");


        int highscore = 0;
        int answer;
        string Ans;
        int quesRan;
        int num1;
        int num2;
        int correctCount;

        private void addGo(object sender, EventArgs e)
        {
            answer = num1 + num2;
            questionLabel.Text = num1.ToString() + " + " + num2.ToString() + " = ";
        }
        private void subGo(object sender, EventArgs e)
        {
            answer = num1 - num2;
            questionLabel.Text = num1.ToString() + " - " + num2.ToString() + " = ";
        }
        private void mulGo(object sender, EventArgs e)
        {
            answer = num1 * num2;
            questionLabel.Text = num1.ToString() + " x " + num2.ToString() + " = ";
        }
        private void divGo(object sender, EventArgs e)
        {
            int multi = num1 * num2;
            answer = num1;
            questionLabel.Text = multi.ToString() + " ÷ " + num2.ToString() + " = ";
        }
        private void generate_Question(object sender, EventArgs e)
        {

            // basically resetting everything
            op1 = false; // set op1 as false
            op2 = false; // set op2 as false
            op3 = false; // set op3 as false
            op4 = false; // set op4 as false


            Random rnd = new Random(); // create a new Random variable called rnd
            num1 = rnd.Next(0, 3); // generate random int x
            num2 = rnd.Next(0, 3); // generate random int y
            int optionRan = rnd.Next(1, 5); // 

            addGo(sender, e);

            Ans = answer.ToString();

            if (optionRan == 1) // if random option int is 1
            {
                optionButton1.Text = Ans; // text on optionButton1 = string answer
                optionButton2.Text = (answer - 1).ToString(); // text on optionbutton2 = int answer - 1 (string format)
                optionButton3.Text = (answer + 2).ToString(); // text on optionbutton3 = int answer + 2 (string format)
                optionButton4.Text = (answer + 1).ToString(); // text on optionbutton4 = int answer + 1 (string format)
                op1 = true; // set op1 as true because optionButton1 has the correct answer
            }
            else if (optionRan == 2)
            {
                optionButton1.Text = (answer - 1).ToString();
                optionButton2.Text = Ans; // text on optionButton1 = string answer
                optionButton3.Text = (answer + 1).ToString();
                optionButton4.Text = (answer + 2).ToString();
                op2 = true; // set op2 as true because optionButton3 has the correct answer
            }
            else if (optionRan == 3)
            {
                optionButton1.Text = (answer + 1).ToString();
                optionButton2.Text = (answer - 1).ToString();
                optionButton3.Text = Ans; // text on optionButton1 = string answer
                optionButton4.Text = (answer - 2).ToString();
                op3 = true; // set op3 as true because optionButton3 has the correct answer
            }
            else if (optionRan == 4)
            {
                optionButton1.Text = (answer - 1).ToString();
                optionButton2.Text = (answer + 2).ToString();
                optionButton3.Text = (answer + 1).ToString();
                optionButton4.Text = Ans;
                op4 = true; // set op3 as true because optionButton3 has the correct answer
            }

            if (correctCount > 8)
            {
                playerCar.Location = new Point(200, 700);
                correctCount = 0;
            }

            int x = -48;
            int y = 0;

            if (additionCheck.Checked == true)
            {
                if (subtractionCheck.Checked == true)
                {
                    if (multipCheck.Checked == true)
                    {
                        if (diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 5); // generate random option int (1 
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 3)
                            {
                                mulGo(sender, e);
                            }
                            if (quesRan == 4)
                            {
                                divGo(sender, e);
                            }
                        }
                        if (diviCheck.Checked == false)
                        {
                            quesRan = rnd.Next(1, 4); // generate random option int (1 
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 3)
                            {
                                mulGo(sender, e);
                            }
                        }
                    }
                    if (multipCheck.Checked == false)
                    {
                        if (diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 4);
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 3)
                            {
                                divGo(sender, e);
                            }
                        }
                        if (diviCheck.Checked == false)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                subGo(sender, e);
                            }
                        }
                    }
                }
                if (subtractionCheck.Checked == false)
                {
                    if (multipCheck.Checked == true)
                    {
                        if (diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 4);
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                mulGo(sender, e);
                            }
                            if (quesRan == 3)
                            {
                                divGo(sender, e);
                            }

                        }
                        if (diviCheck.Checked == false)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                mulGo(sender, e);
                            }
                        }
                    }
                    if (multipCheck.Checked == false)
                    {
                        if (diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                addGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                divGo(sender, e);
                            }
                        }
                        if (diviCheck.Checked == false)
                        {
                            addGo(sender, e);
                        }
                    }
                }
            } // if addition is checked

            if (additionCheck.Checked == false)
            {
                if (subtractionCheck.Checked == true)
                {
                    if (multipCheck.Checked == true)
                    {
                        if (diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 4);
                            if (quesRan == 1)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                mulGo(sender, e);
                            }
                            if (quesRan == 3)
                            {
                                divGo(sender, e);
                            }
                        }
                        if (diviCheck.Checked == false)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                mulGo(sender, e);
                            }
                        }
                    }
                    if (multipCheck.Checked == false)
                    {
                        if (diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                subGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                divGo(sender, e);
                            }
                        }
                        if (diviCheck.Checked == false)
                        {
                            subGo(sender, e);
                        }
                    }
                }
                if (subtractionCheck.Checked == false)
                {
                    if (multipCheck.Checked == true)
                    {
                        if (diviCheck.Checked == true)
                        {
                            quesRan = rnd.Next(1, 3);
                            if (quesRan == 1)
                            {
                                mulGo(sender, e);
                            }
                            if (quesRan == 2)
                            {
                                divGo(sender, e);
                            }

                        }
                        if (diviCheck.Checked == false)
                        {
                            mulGo(sender, e);
                        }

                    }
                    if (multipCheck.Checked == false)
                    {
                        if (diviCheck.Checked == true)
                        {
                            divGo(sender, e);
                        }
                        if (diviCheck.Checked == false)
                        {
                            questionLabel.Text = "You didn't pick anything!!";
                        }
                    }
                }
            } // if addition is not checked

        }
        private void correct_Answer(object sender, EventArgs e) // method for correct answer
        {
            score = score + 10; // add 1 to score
            totalScore.Text = score.ToString(); // display (new) total score
            trackPicBox.Top = trackPicBox.Top + 200;
            //ding.Play();
            quizPanel.BackColor = Color.Green;
            correctCount++;
                       bot1_Race(sender, e);
                       bot2_Race(sender, e);

        }
        private void incorrect_Answer(object sender, EventArgs e)
        {
            score = score - 5; // minus 1 from score
            totalScore.Text = score.ToString(); //// display (new) total score
            //horn.Play();
            quizPanel.BackColor = Color.Red;
                       bot1_Race(sender, e);
                       bot2_Race(sender, e);
        }

                private void bot1_Race(object sender, EventArgs e)
                {
                    Random rnd = new Random(); // 
                    int botRan = rnd.Next(0, 2); // 
                    if (botRan == 0)
                    { }
                    if (botRan == 1)
                    {
                        botCar1.Top = botCar1.Top - 80; // move car up
                    }
                }
               private void bot2_Race(object sender, EventArgs e)
                {
                    Random rnd = new Random(); // 
                    int botRan = rnd.Next(0, 2); // 
                    if (botRan == 0)
                    { }
                    if (botRan == 1)
                    {
                        botCar2.Top = botCar2.Top - 80; // move car up
                    }
                }

        private void endGame(object sender, EventArgs e)
        {
            
            questionLabel.Text = ""; // empty the question
            optionButton1.Enabled = false;
            optionButton2.Enabled = false;
            optionButton3.Enabled = false;
            optionButton4.Enabled = false;
            optionButton1.Text = ""; // and this option button
            optionButton2.Text = ""; // and this one
            optionButton3.Text = ""; // and this one
            optionButton4.Text = ""; // and this one
            totalScore.Text = score.ToString(); // write in the totalScore label: "Total Score = (insert score)"
            gamePanel.Visible = true;

        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            seconds = 3;
            countDownTimer.Start();
        }

        private void optionButton1_Click_1(object sender, EventArgs e)
        {
            if (op1 == true) // if optionbutton3 is the one with the correct answer
            {
                generate_Question(sender, e);
                correct_Answer(sender, e);
            }
            else
            {
                incorrect_Answer(sender, e);
            }
        }

        private void optionButton2_Click_1(object sender, EventArgs e)
        {
            if (op2 == true) // if optionbutton3 is the one with the correct answer
            {
                generate_Question(sender, e);
                correct_Answer(sender, e);
            }
            else
            {
                incorrect_Answer(sender, e);
            }
        }

        private void optionButton3_Click_1(object sender, EventArgs e)
        {
            if (op3 == true) // if optionbutton3 is the one with the correct answer
            {
                generate_Question(sender, e);
                correct_Answer(sender, e);
            }
            else
            {
                incorrect_Answer(sender, e);
            }
        }

        private void optionButton4_Click_1(object sender, EventArgs e)
        {
            if (op4 == true) // if optionbutton3 is the one with the correct answer
            {
                generate_Question(sender, e);
                correct_Answer(sender, e);
            }
            else
            {
                incorrect_Answer(sender, e);
            }
        }      

        private void gamePage_Load_1(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            optionButton1.Enabled = false;
            optionButton2.Enabled = false;
            optionButton3.Enabled = false;
            optionButton4.Enabled = false;
            questionLabel.Text = ""; // empty the question
            optionButton1.Text = ""; // and this option button
            optionButton2.Text = ""; // and this one
            optionButton3.Text = ""; // and this one
            optionButton4.Text = ""; // and this one
            gamePanel.Visible = false;
        }

        private void correctTimer_Tick(object sender, EventArgs e)
        {
            colourSeconds++;
            while (colourSeconds < 5)
            {
                quizPanel.BackColor = Color.Green;
            }
            if (colourSeconds > 5)
            {

            }
        }

        private void backButton_Click(object sender, EventArgs e) // go back button
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo); // the message box
            if (dialogResult == DialogResult.Yes) // if the yes button is chosen
            {
                this.Hide(); // hide this form (gamepage)
                customPage back = new customPage(); // link to customPage
                back.Show(); // show customPage form
            }
            else if (dialogResult == DialogResult.No) // if the no button is chosen
            {

            }
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {

            countdownLabel.Text = seconds--.ToString();

            if (seconds < 0)
            {
                countdownLabel.Text = "Go!";
                
                if (seconds == -2)
                {
                    trackPicBox.Top = trackPicBox.Top + 300;
                    countdownLabel.Visible = false;
                    generate_Question(sender, e);
                    score = 0;
                    playerCar.Location = new Point(310, 400);
                    botCar1.Location = new Point(195, 400);
                    botCar2.Location = new Point(425, 400);
                    optionButton1.Enabled = true;
                    optionButton2.Enabled = true;
                    optionButton3.Enabled = true;
                    optionButton4.Enabled = true;
                    correctCount = 0;
                }
               
            }
            if (seconds < -1)
            {
                trackPicBox.Top = trackPicBox.Top + 10;
            }
        }

        private void trackPicBox_Click(object sender, EventArgs e)
        {

        }

        private void gamePage_Shown(object sender, EventArgs e)
        {
        }
    }
}
