using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.DAL;
using TestingSystem.DAL.Repositories;
using TestingSystem.BLL.Models;
using TestingSystem.DAL.Abstract;


namespace TestingSystem.BLL
{
    public class TestingService
    {
        private readonly IThemeRepository themeRepository;
        private readonly  QuestionCommonRepository _questionCommonRepository = new QuestionCommonRepository();
        private readonly AnswerCommonRepository _answerCommonRepository = new AnswerCommonRepository();

        public TestingService(IThemeRepository themeRepository)
        {
            this.themeRepository = themeRepository;
        }

        public List<ThemeModel> GetThemeModelList()
        {
            return _themeBaseRepository.GetThemesList().Select(CreateThemeModel).ToList();
        }

        public QuestionModel GetNextQuestionModel(int questionId)
        {
            Question question = _questionCommonRepository.GetNextQuestionById(questionId);

            return CreateQuestionModel(question);
        }

        public QuestionModel GetFirstQuestionModel(ThemeModel themeModel)
        {
            Question question = _questionCommonRepository.GetFirstQuestionByThemeId(themeModel.Id);

            return CreateQuestionModel(question);
        }

        public int GetQuestionCount(ThemeModel themeModel)
        {
           return _questionCommonRepository.GetQuestionCountByThemeId(themeModel.Id);
        }

        public ThemeModel GeThemeModelById(int themeId)
        {
            Theme theme = _themeBaseRepository.GetThemeById(themeId);
            return CreateThemeModel(theme);
        }

        public QuestionModel GetQuestionModelById(int questionId)
        {
            Question question = _questionCommonRepository.GetQuestionById(questionId);
            return CreateQuestionModel(question);
        }

        #region Private methods

        private ThemeModel CreateThemeModel(Theme theme)
        {
            if (theme == null)
                return null;

            ThemeModel model = new ThemeModel
            {
                Id = theme.ThemeID,
                Name = theme.Name
            };
            return model;
        }

        private QuestionModel CreateQuestionModel(Question question)
        {
            if (question == null)
                return null;
            QuestionModel model = new QuestionModel
            {
                Id = question.QuestionID,
                ThemeName = _themeBaseRepository.GetThemeById(question.ThemeID).Name,
                Text = question.Text,
                AnswerModels = _answerCommonRepository.GetAnswerList(question.QuestionID).Select(CreateAnswerModel).ToList()
            };
            return model;
        }

        private AnswerModel CreateAnswerModel(Answer answer)
        {
            if (answer == null)
                return null;

            AnswerModel model = new AnswerModel
            {
                Id = answer.AnswerID,
                IsRight = answer.IsRight,
                Text = answer.Text
            };
            return model;
        }
        
        #endregion



    }
}
