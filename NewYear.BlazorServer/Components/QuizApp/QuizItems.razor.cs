using Microsoft.AspNetCore.Components;
using NewYear.Data;

namespace NewYear.Components.QuizApp;

public partial class QuizItems
{
    [Inject]
    public IQuestionSource QuestionSource { get; set; }


    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _questions = QuestionSource.GetQuestions().Select(t => new Question
        {
            Text = t.question,
            RightAnswer = t.answer
        }).ToList();
        CurrentQuestion = _questions.FirstOrDefault();
    }

    List<Question> _questions;

    Question CurrentQuestion { get; set; }

    int _currentQuestionIndex=>_questions.IndexOf(CurrentQuestion);
}
