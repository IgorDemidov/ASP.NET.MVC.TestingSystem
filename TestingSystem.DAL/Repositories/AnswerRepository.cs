using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.DAL.Repositories
{
    public class AnswerRepository: Repository<Answer>
    {
        public List<Answer> GetAnswerList(int questionId)
        {
            return context.Set<Question>().Find(questionId).Answers.ToList();
        }
    }
}
