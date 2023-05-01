namespace final_project
{
    public partial class Form1 : Form
    {
        UserContext userDb;
        List<UserAccount> userAccounts;
        UserAccount currentUser;
        
        public Form1()
        {
            userDb = new UserContext();
            InitializeComponent();
            userAccounts = userDb.Users.Select(u => u).ToList();
            
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Form CAccount = new CreateAccount();
            CAccount.ShowDialog();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {

            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassword.Text;
            foreach (UserAccount account in userAccounts) 
            {
                if (enteredUsername == account.UserName &&  enteredPassword == account.Password) 
                {
                    currentUser = account;
                    Form HomeScreen = new HomeScreen( currentUser);
                    HomeScreen.ShowDialog();
                
                }
            
            
            
            }






     
            
        }

    }
}