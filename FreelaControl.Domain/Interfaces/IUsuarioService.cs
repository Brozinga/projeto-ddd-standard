using FreelaControl.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreelaControl.Domain.Interfaces
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        Task<Usuario> Get(string id);
        Task<IEnumerable<Usuario>> GetAll();
    }
}
