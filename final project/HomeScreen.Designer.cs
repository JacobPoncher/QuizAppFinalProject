namespace final_project
{
    partial class HomeScreen
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
            btnScores = new Button();
            btnRules = new Button();
            btnTakeQuiz = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnScores
            // 
            btnScores.Location = new Point(132, 88);
            btnScores.Name = "btnScores";
            btnScores.Size = new Size(94, 29);
            btnScores.TabIndex = 0;
            btnScores.Text = "scores";
            btnScores.UseVisualStyleBackColor = true;
            btnScores.Click += btnScores_Click;
            // 
            // btnRules
            // 
            btnRules.Location = new Point(132, 139);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(94, 29);
            btnRules.TabIndex = 1;
            btnRules.Text = "rules";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += btnRules_Click;
            // 
            // btnTakeQuiz
            // 
            btnTakeQuiz.Location = new Point(132, 193);
            btnTakeQuiz.Name = "btnTakeQuiz";
            btnTakeQuiz.Size = new Size(94, 29);
            btnTakeQuiz.TabIndex = 2;
            btnTakeQuiz.Text = "take quiz";
            btnTakeQuiz.UseVisualStyleBackColor = true;
            btnTakeQuiz.Click += btnTakeQuiz_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(84, 279);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnTakeQuiz);
            Controls.Add(btnRules);
            Controls.Add(btnScores);
            Name = "HomeScreen";
            Text = "HomeScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnScores;
        private Button btnRules;
        private Button btnTakeQuiz;
        private Label lblResult;
    }
}