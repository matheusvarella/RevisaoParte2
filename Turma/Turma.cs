using System;
using System.Collections.Generic;
using System.Linq;

namespace Turma
{
    public class Turma
    {
        public List<Aluno> Alunos { get; private set; }

        public Turma() 
        {
            Alunos = new List<Aluno>();
        }

        public void InserirAluno(Aluno aluno)
        {
            if(Alunos.Contains(aluno))
                throw new ArgumentException("O aluno já está na turma.");

            Alunos.Add(aluno);
            Alunos = Alunos.OrderBy(x => x.Nome).ToList();
        }

        public void RemoverAluno(Aluno aluno)
        {
            if(!Alunos.Contains(aluno)) 
                throw new ArgumentException("O aluno não está nessa turma!");

            Alunos.Remove(aluno);
        }

        public void LancarNotaP1(Aluno aluno, double nota)
        {
            if (!Alunos.Contains(aluno))
                throw new ArgumentException("O aluno não está nessa turma!");

            var index = Alunos.IndexOf(aluno);

            Alunos[index].LancarNotaP1(nota);
        }

        public void LancarNotaP2(Aluno aluno, double nota)
        {
            if (!Alunos.Contains(aluno))
                throw new ArgumentException("O aluno não está nessa turma!");

            var index = Alunos.IndexOf(aluno);

            Alunos[index].LancarNotaP2(nota);
        }

        public void ImprimirAlunosComNotasFinais()
        {
            if(Alunos.Count < 1)
                throw new ArgumentException("Você não possui alunos na turma");

            foreach(var aluno in Alunos)
            {
                Console.WriteLine(aluno.ToString());
            }
        }

        public void ImprimirMediaP1()
        {
            double media = 0.0;

            foreach(var aluno in Alunos)
            {
                media += aluno.P1;
            }

            media = media / Alunos.Count;

            Console.WriteLine("A média das notas da P1 é: " + media);
        }

        public void ImprimirMediaP2()
        {
            double media = 0.0;

            foreach (var aluno in Alunos)
            {
                media += aluno.P2;
            }

            media = media / Alunos.Count;

            Console.WriteLine("A média das notas da P2 é: " + media);
        }

        public void ImprimirMediaNotaFinal()
        {
            double media = 0.0;

            foreach (var aluno in Alunos)
            {
                media += aluno.CalcularNotaFinal();
            }

            media = media / Alunos.Count;

            Console.WriteLine("A média das notas da NF é: " + media);
        }

        public void ImprimirAlunoMelhorNotaFinal() 
        {
            var melhorAluno = Alunos.OrderByDescending(x => x.CalcularNotaFinal()).First();

            Console.WriteLine("O aluno com melhor nota final é: " + melhorAluno.ToString());
        }
    }
}
