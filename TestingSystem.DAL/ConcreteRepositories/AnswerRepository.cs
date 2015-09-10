using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.DAL.AbstractRepositories;

namespace TestingSystem.DAL.Repositories
{
    public class AnswerRepository: CommonRepository<Answer>, IAnswerRepository
    {
        public List<Answer> GetAnswerList(int questionId)
        {
            return context.Set<Question>().Find(questionId).Answers.ToList();
        }
    }
}
