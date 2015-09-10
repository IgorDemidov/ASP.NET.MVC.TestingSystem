using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.BLL.Models;
using TestingSystem.DAL;

namespace TestingSystem.BLL.Mappers
{
    public static class BllAnswerMapper
    {
        public static AnswerModel ToAnswerModel(this Answer answer)
        {
            return new AnswerModel()
            {
                Id = answer.AnswerID,
                IsRight = answer.IsRight,
                QuestionId = answer.QuestionID,
                Text = answer.Text
            };
        }

        
    }
}
