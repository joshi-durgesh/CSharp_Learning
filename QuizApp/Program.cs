namespace QuizApp;

class Program
{
    static void Main(string[] args)
    {
        Questions[] questObj = new Questions[]{
            new Questions("What is the capital of india?",
            new string[] { "Kolkata", "Mumbai","Delhi","Punjab"},
            2),
            new Questions("2+2", new string[] { "5", "4","3","6"},1)
        };

        Quiz quiz = new Quiz(questObj);
        quiz.StartQuiz();

    }
}
