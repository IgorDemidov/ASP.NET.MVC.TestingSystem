using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.DAL;
using TestingSystem.DAL.Repositories;
using TestingSystem.BLL.Models;


namespace TestingSystem.BLL
{
    public class Service
    {
        private readonly ThemeRepository _themeRepository = new ThemeRepository();


        public List<ThemeModel> GetThemeModelList()
        {
            return _themeRepository.GetThemesList().Select(GetThemeModelByTheme).ToList();
        }

        private ThemeModel GetThemeModelByTheme(Theme theme)
        {
            ThemeModel model = new ThemeModel
            {
                ThemeId = theme.ThemeID,
                Name = theme.Name
            };
            return model;
        }
        


    }
}
