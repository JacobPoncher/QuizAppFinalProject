using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace final_project
{

    public partial class Scores : Form
    {
        UserContext userDb;
        UserAccount currentUser;
        List<UserAccount> userAccounts;
        public Scores(UserAccount CurrentUser)
        {
            InitializeComponent();
            currentUser = CurrentUser;
            userDb = new UserContext();

        }

        private void Scores_Load(object sender, EventArgs e)
        {
            string userName = currentUser.UserName;
            string password = currentUser.Password;
            userAccounts = userDb.Users.Select(u => u).ToList();
            foreach (UserAccount account in userAccounts)
            {
                if (userName == account.UserName & password == account.Password)
                {
                    currentUser = account;


                }



            }




            // int findById = currentUser.Id;

            // UserAccount? thisUser = userDb.Users.Find(findById);

            string allScores = currentUser.Scores;


            string[] scoreList = allScores.Split(";");


            /* foreach (string score in scoreList)
             {

                 int countScore = score.Length;
                 string newScore = score.Remove(countScore);




                 lblScores.Text += $"{newScore}\n";

             }
            */

            for (int i = 0; i < scoreList.Length; i++)
            {
                int countScore = scoreList[i].Length;
                string newScore = scoreList[i].Remove(countScore);




                lblScores.Text += $"quiz number{i + 1}:{newScore}\n";






            }

            lblLastScore.Text = currentUser.LastScore.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
