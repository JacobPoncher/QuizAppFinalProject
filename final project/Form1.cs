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
           

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Form CAccount = new CreateAccount();
            CAccount.ShowDialog();
        }

        private bool Login(string enteredUsername, string enteredPassword) 
        {
            userAccounts = userDb.Users.Select(u => u).ToList();
            bool loggedIn = false;
            foreach (UserAccount account in userAccounts)
            {
                if (enteredUsername == account.UserName && enteredPassword == account.Password)
                {
                    currentUser = account;
                    
                    return loggedIn= true;
                }



            }



            return loggedIn;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassword.Text;

            if (Login(enteredUsername, enteredPassword)) 
            {
                Form HomeScreen = new HomeScreen(currentUser);
                HomeScreen.Show();
                

            }
            else { lblLoginError.Text = "incorrect username or password"; }


           







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}