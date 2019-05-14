using FreelaControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FreelaControl.Domain.Interfaces
{
    public interface IUsuarioRepositoy : IRepositoryBase<Usuario>
    {
        Task<Usuario> GetByIdAsync(string id);
        //Task<IList<Usuario>> GetAsync(Expression<Func<Usuario, bool>> predicate);
        Task<IEnumerable<Usuario>> GetAllAsync();
    }
}
