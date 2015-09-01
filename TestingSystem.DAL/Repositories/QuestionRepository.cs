using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.DAL.Repositories
{
    public class QuestionRepository: Repository<Question>
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

        public int GetQuestionCountByThemeId(int themeId)
        {
            return context.Set<Theme>().Find(themeId).Questions.Count;
        }


    }
}
