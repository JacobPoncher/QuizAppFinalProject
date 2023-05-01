namespace final_project
{
    partial class TakeQuiz
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
            rbtQuestion1 = new RadioButton();
            rbtQuestion2 = new RadioButton();
            rbtQuestion3 = new RadioButton();
            rbtquestion4 = new RadioButton();
            rbxQuestion = new RichTextBox();
            lblResult = new Label();
            btnNext = new Button();
            btnSubmit = new Button();
            btnFinish = new Button();
            rbtEasy = new RadioButton();
            rbtHard = new RadioButton();
            btnStart = new Button();
            gbxQuiz = new GroupBox();
            gpxChooseDifficulty = new GroupBox();
            gbxQuiz.SuspendLayout();
            gpxChooseDifficulty.SuspendLayout();
            SuspendLayout();
            // 
            // rbtQuestion1
            // 
            rbtQuestion1.AutoSize = true;
            rbtQuestion1.Location = new Point(71, 166);
            rbtQuestion1.Name = "rbtQuestion1";
            rbtQuestion1.Size = new Size(117, 24);
            rbtQuestion1.TabIndex = 0;
            rbtQuestion1.TabStop = true;
            rbtQuestion1.Text = "radioButton1";
            rbtQuestion1.UseVisualStyleBackColor = true;
            // 
            // rbtQuestion2
            // 
            rbtQuestion2.AutoSize = true;
            rbtQuestion2.Location = new Point(71, 196);
            rbtQuestion2.Name = "rbtQuestion2";
            rbtQuestion2.Size = new Size(117, 24);
            rbtQuestion2.TabIndex = 1;
            rbtQuestion2.TabStop = true;
            rbtQuestion2.Text = "radioButton2";
            rbtQuestion2.UseVisualStyleBackColor = true;
            // 
            // rbtQuestion3
            // 
            rbtQuestion3.AutoSize = true;
            rbtQuestion3.Location = new Point(71, 226);
            rbtQuestion3.Name = "rbtQuestion3";
            rbtQuestion3.Size = new Size(117, 24);
            rbtQuestion3.TabIndex = 2;
            rbtQuestion3.TabStop = true;
            rbtQuestion3.Text = "radioButton3";
            rbtQuestion3.UseVisualStyleBackColor = true;
            // 
            // rbtquestion4
            // 
            rbtquestion4.AutoSize = true;
            rbtquestion4.Location = new Point(71, 256);
            rbtquestion4.Name = "rbtquestion4";
            rbtquestion4.Size = new Size(117, 24);
            rbtquestion4.TabIndex = 3;
            rbtquestion4.TabStop = true;
            rbtquestion4.Text = "radioButton4";
            rbtquestion4.UseVisualStyleBackColor = true;
            // 
            // rbxQuestion
            // 
            rbxQuestion.Location = new Point(71, 38);
            rbxQuestion.Name = "rbxQuestion";
            rbxQuestion.Size = new Size(577, 79);
            rbxQuestion.TabIndex = 5;
            rbxQuestion.Text = "";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(106, 293);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 6;
            lblResult.Text = "label1";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(204, 339);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 7;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(71, 339);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnFinish
            // 
            btnFinish.Location = new Point(346, 339);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(94, 29);
            btnFinish.TabIndex = 9;
            btnFinish.Text = "finished";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Visible = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // rbtEasy
            // 
            rbtEasy.AutoSize = true;
            rbtEasy.Location = new Point(6, 26);
            rbtEasy.Name = "rbtEasy";
            rbtEasy.Size = new Size(59, 24);
            rbtEasy.TabIndex = 10;
            rbtEasy.TabStop = true;
            rbtEasy.Text = "easy";
            rbtEasy.UseVisualStyleBackColor = true;
            // 
            // rbtHard
            // 
            rbtHard.AutoSize = true;
            rbtHard.Location = new Point(213, 26);
            rbtHard.Name = "rbtHard";
            rbtHard.Size = new Size(60, 24);
            rbtHard.TabIndex = 11;
            rbtHard.TabStop = true;
            rbtHard.Text = "hard";
            rbtHard.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(515, 26);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 12;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // gbxQuiz
            // 
            gbxQuiz.Controls.Add(btnFinish);
            gbxQuiz.Controls.Add(btnNext);
            gbxQuiz.Controls.Add(btnSubmit);
            gbxQuiz.Controls.Add(lblResult);
            gbxQuiz.Controls.Add(rbxQuestion);
            gbxQuiz.Controls.Add(rbtquestion4);
            gbxQuiz.Controls.Add(rbtQuestion1);
            gbxQuiz.Controls.Add(rbtQuestion2);
            gbxQuiz.Controls.Add(rbtQuestion3);
            gbxQuiz.Location = new Point(68, 90);
            gbxQuiz.Name = "gbxQuiz";
            gbxQuiz.Size = new Size(729, 393);
            gbxQuiz.TabIndex = 13;
            gbxQuiz.TabStop = false;
            gbxQuiz.Text = "quiz";
            gbxQuiz.Visible = false;
            // 
            // gpxChooseDifficulty
            // 
            gpxChooseDifficulty.Controls.Add(rbtEasy);
            gpxChooseDifficulty.Controls.Add(btnStart);
            gpxChooseDifficulty.Controls.Add(rbtHard);
            gpxChooseDifficulty.Location = new Point(68, 12);
            gpxChooseDifficulty.Name = "gpxChooseDifficulty";
            gpxChooseDifficulty.Size = new Size(729, 72);
            gpxChooseDifficulty.TabIndex = 14;
            gpxChooseDifficulty.TabStop = false;
            gpxChooseDifficulty.Text = "choose difficulty ";
            // 
            // TakeQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 513);
            Controls.Add(gpxChooseDifficulty);
            Controls.Add(gbxQuiz);
            Name = "TakeQuiz";
            Text = "TakeQuiz";
            Load += TakeQuiz_Load;
            gbxQuiz.ResumeLayout(false);
            gbxQuiz.PerformLayout();
            gpxChooseDifficulty.ResumeLayout(false);
            gpxChooseDifficulty.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rbtQuestion1;
        private RadioButton rbtQuestion2;
        private RadioButton rbtQuestion3;
        private RadioButton rbtquestion4;
        private RichTextBox rbxQuestion;
        private Label lblResult;
        private Button btnNext;
        private Button btnSubmit;
        private Button btnFinish;
        private RadioButton rbtEasy;
        private RadioButton rbtHard;
        private Button btnStart;
        private GroupBox gbxQuiz;
        private GroupBox gpxChooseDifficulty;
    }
}