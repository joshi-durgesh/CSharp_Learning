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

        public Quiz(Questions[] quest)
        {
            this.questions = quest;

        }

        public void StartQuiz()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("╔╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╗");
            Console.WriteLine("╢                 Welcome to the Quiz!                ╟");
            Console.WriteLine("╚╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╝");
            Console.ResetColor();
            int questionNumber = 1;
            int correctAns = 0;
            foreach (Questions quest in questions)
            {
                DisplayQuestions(quest, questionNumber++);
                int userInput = GetUserChoice();
                if (quest.IsCorrectAnswer(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct answer.\n");
                    Console.ResetColor();
                    correctAns++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong! Correct answer is {0}.\n", quest.Answers[quest.CorrectAnswerIndex]);
                    Console.ResetColor();
                }
            }
            Console.WriteLine("You entered {0} correct answers", correctAns);

        }

        private void DisplayQuestions(Questions questions, int questNum)
        {

            Console.Write($"Question {questNum}. ");
            Console.WriteLine(questions.QuestionText);

            for (int i = 0; i < questions.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine("." + questions.Answers[i]);
            }
            Console.WriteLine();
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