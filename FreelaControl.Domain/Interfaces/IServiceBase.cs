using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreelaControl.Domain.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        Task<T> Post<V>(T obj) where V : AbstractValidator<T>;
        Task<T> Put<V>(T obj) where V : AbstractValidator<T>;
        Task Delete(T obj);
    }
}
