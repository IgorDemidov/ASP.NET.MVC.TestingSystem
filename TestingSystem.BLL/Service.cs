using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.DAL;


namespace TestingSystem.BLL
{
    public class Service
    {
        Repository repository = new Repository();

        public List<string> GetStringThemesList()
        {
            return repository.GetThemesList().Select(t => t.Name).ToList();
        }

        public Question GetNextQuestion(Question current)
        {
            return repository.GetNextQuestion(current);
        }
    }
}
