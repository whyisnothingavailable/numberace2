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


        int answer;
        string Ans;
        int num1;
        int num2;
        int carCount;

        private void addGo(object sender, EventArgs e)
        {
            answer = num1 + num2;
            questionLabel.Text = num1.ToString() + " + " + num2.ToString() ;
        }
        private void subGo(object sender, EventArgs e)
        {
            answer = num1 - num2;
            questionLabel.Text = num1.ToString() + " - " + num2.ToString() ;
        }
        private void mulGo(object sender, EventArgs e)
        {
            answer = num1 * num2;
            questionLabel.Text = num1.ToString() + " x " + num2.ToString() ;
        }
        private void divGo(object sender, EventArgs e)
        {
            int multi = num1 * num2;
            answer = num1;
            questionLabel.Text = multi.ToString() + " ÷ " + num2.ToString();
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

            if (carCount >= 4000)
            {
                endGame(sender, e);
            }

            int x = -48;
            int y = 0;           

        }
        private void correct_Answer(object sender, EventArgs e) // method for correct answer
        {
            score = score + 100; // add 100 to score
            totalScore.Text = score.ToString(); // display (new) total score
            trackPicBox.Top = trackPicBox.Top + 200;
            //ding.Play();
            quizPanel.BackColor = Color.Green;
            carCount = (carCount +200);                       
            panel1.Top = panel1.Top - 10;

        }
        private void incorrect_Answer(object sender, EventArgs e)
        {
            score = score - 20; // minus 1 from score
            totalScore.Text = score.ToString(); //// display (new) total score
            //horn.Play();
            quizPanel.BackColor = Color.Red;
            panel3.Top = panel3.Top - 10;
            panel1.Top = panel1.Top - 10;

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
            countDownTimer.Stop();
            backButton.Enabled = false;
            retryButton.Enabled = true;
            homeButton.Enabled = true;
            if (panel1.Top > panel3.Top)
            {
                if (panel1.Top > panel2.Top)
                {
                    gameLbl.Text = "1ST";

                }
                if (panel1.Top < panel2.Top)
                {
                    gameLbl.Text = "2ND";
                }
            }
            if (panel1.Top > panel2.Top)
            {
                if (panel1.Top > panel3.Top)
                {
                    gameLbl.Text = "1ST";

                }
                if (panel1.Top > panel3.Top)
                {
                    gameLbl.Text = "2ND";
                }
            }
            if (panel1.Top < panel2.Top)
            {
                if (panel1.Top > panel3.Top)
                {
                    gameLbl.Text = "2ND";

                }
                if (panel1.Top < panel3.Top)
                {
                    gameLbl.Text = "3RD";
                }
            }
            if (panel1.Top < panel3.Top)
            {
                if (panel1.Top > panel2.Top)
                {
                    gameLbl.Text = "2ND";

                }
                if (panel1.Top < panel2.Top)
                {
                    gameLbl.Text = "3RD";
                }
            }
            int a = Int32.Parse(label1.Text);
            if (score > a)
            {
                label1.Text = score.ToString();
                Properties.Settings.Default.h_score = label1.Text;
                Properties.Settings.Default.Save();
            }

        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            seconds = 3;
            countDownTimer.Start();
            gamePanel.Visible = false;
            beginButton.Visible = false;
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
            gamePanel.Visible = true;
            retryButton.Enabled = false;
            homeButton.Enabled = false;

        }

        private void correctTimer_Tick(object sender, EventArgs e)
        {
            colourSeconds++;
            if (colourSeconds < 5)
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
                homePage back = new homePage(); // link to customPage
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
            }
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
            }
            if (seconds < -1)
            {
                trackPicBox.Top = trackPicBox.Top + 100;
                carCount = carCount + 20;
            }
        }

 
        private void retryButton_Click(object sender, EventArgs e)
        {
            gamePage_Load_1(sender, e);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide this form (gamepage)
                homePage back = new homePage(); // link to homepage
                back.Show(); // show homepage form
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
