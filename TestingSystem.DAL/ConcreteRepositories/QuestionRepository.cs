using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.DAL.AbstractRepositories;

namespace TestingSystem.DAL.Repositories
{
    public class QuestionCommonRepository: CommonRepository<Question>, IQuestionRepository
    {
        public Question GetNextQuestionById(int currQuestionId)
        {
            Question currQuestion = context.Set<Question>().Find(currQuestionId);
            int themeId = currQuestion.ThemeID;
            Question next = context.Set<Theme>().Find(themeId).Questions.First(q => q.QuestionID > currQuestionId);

            return next;
        }

        public Question GetFirstQuestionByThemeId(int themeId)
        {
            return context.Set<Theme>().Find(themeId).Questions.First();
        }

        public Question GetQuestionById(int questionId)
        {
            return context.Set<Question>().Find(questionId);
        }

        public int GetQuestionCountByThemeId(int themeId)
        {
            return context.Set<Theme>().Find(themeId).Questions.Count;
        }



    }
}
