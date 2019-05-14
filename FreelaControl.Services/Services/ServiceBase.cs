using FluentValidation;
using FreelaControl.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace FreelaControl.Services.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository; 

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public async Task Delete(T obj)
        {
            _repository.Remove(obj);
            await _repository.SaveAsync();
        }

        public async Task<T> Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());
            _repository.Insert(obj);
            await _repository.SaveAsync();
            return obj;
        }

        public async Task<T> Put<V>(T obj) where V : AbstractValidator<T>
        {

            Validate(obj, Activator.CreateInstance<V>());
            _repository.Update(obj);
            await _repository.SaveAsync();
            return obj;
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
