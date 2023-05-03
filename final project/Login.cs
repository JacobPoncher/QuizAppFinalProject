namespace final_project
{
    public partial class Login : Form
    {
        UserContext userDb;
        List<UserAccount> userAccounts;
        UserAccount currentUser;

        public Login()
        {
            userDb = new UserContext();
            InitializeComponent();
           

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Form CAccount = new CreateAccount();
            CAccount.ShowDialog();
        }

        private bool UserLogin(string enteredUsername, string enteredPassword) 
        {
            userAccounts = userDb.Users.Select(u => u).ToList();
            bool loggedIn = false;
            foreach (UserAccount account in userAccounts)
            {
                if (enteredUsername.ToLower() == account.UserName.ToLower() && enteredPassword == account.Password)
                {
                    currentUser = account;
                    
                    return loggedIn= true;
                }



            }
            if (loggedIn == false )
                {
                throw new InvalidLoginException("incorrect username or password");
           
            }


            return loggedIn;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassword.Text;

            
                
             try
            {
                UserLogin(enteredUsername, enteredPassword);
            }
            catch (InvalidLoginException ex) 
            {
                lblLoginError.Text = ex.Message;
            }


           







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}