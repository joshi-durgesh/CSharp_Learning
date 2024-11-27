using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Quiz
    {
        private Questions[] questions;
        private Questions checkingAns;

        public Quiz(Questions[] quest)
        {
            this.questions = quest;

        }
        public void DisplayQuestions(Questions questions)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╗");
            Console.WriteLine("╢                     Questions                       ╟");
            Console.WriteLine("╚╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╝");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(questions.QuestionText);

            for (int i = 0; i < questions.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine("." + questions.Answers[i]);
            }

            // GetUserChoice();
            if (GetUserChoice() == questions.CorrectAnswerIndex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct Answer");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Answer");
                Console.ResetColor();
            }


        }

        private int GetUserChoice()
        {
            Console.Write("Enter your answer (number only):");
            int choice = 0;
            string input = Console.ReadLine();

            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.Write("Enter correct number (between 1 to 4): ");
                input = Console.ReadLine();
            }
            return choice - 1;

        }
    }
}