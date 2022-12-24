namespace NewYear.Components.QuizApp;

public class Question
{
    public string? Text { get; set; }
    public bool RightAnswer { get; set; }
    public bool? UserAnswer { get; set; }

    public bool IsAnswered => UserAnswer.HasValue;
    public bool IsRight => RightAnswer == UserAnswer;
}
