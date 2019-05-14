using FreelaControl.Domain.Entities;
using FreelaControl.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FreelaControl.Infra.Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepositoy
    {
        private readonly DbContext _db;
        public UsuarioRepository(DbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            var list = await _db.Set<Usuario>().ToListAsync();
            return list;
        }

        public async Task<Usuario> GetByIdAsync(string id)
        {
            var entity = await _db.Set<Usuario>().FirstOrDefaultAsync(x => x.Id.ToString().Equals(id));
            return entity;
        }
    }
}
