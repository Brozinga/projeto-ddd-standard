using FreelaControl.Domain.Entities;
using FreelaControl.Domain.Interfaces;
using FreelaControl.Infra.Data.Mapping;
using System.Data.Entity;

namespace FreelaControl.Infra.Data.Context
{

    public class PostgreContext : DbContext
    {
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Trabalho> Trabalhos { get; set; }
        DbSet<Upload> Uploads { get; set; }
        DbSet<NivelAcesso> NiveisAcessos { get; set; }

        public PostgreContext()
            :base(nameOrConnectionString: "freelacontrol-db")
        {
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new UsuarioMap());
            builder.Configurations.Add(new TrabalhoMap());
            builder.Configurations.Add(new UploadMap());
            builder.Configurations.Add(new NivelAcessoMap());
        }
    }
}
