using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FreelaControl.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Insert(T obj);
        void Update(T obj);
        void Remove(T obj);
        Task SaveAsync();
    }
}
