using FreelaControl.Domain.Interfaces;
using FreelaControl.Infra.Data.Context;
using FreelaControl.Infra.Data.Repository;
using FreelaControl.Services.Services;
using SimpleInjector;
using System.Data.Entity;

namespace FreelaControl.Infra.CrossCutting.IoC
{
    public static class DIContainer
    {
        public static Container RegisterDependencies()
        {
            var container = new Container();

            container.Register(typeof(IRepositoryBase<>), typeof(BaseRepository<>));

            container.Register<IUsuarioRepositoy, UsuarioRepository>();
            container.Register<IUsuarioService, UsuarioService>();

            container.Register<DbContext, PostgreContext>(Lifestyle.Singleton);

            return container;
        }
    }
}
