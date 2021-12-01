using System;

namespace API.Models
{
    public class FormasPagamento
    {
        public FormasPagamento() => CriadoEm = DateTime.Now;
        public int CategoriaId { get; set; }
        public FormaPag FormaPag { get; set; }

        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }
    }

    public enum FormaPag {
        DEBITO,
        CREDITO,
        BOLETO

    }
}