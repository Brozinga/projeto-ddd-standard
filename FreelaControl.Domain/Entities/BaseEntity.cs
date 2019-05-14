using System;

namespace FreelaControl.Domain.Entities
{
    public class BaseEntity
    {
        public DateTime? DataAlteracao { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
