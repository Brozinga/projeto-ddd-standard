using FreelaControl.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FreelaControl.Infra.Data.Mapping
{
    internal class TrabalhoMap : EntityTypeConfiguration<Trabalho>
    {
        public TrabalhoMap()
        {
            ToTable("Trabalhos");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnOrder(991);

            Property(x => x.Titulo)
                .HasMaxLength(100)
                .HasColumnOrder(2)
                .IsRequired();

            Property(x => x.Prazo)
                .HasColumnOrder(992);

            Property(x => x.Descricao)
                .HasColumnType("text")
                .HasColumnOrder(993)
                .IsRequired();

            Property(x => x.Prazo)
                .HasColumnOrder(994)
                .IsRequired();

            Property(x => x.Status)
                .HasColumnOrder(995)
                .IsRequired();

            Property(x => x.ValorHora)
                .HasColumnOrder(996)
                .IsOptional();

            Property(x => x.ValorFechado)
                .HasColumnOrder(997)
                .IsOptional();

            Property(x => x.DataEntrega)
                .IsOptional()
                .HasColumnOrder(998);

            Property(x => x.DataAlteracao)
                .IsOptional()
                .HasColumnOrder(999);

            Property(x => x.DataCadastro)
                .HasColumnOrder(1000);
        }
    }
}
