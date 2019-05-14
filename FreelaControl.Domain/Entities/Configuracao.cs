namespace FreelaControl.Domain.Entities
{
    public class Configuracao : BaseEntity
    {
        public int Id { get; set; }
        public decimal ValorCobradoMensal { get; set; }
        public int DiaTrabalhadosMes { get; set; }
        public int HorasTrabalho { get; set; }
    }
}
