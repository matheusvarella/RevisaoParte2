using System;

namespace CertidaoNascimento
{
    public class CertidaoNascimento
    {
        private DateTime dataEmissao;
        private Pessoa pessoa;
        public DateTime DataEmissao { get { return dataEmissao; } }
        public Pessoa Pessoa { get { return pessoa; } }
        
        public CertidaoNascimento(Pessoa pessoa)
        {
            dataEmissao = DateTime.Now;
            this.pessoa = pessoa;
            this.pessoa.AssociarCertidao(this);
        }
    }
}
