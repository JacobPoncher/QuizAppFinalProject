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

    public partial class Scores : Form
    {
        UserContext userDb;
        UserAccount currentUser;
        public Scores(UserAccount CurrentUser)
        {
            InitializeComponent();
            currentUser = CurrentUser;


        }

        private void Scores_Load(object sender, EventArgs e)
        {
            int findById = currentUser.Id;



            string allScores = currentUser.Scores;


            string[] scoreList = allScores.Split(";");


            foreach (string score in scoreList)
            {

                lblScores.Text += $"{score}\n";

            }
            lblLastScore.Text = currentUser.LastScore.ToString(); 

        }
    }
}
