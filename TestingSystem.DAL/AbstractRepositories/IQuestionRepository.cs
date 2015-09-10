using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.DAL.AbstractRepositories
{
    public interface IQuestionRepository: ICommonRepository<Question>
    {
        Question GetNextQuestionById(int currQuestionId);

        Question GetFirstQuestionByThemeId(int themeId);

        Question GetQuestionById(int questionId);

        int GetQuestionCountByThemeId(int themeId);

    }
}
