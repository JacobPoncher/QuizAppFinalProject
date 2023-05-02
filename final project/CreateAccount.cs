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
        Form LoginScreen = new Form1();
        public CreateAccount()
        {
            userDb = new UserContext();
            InitializeComponent();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserAccount addAccount = new UserAccount() { UserName = txtUsername.Text, Password = txtPassword.Text ,LastScore = 0, Scores = ""};

            userDb.Users.Add(addAccount);
            userDb.SaveChanges();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginScreen.Show();
        }
    }
}
