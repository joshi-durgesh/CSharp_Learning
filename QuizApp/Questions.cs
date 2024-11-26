using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Questions
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Questions(string questionText, string[] answer, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answer;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public bool IsCorrectAnswer(int answerIndex)
        {
            return CorrectAnswerIndex == answerIndex;
        }
    }
}