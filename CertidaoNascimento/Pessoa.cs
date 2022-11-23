using System;

namespace CertidaoNascimento
{
    public class Pessoa
    {
        private string nome;
        private CertidaoNascimento certidaoNascimento;
        public string Nome { get { return nome; } }
        public CertidaoNascimento CertidaoNascimento { get { return certidaoNascimento; } }

        public Pessoa(string nome)
        {
            if (nome.Length < 1)
                throw new Exception("A pessoa deve possuir um nome.");

            this.nome = nome;
            certidaoNascimento = null;
        }

        public void AssociarCertidao(CertidaoNascimento certidaoNascimento)
        {
            if (this.certidaoNascimento != null) 
                throw new Exception("A pessoa já possui certidão.");
            
            this.certidaoNascimento = certidaoNascimento;
        }
    }
}
