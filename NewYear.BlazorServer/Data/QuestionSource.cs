namespace NewYear.Data;

public class QuestionSource: IQuestionSource
{
    public IEnumerable<(string question, bool answer)> GetQuestions()
    {
        return Values;
    }

    static List<(string question, bool answer)> Values = new List<(string question, bool answer)>()
    {
        new("Первый вопрос", true ),
        new("Второй вопрос",false ),
        new("Четвертый вопрос", true ),
        new("Пятый вопрос",false )
    };
}
