using System.Collections.Generic;
using System.Threading.Tasks;
using FreelaControl.Domain.Entities;
using FreelaControl.Domain.Interfaces;

namespace FreelaControl.Services.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepositoy _rp;
        public UsuarioService(IUsuarioRepositoy repository) : base(repository)
        {
            _rp = repository;
        }

        public async Task<Usuario> Get(string id)
        {
            return await _rp.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            return await _rp.GetAllAsync();
        }
    }
}
