namespace numberace
{
    partial class gamePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamePage));
            this.backPanel = new System.Windows.Forms.TableLayoutPanel();
            this.racePanel = new System.Windows.Forms.Panel();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.botCar1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botCar2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerCar = new System.Windows.Forms.PictureBox();
            this.totalScore = new System.Windows.Forms.Label();
            this.trackPicBox = new System.Windows.Forms.PictureBox();
            this.quizPanel = new System.Windows.Forms.TableLayoutPanel();
            this.optionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.optionButton4 = new System.Windows.Forms.Button();
            this.optionButton3 = new System.Windows.Forms.Button();
            this.optionButton2 = new System.Windows.Forms.Button();
            this.optionButton1 = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.correctTimer = new System.Windows.Forms.Timer(this.components);
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.gameLbl = new System.Windows.Forms.Label();
            this.rankingLbl = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.beginButton = new System.Windows.Forms.Button();
            this.awards = new System.Windows.Forms.PictureBox();
            this.backPanel.SuspendLayout();
            this.racePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botCar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botCar2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPicBox)).BeginInit();
            this.quizPanel.SuspendLayout();
            this.optionPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awards)).BeginInit();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backPanel.ColumnCount = 2;
            this.backPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.backPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.backPanel.Controls.Add(this.racePanel, 0, 0);
            this.backPanel.Controls.Add(this.quizPanel, 1, 0);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Margin = new System.Windows.Forms.Padding(0);
            this.backPanel.Name = "backPanel";
            this.backPanel.RowCount = 1;
            this.backPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.backPanel.Size = new System.Drawing.Size(1441, 938);
            this.backPanel.TabIndex = 0;
            // 
            // racePanel
            // 
            this.racePanel.Controls.Add(this.lbl_Value);
            this.racePanel.Controls.Add(this.lblHighscore);
            this.racePanel.Controls.Add(this.countdownLabel);
            this.racePanel.Controls.Add(this.backButton);
            this.racePanel.Controls.Add(this.panel3);
            this.racePanel.Controls.Add(this.panel2);
            this.racePanel.Controls.Add(this.panel1);
            this.racePanel.Controls.Add(this.totalScore);
            this.racePanel.Controls.Add(this.trackPicBox);
            this.racePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.racePanel.Location = new System.Drawing.Point(0, 0);
            this.racePanel.Margin = new System.Windows.Forms.Padding(0);
            this.racePanel.Name = "racePanel";
            this.racePanel.Size = new System.Drawing.Size(720, 938);
            this.racePanel.TabIndex = 0;
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Font = new System.Drawing.Font("Retro Gaming", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Value.Location = new System.Drawing.Point(421, 77);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(28, 27);
            this.lbl_Value.TabIndex = 6;
            this.lbl_Value.Text = "0";
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Font = new System.Drawing.Font("Retro Gaming", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.Location = new System.Drawing.Point(278, 77);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(152, 27);
            this.lblHighscore.TabIndex = 5;
            this.lblHighscore.Text = "Highscore:";
            // 
            // countdownLabel
            // 
            this.countdownLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.countdownLabel.Font = new System.Drawing.Font("Retro Gaming", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.Location = new System.Drawing.Point(294, 657);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(303, 244);
            this.countdownLabel.TabIndex = 0;
            this.countdownLabel.Text = "#";
            this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(24, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 67);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.botCar1);
            this.panel3.Location = new System.Drawing.Point(182, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 117);
            this.panel3.TabIndex = 4;
            // 
            // botCar1
            // 
            this.botCar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botCar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botCar1.Image = ((System.Drawing.Image)(resources.GetObject("botCar1.Image")));
            this.botCar1.Location = new System.Drawing.Point(0, 0);
            this.botCar1.Name = "botCar1";
            this.botCar1.Size = new System.Drawing.Size(69, 117);
            this.botCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botCar1.TabIndex = 2;
            this.botCar1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.botCar2);
            this.panel2.Location = new System.Drawing.Point(422, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 117);
            this.panel2.TabIndex = 4;
            // 
            // botCar2
            // 
            this.botCar2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botCar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botCar2.Image = ((System.Drawing.Image)(resources.GetObject("botCar2.Image")));
            this.botCar2.Location = new System.Drawing.Point(0, 0);
            this.botCar2.Name = "botCar2";
            this.botCar2.Size = new System.Drawing.Size(69, 117);
            this.botCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botCar2.TabIndex = 2;
            this.botCar2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.playerCar);
            this.panel1.Location = new System.Drawing.Point(302, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 117);
            this.panel1.TabIndex = 3;
            // 
            // playerCar
            // 
            this.playerCar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.playerCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerCar.Image = ((System.Drawing.Image)(resources.GetObject("playerCar.Image")));
            this.playerCar.Location = new System.Drawing.Point(0, 0);
            this.playerCar.Name = "playerCar";
            this.playerCar.Size = new System.Drawing.Size(69, 117);
            this.playerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCar.TabIndex = 2;
            this.playerCar.TabStop = false;
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.Font = new System.Drawing.Font("Retro Gaming", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScore.Location = new System.Drawing.Point(328, 36);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(155, 27);
            this.totalScore.TabIndex = 1;
            this.totalScore.Text = "totalScore";
            // 
            // trackPicBox
            // 
            this.trackPicBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackPicBox.Image = ((System.Drawing.Image)(resources.GetObject("trackPicBox.Image")));
            this.trackPicBox.Location = new System.Drawing.Point(-34, -5023);
            this.trackPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.trackPicBox.Name = "trackPicBox";
            this.trackPicBox.Size = new System.Drawing.Size(800, 6000);
            this.trackPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackPicBox.TabIndex = 0;
            this.trackPicBox.TabStop = false;
            // 
            // quizPanel
            // 
            this.quizPanel.BackColor = System.Drawing.SystemColors.Control;
            this.quizPanel.ColumnCount = 1;
            this.quizPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.quizPanel.Controls.Add(this.optionPanel, 0, 1);
            this.quizPanel.Controls.Add(this.questionLabel, 0, 0);
            this.quizPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizPanel.Location = new System.Drawing.Point(720, 0);
            this.quizPanel.Margin = new System.Windows.Forms.Padding(0);
            this.quizPanel.Name = "quizPanel";
            this.quizPanel.RowCount = 2;
            this.quizPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.42111F));
            this.quizPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.5789F));
            this.quizPanel.Size = new System.Drawing.Size(721, 938);
            this.quizPanel.TabIndex = 1;
            // 
            // optionPanel
            // 
            this.optionPanel.ColumnCount = 2;
            this.optionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionPanel.Controls.Add(this.optionButton4, 1, 1);
            this.optionPanel.Controls.Add(this.optionButton3, 0, 1);
            this.optionPanel.Controls.Add(this.optionButton2, 1, 0);
            this.optionPanel.Controls.Add(this.optionButton1, 0, 0);
            this.optionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionPanel.Location = new System.Drawing.Point(3, 203);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.RowCount = 2;
            this.optionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionPanel.Size = new System.Drawing.Size(715, 732);
            this.optionPanel.TabIndex = 0;
            // 
            // optionButton4
            // 
            this.optionButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionButton4.Font = new System.Drawing.Font("Retro Gaming", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton4.Location = new System.Drawing.Point(360, 369);
            this.optionButton4.Name = "optionButton4";
            this.optionButton4.Size = new System.Drawing.Size(352, 360);
            this.optionButton4.TabIndex = 3;
            this.optionButton4.Text = "optionButton4";
            this.optionButton4.UseVisualStyleBackColor = true;
            this.optionButton4.Click += new System.EventHandler(this.optionButton4_Click_1);
            // 
            // optionButton3
            // 
            this.optionButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionButton3.Font = new System.Drawing.Font("Retro Gaming", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton3.Location = new System.Drawing.Point(3, 369);
            this.optionButton3.Name = "optionButton3";
            this.optionButton3.Size = new System.Drawing.Size(351, 360);
            this.optionButton3.TabIndex = 2;
            this.optionButton3.Text = "optionButton3";
            this.optionButton3.UseVisualStyleBackColor = true;
            this.optionButton3.Click += new System.EventHandler(this.optionButton3_Click_1);
            // 
            // optionButton2
            // 
            this.optionButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionButton2.Font = new System.Drawing.Font("Retro Gaming", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton2.Location = new System.Drawing.Point(360, 3);
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.Size = new System.Drawing.Size(352, 360);
            this.optionButton2.TabIndex = 1;
            this.optionButton2.Text = "optionButton2";
            this.optionButton2.UseVisualStyleBackColor = true;
            this.optionButton2.Click += new System.EventHandler(this.optionButton2_Click_1);
            // 
            // optionButton1
            // 
            this.optionButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionButton1.Font = new System.Drawing.Font("Retro Gaming", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton1.Location = new System.Drawing.Point(3, 3);
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.Size = new System.Drawing.Size(351, 360);
            this.optionButton1.TabIndex = 0;
            this.optionButton1.Text = "optionButton1";
            this.optionButton1.UseVisualStyleBackColor = true;
            this.optionButton1.Click += new System.EventHandler(this.optionButton1_Click_1);
            // 
            // questionLabel
            // 
            this.questionLabel.AllowDrop = true;
            this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Retro Gaming", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.questionLabel.Location = new System.Drawing.Point(32, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(656, 200);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "questionLabel";
            // 
            // correctTimer
            // 
            this.correctTimer.Tick += new System.EventHandler(this.correctTimer_Tick);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 800;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // gameLbl
            // 
            this.gameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameLbl.AutoSize = true;
            this.gameLbl.Font = new System.Drawing.Font("Retro Gaming", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLbl.Location = new System.Drawing.Point(259, 20);
            this.gameLbl.Name = "gameLbl";
            this.gameLbl.Size = new System.Drawing.Size(83, 102);
            this.gameLbl.TabIndex = 0;
            this.gameLbl.Text = "-";
            this.gameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameLbl.Click += new System.EventHandler(this.gameLbl_Click);
            // 
            // rankingLbl
            // 
            this.rankingLbl.AutoSize = true;
            this.rankingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankingLbl.Location = new System.Drawing.Point(227, 189);
            this.rankingLbl.Name = "rankingLbl";
            this.rankingLbl.Size = new System.Drawing.Size(0, 63);
            this.rankingLbl.TabIndex = 1;
            // 
            // retryButton
            // 
            this.retryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retryButton.Font = new System.Drawing.Font("Retro Gaming", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryButton.Location = new System.Drawing.Point(58, 277);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(238, 65);
            this.retryButton.TabIndex = 3;
            this.retryButton.Text = "RETRY";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeButton.Font = new System.Drawing.Font("Retro Gaming", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(328, 277);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(223, 65);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamePanel.BackColor = System.Drawing.Color.White;
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Controls.Add(this.beginButton);
            this.gamePanel.Controls.Add(this.awards);
            this.gamePanel.Controls.Add(this.homeButton);
            this.gamePanel.Controls.Add(this.retryButton);
            this.gamePanel.Controls.Add(this.rankingLbl);
            this.gamePanel.Controls.Add(this.gameLbl);
            this.gamePanel.Location = new System.Drawing.Point(420, 273);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(601, 376);
            this.gamePanel.TabIndex = 38;
            // 
            // beginButton
            // 
            this.beginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beginButton.Font = new System.Drawing.Font("Retro Gaming", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.Location = new System.Drawing.Point(1, -1);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(599, 374);
            this.beginButton.TabIndex = 5;
            this.beginButton.Text = "BEGIN";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // awards
            // 
            this.awards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.awards.Location = new System.Drawing.Point(159, 125);
            this.awards.Name = "awards";
            this.awards.Size = new System.Drawing.Size(300, 100);
            this.awards.TabIndex = 6;
            this.awards.TabStop = false;
            this.awards.Click += new System.EventHandler(this.awards_Click);
            // 
            // gamePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1441, 938);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.backPanel);
            this.Name = "gamePage";
            this.Text = "gamePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.gamePage_Load_1);
            this.backPanel.ResumeLayout(false);
            this.racePanel.ResumeLayout(false);
            this.racePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botCar1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botCar2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPicBox)).EndInit();
            this.quizPanel.ResumeLayout(false);
            this.quizPanel.PerformLayout();
            this.optionPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel backPanel;
        private System.Windows.Forms.PictureBox trackPicBox;
        private System.Windows.Forms.Panel racePanel;
        private System.Windows.Forms.TableLayoutPanel quizPanel;
        private System.Windows.Forms.TableLayoutPanel optionPanel;
        private System.Windows.Forms.Button optionButton1;
        private System.Windows.Forms.PictureBox playerCar;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Button optionButton4;
        private System.Windows.Forms.Button optionButton3;
        private System.Windows.Forms.Button optionButton2;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox botCar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox botCar2;
        private System.Windows.Forms.Timer correctTimer;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Label gameLbl;
        private System.Windows.Forms.Label rankingLbl;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.PictureBox awards;
    }
}

