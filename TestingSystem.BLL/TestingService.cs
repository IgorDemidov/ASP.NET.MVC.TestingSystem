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


namespace TestingSystem.BLL
{
    public class TestingService
    {
        private readonly ThemeRepository _themeRepository = new ThemeRepository();
        private readonly  QuestionRepository _questionRepository = new QuestionRepository();
        private readonly AnswerRepository _answerRepository = new AnswerRepository();

        public List<ThemeModel> GetThemeModelList()
        {
            return _themeRepository.GetThemesList().Select(CreateThemeModel).ToList();
        }

        public QuestionModel GetNextQuestionModel(QuestionModel questionModel)
        {
            Question question = _questionRepository.GetNextQuestionById(questionModel.Id);

            return CreateQuestionModel(question);
        }

        public QuestionModel GetFirstQuestionModel(ThemeModel themeModel)
        {
            Question question = _questionRepository.GetFirstQuestionByThemeId(themeModel.Id);

            return CreateQuestionModel(question);
        }

        public int GetQuestionCount(ThemeModel themeModel)
        {
           return _questionRepository.GetQuestionCountByThemeId(themeModel.Id);
        }

        public ThemeModel GeThemeModelById(int themeId)
        {
            Theme theme = _themeRepository.GetThemeById(themeId);
            return CreateThemeModel(theme);
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
                ThemeName = _themeRepository.GetThemeById(question.ThemeID).Name,
                Text = question.Text,
                AnswerModels = _answerRepository.GetAnswerList(question.QuestionID).Select(CreateAnswerModel).ToList()
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
