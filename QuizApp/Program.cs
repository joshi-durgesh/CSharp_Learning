namespace QuizApp;

class Program
{
    static void Main(string[] args)
    {
        Questions[] questions = new Questions[]{
            new Questions("What is the capital of india?",
            new string[] { "Kolkata", "Mumbai","Delhi","Punjab"},
            2)
        };

        Quiz quiz = new Quiz(questions);
        quiz.DisplayQuestions(questions[0]);

    }
}
