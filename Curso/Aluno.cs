using System;

namespace Curso
{
    public class Aluno
    {
        private static int contador = 0;
        private int matricula;
        private string nome;
        private Turma turma;

        public int Matricula 
        {
            get
            {
                return matricula;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public Aluno(string nome)
        {
            if (nome.Length < 1)
                throw new ArgumentException("O nome é um campo obrigatório");

            this.nome = nome;
            matricula = ++contador;
        }

        public Turma turmaMatriculado()
        {
            return turma;
        }

        public override string ToString()
        {
            return "Matricula: " + matricula + " nome: " + nome;
        }
    }
}
