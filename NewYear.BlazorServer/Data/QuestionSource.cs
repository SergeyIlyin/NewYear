namespace NewYear.Data;

public class QuestionSource
{
    public IEnumerable<QuizQuestion> GetQuestions()
    {
        return new List<QuizQuestion>()
        {
            new QuizQuestion {Question="Первый вопрос", Answer=true },
            new QuizQuestion {Question="Второй вопрос", Answer=false  },
        };
    }
}
