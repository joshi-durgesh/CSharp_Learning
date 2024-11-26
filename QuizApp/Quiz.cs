using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Quiz
    {
        private Questions[] questions;

        public Quiz(Questions[] quest)
        {
            this.questions = quest;

        }
        public void DisplayQuestions(Questions questions)
        {
            Console.WriteLine(questions.QuestionText);
        }
    }
}