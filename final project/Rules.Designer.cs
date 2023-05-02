namespace final_project
{
    partial class lnkRules
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
            rbxShowRules = new RichTextBox();
            btnRules = new Button();
            btnPolicy = new Button();
            btnPenaltyGuide = new Button();
            SuspendLayout();
            // 
            // rbxShowRules
            // 
            rbxShowRules.Location = new Point(4, 75);
            rbxShowRules.Name = "rbxShowRules";
            rbxShowRules.Size = new Size(795, 372);
            rbxShowRules.TabIndex = 2;
            rbxShowRules.Text = "";
            // 
            // btnRules
            // 
            btnRules.Location = new Point(26, 19);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(94, 29);
            btnRules.TabIndex = 3;
            btnRules.Text = "rules";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += btnRules_Click;
            // 
            // btnPolicy
            // 
            btnPolicy.Location = new Point(244, 19);
            btnPolicy.Name = "btnPolicy";
            btnPolicy.Size = new Size(172, 29);
            btnPolicy.TabIndex = 4;
            btnPolicy.Text = "tournament guide";
            btnPolicy.UseVisualStyleBackColor = true;
            btnPolicy.Click += btnPolicy_Click;
            // 
            // btnPenaltyGuide
            // 
            btnPenaltyGuide.Location = new Point(524, 19);
            btnPenaltyGuide.Name = "btnPenaltyGuide";
            btnPenaltyGuide.Size = new Size(131, 29);
            btnPenaltyGuide.TabIndex = 5;
            btnPenaltyGuide.Text = "penalty guide";
            btnPenaltyGuide.UseVisualStyleBackColor = true;
            btnPenaltyGuide.Click += btnPenaltyGuide_Click;
            // 
            // lnkRules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPenaltyGuide);
            Controls.Add(btnPolicy);
            Controls.Add(btnRules);
            Controls.Add(rbxShowRules);
            Name = "lnkRules";
            Text = "Rules";
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rbxShowRules;
        private Button btnRules;
        private Button btnPolicy;
        private Button btnPenaltyGuide;
    }
}