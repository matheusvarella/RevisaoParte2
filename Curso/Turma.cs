using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso
{
    public class Turma
    {
        private int codigo;
        private List<Aluno> alunos;

        public int Codigo { get { return codigo; } }
        public List<Aluno> Alunos { get { return alunos; } }

        public Turma(int codigo)
        {
            if (codigo < 1)
                throw new ArgumentException("O código deve ser maior do que 0");

            this.codigo = codigo;
            this.alunos= new List<Aluno>();
        }

        public void AdicionarAlunoTurma(Aluno aluno)
        {
            if (alunos.Contains(aluno))
                throw new ArgumentException("O aluno já pertence a essa turma.");

            alunos.Add(aluno);
            alunos = alunos.OrderBy(x => x.Nome).ToList();
        }

        public void RemoverAlunoTurma(Aluno aluno)
        {
            if (!alunos.Contains(aluno))
                throw new ArgumentException("O aluno não pertence a essa turma.");
        }

        public bool VerificarAlunoTurma(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        public void ImprimirAlunos()
        {
            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno.ToString());
            }
        }

        public override string ToString()
        {
            return "Turma de código: " + codigo;
        }
    }
}
