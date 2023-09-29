using Exercicio3_fix;
using System;

namespace Exercicio3Fix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do aluno: ");

            Console.Write("Nota 1:");
            aluno.Nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2:");
            aluno.Nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3:");
            aluno.Nota3 = double.Parse(Console.ReadLine());
        
            if (aluno.NotaFinal() >= 60)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!!");
                double falta = aluno.NotaFinal() - 60;
                Console.WriteLine($"Faltaram {falta}");
            }
        }
    }
}