using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.DAL
{
    public class Repository<TEntity> : IDisposable
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
