using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public class Question
    {
        private string _question;
        private string _answer1;
        private string _answer2;
        private string _answer3;
        private string _answer4;
        private string _correctAnswer;
        private string _difficulty;

        public Question(string question, string answer1, string answer2, string answer3, string answer4, string correctAnswer, string difficulty)
        {
            _question = question;
            _answer1 = answer1;
            _answer2 = answer2;
            _answer3 = answer3;
            _answer4 = answer4;
            _correctAnswer = correctAnswer;
            _difficulty = difficulty;
        }

   




        public string Questions{ get { return _question; } }
        public string Answer1 { get { return _answer1; } }  
        public string Answer2 { get {  return _answer2; } } 
        public string Answer3 { get {  return _answer3; } } 
        public string Answer4 { get {  return _answer4; } } 
        public string CorrectAnswer { get { return _correctAnswer; } }

        public string Difficulty { get { return _difficulty;} } 
    }
}
