using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.DAL.AbstractRepositories
{
    public interface IAnswerRepository: ICommonRepository<Answer>
    {
        List<Answer> GetAnswerList(int questionId);
    }
}
