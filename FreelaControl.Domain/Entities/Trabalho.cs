using System;
using System.Collections.Generic;

namespace FreelaControl.Domain.Entities
{
    public class Trabalho : BaseEntity
    {

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Prazo { get; set; }
        public decimal? ValorHora { get; set; }
        public decimal? ValorFechado { get; set; }
        public DateTime? DataEntrega { get; set; }
        public virtual List<Upload> Uploads { get; set; }
    }
}
