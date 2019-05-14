using FreelaControl.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FreelaControl.Infra.Data.Mapping
{
    internal class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuarios");

            HasKey(x => x.Id);
            HasIndex(x => x.Email)
                .IsUnique();

            HasRequired(x => x.NivelAcesso)
                .WithMany()
                .HasForeignKey(x => x.NivelAcessoId);

            Property(x => x.Id)
                .HasColumnOrder(991);

            Property(x => x.Nome)
                .HasMaxLength(100)
                .HasColumnOrder(992)
                .IsRequired();

            Property(x => x.Identificador)
                .HasMaxLength(20)
                .HasColumnOrder(993)
                .IsRequired();

            Property(x => x.Email)
                .HasMaxLength(100)
                .HasColumnOrder(994)
                .IsRequired();

            Property(x => x.Senha)
                .HasMaxLength(255)
                .HasColumnOrder(995)
                .IsRequired();

            Property(x => x.NivelAcessoId)
                .HasColumnOrder(996)
                .IsRequired();

            Property(x => x.Rua)
                .HasMaxLength(150)
                .HasColumnOrder(997)
                .IsRequired();

            Property(x => x.Numero)
                .HasMaxLength(50)
                .HasColumnOrder(998)
                .IsRequired();

            Property(x => x.Bairro)
                .HasMaxLength(100)
                .HasColumnOrder(999)
                .IsRequired();

            Property(x => x.Cidade)
                .HasMaxLength(100)
                .HasColumnOrder(1000)
                .IsRequired();

            Property(x => x.Estado)
                .HasMaxLength(100)
                .HasColumnOrder(1001)
                .IsRequired();

            Property(x => x.Cep)
                .HasMaxLength(50)
                .HasColumnOrder(1002)
                .IsRequired();

            Property(x => x.Complemento)
                .HasMaxLength(150)
                .HasColumnOrder(1003)
                .IsOptional();

            Property(x => x.TelefoneUm)
                .HasMaxLength(20)
                .HasColumnOrder(1004)
                .IsOptional();

            Property(x => x.TelefoneDois)
                .HasMaxLength(20)
                .HasColumnOrder(1005)
                .IsOptional();

            Property(x => x.DataAlteracao)
                .HasColumnOrder(1006);

            Property(x => x.Status)
                .HasColumnOrder(1007)
                .IsOptional();

            Property(x => x.DataCadastro)
                .HasColumnOrder(1008);

        }
    }
}
