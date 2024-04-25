using Microsoft.AspNetCore.Components;
using Quizzing.Models;

namespace Quizzing.Pages
{
    public class QuizCardBase : ComponentBase
    {
        public List<Question> Questions { get; set; } = new();
        protected int questionIndex;
        protected int score;

        protected override Task OnInitializedAsync()
        {
            LoadQuestions();

            return base.OnInitializedAsync();
        }

        protected void OptionSelected(string option)
        {
            if (option == Questions[questionIndex].Answer)
            {
                score++;
            }
            questionIndex++;
        }

        protected void RestartQuiz()
        {
            score = 0;
            questionIndex = 0;
        }

        private void LoadQuestions()
        {
            Questions.AddRange(new List<Question>
            {
                new()
                {
                    QuestionImageName = "1.jpeg",
                    Options = new List<string> { "1", "2" },
                    Answer = "2"
                },
                new()
                {
                    QuestionImageName = "2.jpeg",
                    Options = new List<string> { "1", "2", "3" },
                    Answer = "2"
                },
                new()
                {
                    QuestionImageName = "3.jpeg",
                    Options = new List<string> { "1", "2", "3", "4" },
                    Answer = "2"
                },
                new()
                {
                    QuestionImageName = "4.jpeg",
                    Options = new List<string> { "1", "2", "3", "4" },
                    Answer = "4"
                },
                new()
                {
                    QuestionImageName = "5.jpeg",
                    Options = new List<string> { "1", "2", "3", "4" },
                    Answer = "2"
                },
            });
        }
    }
}
