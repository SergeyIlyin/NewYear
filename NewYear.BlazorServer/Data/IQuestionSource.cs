namespace NewYear.Data;

public interface IQuestionSource
{
    IEnumerable<(string question, bool answer)> GetQuestions();
}
