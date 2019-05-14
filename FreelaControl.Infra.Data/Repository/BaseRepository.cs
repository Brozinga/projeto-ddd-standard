using FreelaControl.Domain.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;

namespace FreelaControl.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : class
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Remove(T obj)
        {
            _context.Set<T>().Remove(obj);
        }

        public void Update(T obj)
        {
            _context.Set<T>().AddOrUpdate(obj);
        }

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
