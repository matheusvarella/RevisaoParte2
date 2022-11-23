using System;

namespace Turma
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public int Matricula { get; private set; }
        public double P1 { get; private set; }
        public double P2 { get; private set; }

        public Aluno(string nome, int matricula) 
        {
            if(nome.Length < 2)
                throw new ArgumentNullException("O aluno deve possuir nome com pelo menos 2 caracteres.");

            if(matricula < 1)
                throw new ArgumentException("O número da matricula não pode ser menor a 1.");

            Nome = nome;
            Matricula = matricula;
            P1 = 0;
            P2 = 0;
        }

        public void LancarNotaP1(double p1)
        {
            if(p1 < 0 || p1 > 10)
                throw new ArgumentException("A nota deve ser um valor de 0 a 10.");

            P1 = p1;
        }

        public void LancarNotaP2(double p1)
        {
            if(p1 < 0 || p1 > 10)
                throw new ArgumentException("A nota deve ser um valor de 0 a 10.");

            P2 = p1;
        }

        public double CalcularNotaFinal()
        {
            var notaFinal = (P1 + P2) / 2;

            return notaFinal;
        }

        public override string ToString()
        {
            return "Aluno: " + Nome + " matrícula: " + Matricula + " nota final: " + CalcularNotaFinal();
        }
    }
}
