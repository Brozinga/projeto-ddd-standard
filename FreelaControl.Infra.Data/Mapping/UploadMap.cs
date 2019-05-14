using FreelaControl.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FreelaControl.Infra.Data.Mapping
{
    internal class UploadMap : EntityTypeConfiguration<Upload>
    {
        public UploadMap()
        {
            ToTable("Uploads");
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnOrder(991);

            Property(x => x.LinkUpload)
                .HasMaxLength(255)
                .HasColumnOrder(992)
                .IsRequired();

            Property(x => x.Status)
                .HasColumnOrder(994)
                .IsRequired();
            
            Property(x => x.DataAlteracao)
                .HasColumnOrder(995)
                .IsOptional();
            
            Property(x => x.DataCadastro)
                .HasColumnOrder(996);

        }
    }
}
