using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.DAL.Abstract;

namespace TestingSystem.DAL.Repositories
{
    public class ThemeRepository : CommonRepository<Theme>, IThemeRepository
    {
        public List<Theme> GetThemesList()
        {
            return context.Set<Theme>().ToList();
        }

        public Theme GetThemeById(int id)
        {
            return context.Set<Theme>().Find(id);
        }
    }
}
