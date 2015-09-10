using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.BLL.Abstract;
using TestingSystem.BLL.Mappers;
using TestingSystem.DAL;
using TestingSystem.DAL.Repositories;
using TestingSystem.BLL.Models;
using TestingSystem.DAL.Abstract;
using TestingSystem.DAL.AbstractRepositories;


namespace TestingSystem.BLL
{
    public class TestingService: ITestingService
    {
        private readonly IThemeRepository themeRepository;
        private readonly IQuestionRepository questionRepository;
        private readonly IAnswerRepository answerRepository;

        public TestingService(IThemeRepository themeRepository, IQuestionRepository questionRepository, IAnswerRepository answerRepository)
        {
            this.themeRepository = themeRepository;
            this.answerRepository = answerRepository;
            this.questionRepository = questionRepository;
        }

        public List<ThemeModel> GetThemeModelList()
        {
            return themeRepository.GetThemesList().Select(t=>t.ToThemeModel()).ToList();
        }

        public QuestionModel GetNextQuestionModel(int questionId)
        {
            Question question = questionRepository.GetNextQuestionById(questionId);

            return question.ToQuestionModel();
        }

        public QuestionModel GetFirstQuestionModel(ThemeModel themeModel)
        {
            Question question = questionRepository.GetFirstQuestionByThemeId(themeModel.Id);

            return question.ToQuestionModel();
        }

        public int GetQuestionCount(ThemeModel themeModel)
        {
            return questionRepository.GetQuestionCountByThemeId(themeModel.Id);
        }

        public ThemeModel GeThemeModelById(int themeId)
        {
            Theme theme = themeRepository.GetThemeById(themeId);
            return theme.ToThemeModel();
        }

        public QuestionModel GetQuestionModelById(int questionId)
        {
            Question question = questionRepository.GetQuestionById(questionId);
            return question.ToQuestionModel();
        }


    }
}
