namespace final_project
{
    partial class Scores
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
            lblScores = new Label();
            label1 = new Label();
            label2 = new Label();
            lblLastScore = new Label();
            SuspendLayout();
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.Location = new Point(174, 64);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(0, 20);
            lblScores.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 20);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 21);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // lblLastScore
            // 
            lblLastScore.AutoSize = true;
            lblLastScore.Location = new Point(446, 56);
            lblLastScore.Name = "lblLastScore";
            lblLastScore.Size = new Size(0, 20);
            lblLastScore.TabIndex = 3;
            // 
            // Scores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 520);
            Controls.Add(lblLastScore);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblScores);
            Name = "Scores";
            Text = "Scores";
            Load += Scores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblScores;
        private Label label1;
        private Label label2;
        private Label lblLastScore;
    }
}