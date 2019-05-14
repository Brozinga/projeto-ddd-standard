using System;

namespace FreelaControl.Domain.Entities
{
    public class Upload : BaseEntity
    {
        public int Id { get; set; }
        public string LinkUpload { get; set; }
        public virtual Trabalho Trabalho { get; set; }
    }
}
