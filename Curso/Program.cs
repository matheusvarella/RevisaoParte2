using System;

namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso("Sistemas");

            Turma turma1 = new Turma(1);
            Turma turma2 = new Turma(2);

            curso.CriarTurma(turma1);
            curso.CriarTurma(turma2);

            Aluno wilson = new Aluno("Wilson");
            Aluno roberto = new Aluno("Roberto");
            Aluno gustavo = new Aluno("Gustavo");
            Aluno roberta = new Aluno("Roberta");
            Aluno francisca = new Aluno("Francisca");

            curso.MatricularAluno(wilson);
            curso.MatricularAluno(roberto);
            curso.MatricularAluno(gustavo);
            curso.MatricularAluno(roberta);
            curso.MatricularAluno(francisca);

            curso.MatricularAlunoTurma(turma1, wilson);
            curso.MatricularAlunoTurma(turma1, roberto);
            curso.MatricularAlunoTurma(turma2, gustavo);
            curso.MatricularAlunoTurma(turma2, roberta);
            curso.MatricularAlunoTurma(turma2, francisca);

            curso.ListarAlunosTurma(turma1);
            Console.WriteLine("-----------------------------------");
            curso.ListarAlunosTurma(turma2);

            curso.ListarTurmasEAlunos();
        }
    }
}
