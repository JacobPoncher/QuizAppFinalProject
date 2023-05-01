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
    public partial class HomeScreen : Form
    {
        UserContext userDb;
        List<UserAccount> userAccounts;
        UserAccount currentUser;
        public HomeScreen(UserAccount CurrentUser)
        {
            userDb = new UserContext();
            InitializeComponent();
            currentUser = CurrentUser;

            userAccounts = userDb.Users.Select(u => u).ToList();

            

        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            Form Scores = new Scores(currentUser);
            Scores.ShowDialog();

        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            Form Rules = new lnkRules();
            Rules.ShowDialog();

        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            Form takeQuiz = new TakeQuiz(currentUser);
            takeQuiz.ShowDialog();

        }
    }
}
