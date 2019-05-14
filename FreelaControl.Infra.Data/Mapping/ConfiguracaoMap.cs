using FreelaControl.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FreelaControl.Infra.Data.Mapping
{
    internal class ConfiguracaoMap : EntityTypeConfiguration<Configuracao>
    {
        public ConfiguracaoMap()
        {
            ToTable("Configuracoes");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnOrder(991);

            Property(x => x.ValorCobradoMensal)
                .IsRequired()
                .HasColumnOrder(992);

            Property(x => x.DiaTrabalhadosMes)
                .IsRequired()
                .HasColumnOrder(993);

            Property(x => x.HorasTrabalho)
                .IsRequired()
                .HasColumnOrder(994);

            Property(x => x.DataAlteracao)
                .IsOptional()
                .HasColumnOrder(995);

            Property(x => x.DataCadastro)
                .HasColumnOrder(996);
        }
    }
}
