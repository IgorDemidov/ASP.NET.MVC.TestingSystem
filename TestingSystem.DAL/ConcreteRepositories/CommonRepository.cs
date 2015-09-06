using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.DAL.AbstractRepositories;

namespace TestingSystem.DAL
{
    public abstract class CommonRepository<TEntity> : ICommonRepository<TEntity>
        where TEntity : class
    {
        protected readonly DbContext context = new TestingSytemEntities();

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
