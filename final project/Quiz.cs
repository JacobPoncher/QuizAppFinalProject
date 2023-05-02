using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace final_project
{
    public  class Quiz
    {
        private int _currentScore;
        private List <Question> _questions = new List<Question>();
        private DateTime _date;
        private string _difficulty;
        



        public bool CheckAnswer(string answer, string correctAnswer) 
        {

            if (correctAnswer != answer)
            {

                return false;
            }
            else if (correctAnswer == answer)
            {
                
                return true;
            }


            return false;

        }




        public int CurrentScore {get { return _currentScore;}   set { _currentScore = value; } }

        public List<Question> Questions { get { return _questions; } set { _questions = value; } }    

        public DateTime Date { get { return _date;} set { _date = value; } }    

        public string Difficulty { get { return _difficulty; } set { _difficulty = value; } }
           
    }
}
