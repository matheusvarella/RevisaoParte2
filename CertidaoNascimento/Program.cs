using System;

namespace CertidaoNascimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = new Pessoa("Luiz");
            var pessoa2 = new Pessoa("Augusto");

            var certidaoNascimento1 = new CertidaoNascimento(pessoa1);
            var certidaoNascimento2 = new CertidaoNascimento(pessoa2);
            var certidaoNascimento3 = new CertidaoNascimento(pessoa2);
        }
    }
}
