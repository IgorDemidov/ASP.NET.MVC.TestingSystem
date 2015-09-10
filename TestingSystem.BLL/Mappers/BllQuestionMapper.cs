using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.BLL.Models;
using TestingSystem.DAL;

namespace TestingSystem.BLL.Mappers
{
    public static class BllQuestionMapper
    {
        public static QuestionModel ToQuestionModel(this Question question)
        {
            return new QuestionModel()
            {
                Id = question.QuestionID,
                Text = question.Text,
                ThemeId = question.ThemeID,
                Answers = question.Answers.Select(a=>a.ToAnswerModel()).ToList()
            };
        }
    }
}
