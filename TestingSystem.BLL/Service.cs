using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.DAL;
using TestingSystem.WebUI.Models;


namespace TestingSystem.BLL
{
    public class Service
    {
        Repository repository = new Repository();

        public List<string> GetThemeNamesList()
        {
           return repository.GetThemesList().Select(t => t.Name).ToList();
        }
    }
}
