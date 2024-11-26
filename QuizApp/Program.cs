namespace QuizApp;

class Program
{
    static void Main(string[] args)
    {
        Questions[] questObj = new Questions[]{
            new Questions("What is the capital of india?",
            new string[] { "Kolkata", "Mumbai","Delhi","Punjab"},
            2)
        };

        Quiz quiz = new Quiz(questObj);
        quiz.DisplayQuestions(questObj[0]);

    }
}
