using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Quiz
    {
        private Questions[] questions;

        public Quiz(Questions[] questions)
        {
            this.questions = questions;
        }
    }
}