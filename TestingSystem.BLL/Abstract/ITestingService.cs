using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.BLL.Models;
using TestingSystem.DAL;
using TestingSystem.DAL.Abstract;

namespace TestingSystem.BLL.Abstract
{
    public interface ITestingService
    {
        List<ThemeModel> GetThemeModelList();
        QuestionModel GetNextQuestionModel(int questionId);
        QuestionModel GetFirstQuestionModel(ThemeModel themeModel);
        int GetQuestionCount(ThemeModel themeModel);
        ThemeModel GeThemeModelById(int themeId);
        QuestionModel GetQuestionModelById(int questionId);
    }
}
