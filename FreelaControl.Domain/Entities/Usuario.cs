using System;

namespace FreelaControl.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public Usuario()
        {
            Id = Guid.NewGuid();
            DataCadastro = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Identificador { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string TelefoneUm { get; set; }
        public string TelefoneDois { get; set; }
        public virtual int NivelAcessoId { get; set; }
        public virtual NivelAcesso NivelAcesso { get; set; }
    }
}
