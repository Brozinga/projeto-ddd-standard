using FreelaControl.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FreelaControl.Infra.Data.Mapping
{
    internal class NivelAcessoMap : EntityTypeConfiguration<NivelAcesso>
    {
        public NivelAcessoMap()
        {
            ToTable("NiveisdeAcesso");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnOrder(991);

            Property(x => x.Nome)
                .HasMaxLength(100)
                .HasColumnOrder(992)
                .IsRequired();

            Property(x => x.Status)
                .HasColumnOrder(993)
                .IsRequired();

            Property(x => x.DataAlteracao)
                .HasColumnOrder(994)
                .IsOptional();

            Property(x => x.DataCadastro)
                .HasColumnOrder(995);

        }
    }
}
