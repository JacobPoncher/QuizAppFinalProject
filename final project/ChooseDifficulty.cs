using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class ChooseDifficulty : Form
    {
        UserAccount currentUser;
        public ChooseDifficulty(UserAccount currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Quiz quiz = new Quiz();

            //if (rbtEasy.Checked) 
            //{
            //    quiz.Difficulty = "easy";
            
            //}
            //else if (rbtHard.Checked) 
            //{
            //    quiz.Difficulty = "hard";
            
            
            
            //}
            //Quiz currentQuiz;

            //currentQuiz = quiz;
            //Form startQuiz = new TakeQuiz(currentUser,currentQuiz );
            //startQuiz.ShowDialog();
        }
    }
}
