using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.DAL.AbstractRepositories
{
    public interface ICommonRepository<TEntity> : IDisposable
        where TEntity : class
    {
        void Add(TEntity entity);
    }
}
