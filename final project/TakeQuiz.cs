using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace final_project
{
    public partial class TakeQuiz : Form
    {
        UserContext userDb;
        UserAccount currentUser;
        Quiz thisQuiz = new Quiz();
        int currentquestion;
        bool questionAnswered = false;

        public TakeQuiz(UserAccount CurrentUser)
        {
            InitializeComponent();


            userDb = new UserContext();
            currentUser = CurrentUser;




        }

        List<Question> _questions = new List<Question>()
        {new Question("your opponent plays an erase face, you take the damage.you have an achillies accelerator, on  your turn you play a card with boost. what happens next?"," you can't activate achillies accelerator because your cards lost the mechanologist class , and cannot boost","you can activate the achilles accelerator because boosting doesnt care if you its a mechanologist","you cant attack because you cant boost","you cant do anything and end the turn","you can activate the achilles accelerator because boosting doesnt care if you its a mechanologist","easy"),
         new Question("you play lead the charge(r), another lead the charge(r), then ravenous rabble. how many action points do you have?","1","2","3","4","3","easy"),
         new Question("you have both an intertia and ponder token,going into endphase, what happens?","ponder triggers first , then inertia","inertia triggers then ponder triggers"," you choose the order","your opponent chooses"," you choose the order","hard"),
         new Question("you have 5 frost bites and 7  runechants, you play drawn to the dark dimension, how much you do need to pitch?","0","2","5","7","0","hard"),
         new Question("what is an IP5?","intellect is 0 for 5 turns","intellect is minus 1 for 5 turns"," intellect is 5 less for 1 turn"," your opponent's intellect is increased by 1 for 5 turns","intellect is minus 1 for 5 turns","easy"),
         new Question("you play nimbilism, then infiltate, activate uzuri and put enlightened stike on the combat chain, your opponent doesnt block , how damage is being dealt?","3","6","5","8","5","hard"),
         new Question("You play bramble spark, you earth fuse and play overload. Your opponent blocks all damage with unmovable, and takes the 1 arcane damage. What happens next?" ,"overload dealt arcane damage so it gains go again","Arcane damage doesnt count as hit  damage , overload doesnt gain go again","overload loses go again"," Your opponent loses 1 life","Arcane damage doesnt count as hit  damage , overload doesnt gain go again","easy"),
         new Question("Your opponent attacks with Harmonized Kodachi, you play brush off. He plays short and sharp, How much damage is prevented?","1","4","3","0","0","hard")






        };



        private void StartQuiz()
        {

            string chosenDifficulty = "";

            if (rbtEasy.Checked)
            {

                thisQuiz.Difficulty = "easy";
                chosenDifficulty = thisQuiz.Difficulty.ToString();

            }
            else if (rbtHard.Checked)
            {
                thisQuiz.Difficulty = "hard";
                chosenDifficulty = thisQuiz.Difficulty.ToString();



            }
            thisQuiz.Date = DateTime.Now;

            for (int i = 0; i < _questions.Count; i++)
            {
                if (_questions[i].Difficulty == chosenDifficulty)
                {

                    thisQuiz.Questions.Add(_questions[i]);





                }







            }



            currentquestion = 0;

            rbxQuestion.Text = thisQuiz.Questions[currentquestion].Questions.ToString();
            rbtQuestion1.Text = thisQuiz.Questions[currentquestion].Answer1.ToString();
            rbtQuestion2.Text = thisQuiz.Questions[currentquestion].Answer2.ToString();
            rbtQuestion3.Text = thisQuiz.Questions[currentquestion].Answer3.ToString();
            rbtquestion4.Text = thisQuiz.Questions[currentquestion].Answer4.ToString();
            lblQuestionNum.Text = $"{currentquestion+1}/{thisQuiz.Questions.Count}";


        }

        private void NextQuestion()
        {

            currentquestion++;
            rbxQuestion.Text = thisQuiz.Questions[currentquestion].Questions.ToString();
            rbtQuestion1.Text = thisQuiz.Questions[currentquestion].Answer1.ToString();
            rbtQuestion2.Text = thisQuiz.Questions[currentquestion].Answer2.ToString();
            rbtQuestion3.Text = thisQuiz.Questions[currentquestion].Answer3.ToString();
            rbtquestion4.Text = thisQuiz.Questions[currentquestion].Answer4.ToString();

            lblQuestionNum.Text = $"{currentquestion+1}/{ thisQuiz.Questions.Count}";
            lblResult.Text = string.Empty;


        }
        int score = 0;
        private void TakeQuiz_Load(object sender, EventArgs e)
        {


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (questionAnswered)
            {
                NextQuestion();
                btnSubmit.Enabled = true;



            }
            else { lblResult.Text = "please answer the question"; }
            
            

            if (currentquestion == thisQuiz.Questions.Count)
            {
                btnNext.Visible = false;
                btnFinish.Visible = true;


            }
            else if (currentquestion < thisQuiz.Questions.Count)
            {

                btnNext.Visible = true;

            }
            questionAnswered = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string answer = "";
            string correctAnswer = thisQuiz.Questions[currentquestion].CorrectAnswer;
            if (rbtQuestion1.Checked) answer = rbtQuestion1.Text;
            else if (rbtQuestion2.Checked) answer = rbtQuestion2.Text;
            else if (rbtQuestion3.Checked) answer = rbtQuestion3.Text;
            else if (rbtquestion4.Checked) answer = rbtquestion4.Text;
            questionAnswered = true;

            if (thisQuiz.CheckAnswer(answer,correctAnswer) == false)
            {

                lblResult.Text = "incorrect";
            }
            else if (thisQuiz.CheckAnswer(answer, correctAnswer))
            {
                score++;
                lblResult.Text = "correct";
            }
            btnSubmit.Enabled = false;

            if (currentquestion + 1 == thisQuiz.Questions.Count)
            {
                btnNext.Visible = false;
                btnFinish.Visible = true;


            }
            else if (currentquestion + 1 < thisQuiz.Questions.Count)
            {

                btnNext.Visible = true;

            }
        }

        private void UpdateScores(string finishedScore, int lastScore)
        {
            int updateById = (int)currentUser.Id;

            UserAccount? updateScore = userDb.Users.Find(updateById);


            if (updateScore.Scores != null)
            {
                string updatedScore = updateScore.Scores + " " + finishedScore;
                updateScore.Scores = updatedScore;

                updateScore.LastScore = lastScore;
                userDb.Users.Update(updateScore);
                userDb.SaveChanges();



            }
            else
            {
                updateScore.Scores += " " + finishedScore;
                updateScore.LastScore = lastScore;
                userDb.Users.Update(updateScore);
                userDb.SaveChanges();


            }













        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{score}/{thisQuiz.Questions.Count}   {thisQuiz.Difficulty}    {thisQuiz.Date};";

            string finishedScore = lblResult.Text;
            int lastScore = score / thisQuiz.Questions.Count;
            UpdateScores(finishedScore, lastScore);




        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            StartQuiz();
            gbxQuiz.Visible = true;
            gpxChooseDifficulty.Visible = false;

        }
    }
}
