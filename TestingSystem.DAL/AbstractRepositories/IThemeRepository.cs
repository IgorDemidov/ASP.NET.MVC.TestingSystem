using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.DAL.AbstractRepositories;

namespace TestingSystem.DAL.Abstract
{
    public interface IThemeRepository: ICommonRepository<Theme>
    {
        List<Theme> GetThemesList();

        Theme GetThemeById(int id);
    }
}
