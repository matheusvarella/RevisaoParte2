using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso
{
    internal class Curso
    {
        private string nome;
        private List<Turma> turmas;
        private List<Aluno> alunos;

        public string Nome 
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Length > 0)
                    throw new ArgumentException("O nome do curso deve ter pelo menos 1 caracter.");
                
                nome = value;
            } 
        }

        public Curso(string nome)
        {
            if (nome.Length < 1)
                throw new Exception("O nome do curso não pode ser nulo");

            this.nome = nome;
            this.turmas= new List<Turma>();
            this.alunos= new List<Aluno>();
        }

        public void CriarTurma(Turma turma)
        {
            var procurarTurma = turmas.Find(x => x.Codigo == turma.Codigo);

            if (procurarTurma != null)
                throw new Exception("Já existe uma turma com esse código.");

            turmas.Add(turma);
            turmas = turmas.OrderBy(x => x.Codigo).ToList();
        }

        public void RemoverTurma(Turma turma)
        {
            if (turma.Alunos.Count > 0)
                throw new Exception("A turma não pode ser fechada porque possui alunos"); 
        }

        public void MatricularAluno(Aluno aluno) 
        {
            if (alunos.Contains(aluno))
                throw new Exception("O aluno já está matriculado no curso.");

            alunos.Add(aluno);
        }

        public void RemoverAlunoCurso(Aluno aluno)
        {
            if (aluno.turmaMatriculado() != null)
                throw new Exception("O aluno está matriculado em uma turma.");

            alunos.Remove(aluno);
        }

        public void MatricularAlunoTurma(Turma turma, Aluno aluno)
        {
            if (!turmas.Contains(turma)) 
                throw new Exception("A turma não existe.");

            if (!alunos.Contains(aluno))
                throw new Exception("O aluno não está matriculado no curso.");

            foreach(var turmaTestar in turmas)
            {
                if (turmaTestar.VerificarAlunoTurma(aluno))
                    throw new Exception("Aluno já está matriculado em outra turma.");
            }

            var index = turmas.IndexOf(turma);

            turmas[index].AdicionarAlunoTurma(aluno);
        }

        public void ListarAlunosTurma(Turma turma)
        {
            if (!turmas.Contains(turma))
                throw new Exception("Turma não existe.");

            var index = turmas.IndexOf(turma);

            turmas[index].ImprimirAlunos();
        }

        public void ListarTurmasEAlunos()
        {
            foreach(var turma in turmas)
            {
                if (turma.Alunos.Count > 0)
                {
                    Console.WriteLine(turma.ToString());
                    turma.ImprimirAlunos();
                }
            }
        }
    }
}
