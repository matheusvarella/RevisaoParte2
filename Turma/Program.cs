using System;

namespace Turma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turma turma = new Turma();
            Aluno wilson = new Aluno("Wilson", 1);
            Aluno roberto = new Aluno("Roberto", 2);
            Aluno gustavo = new Aluno("Gustavo", 3);
            Aluno roberta = new Aluno("Roberta", 4);
            Aluno francisca = new Aluno("Francisca", 5);

            turma.InserirAluno(wilson);
            turma.InserirAluno(roberto);
            turma.InserirAluno(gustavo);
            turma.InserirAluno(roberta);
            turma.InserirAluno(francisca);
            turma.RemoverAluno(gustavo);
            //turma.InserirAluno(wilson);

            turma.LancarNotaP1(wilson, 10);
            turma.LancarNotaP2(wilson, 5);


            turma.ImprimirAlunosComNotasFinais();
            turma.ImprimirMediaP1();
            turma.ImprimirMediaP2();
            turma.ImprimirMediaNotaFinal();

            turma.ImprimirAlunoMelhorNotaFinal();
        }
    }
}
