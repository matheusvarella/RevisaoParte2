using System;

namespace Exercicio1.Models
{
    public partial class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public float RendaMensal { get; private set; }
        public char EstadoCivil { get; private set; }
        public int Dependetes { get; private set; }

        public Cliente(string nome, string cpf, DateTime dataNascimento, float rendaMensal, char estadoCivil, int dependetes)
        {


            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            RendaMensal = rendaMensal;
            EstadoCivil = estadoCivil;
            Dependetes = dependetes;
        }
    }
}
