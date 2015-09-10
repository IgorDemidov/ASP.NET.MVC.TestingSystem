using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.BLL.Models;
using TestingSystem.DAL;

namespace TestingSystem.BLL.Mappers
{
    public static class BllThemeMapper
    {
        public static ThemeModel ToThemeModel(this Theme theme)
        {
            return new ThemeModel()
            {
                Id = theme.ThemeID,
                Name = theme.Name
            };
        }
    }
}
