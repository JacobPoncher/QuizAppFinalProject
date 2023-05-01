namespace final_project
{
    partial class ChooseDifficulty
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
            btnStart = new Button();
            rbtEasy = new RadioButton();
            rbtHard = new RadioButton();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(52, 191);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // rbtEasy
            // 
            rbtEasy.AutoSize = true;
            rbtEasy.Location = new Point(52, 82);
            rbtEasy.Name = "rbtEasy";
            rbtEasy.Size = new Size(59, 24);
            rbtEasy.TabIndex = 1;
            rbtEasy.TabStop = true;
            rbtEasy.Text = "easy";
            rbtEasy.UseVisualStyleBackColor = true;
            // 
            // rbtHard
            // 
            rbtHard.AutoSize = true;
            rbtHard.Location = new Point(52, 112);
            rbtHard.Name = "rbtHard";
            rbtHard.Size = new Size(60, 24);
            rbtHard.TabIndex = 2;
            rbtHard.TabStop = true;
            rbtHard.Text = "hard";
            rbtHard.UseVisualStyleBackColor = true;
            // 
            // ChooseDifficulty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 319);
            Controls.Add(rbtHard);
            Controls.Add(rbtEasy);
            Controls.Add(btnStart);
            Name = "ChooseDifficulty";
            Text = "ChooseDifficulty";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private RadioButton rbtEasy;
        private RadioButton rbtHard;
    }
}