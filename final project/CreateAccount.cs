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


    public partial class CreateAccount : Form
    {
        UserContext userDb;
        Form LoginScreen = new Login();
        List<UserAccount> userAccounts;
        public CreateAccount()
        {
            userDb = new UserContext();
            InitializeComponent();

        }
        private bool CheckUserName(string enteredUserName)
        {
            bool usernameUsed = false;

            userAccounts = userDb.Users.Select(u => u).ToList();
            for (int i = 0; i < userAccounts.Count; i++)
            {
                if (userAccounts[i].UserName == enteredUserName)
                {

                    usernameUsed = true;



                }



            }



            return usernameUsed;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string enteredUserName = txtUsername.Text;

            UserAccount addAccount = new UserAccount() { UserName = txtUsername.Text, Password = txtPassword.Text, LastScore = 0, Scores = "" };
            if (CheckUserName(enteredUserName))
            {
                lblUserError.Text = "username already taken";


            }
            else
            {
                userDb.Users.Add(addAccount);
                userDb.SaveChanges();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginScreen.Show();
        }
    }
}
