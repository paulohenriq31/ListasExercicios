using System;

namespace media5NotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno;
            Double nota1, nota2, nota3, nota4, nota5, mediaAluno;

            Console.Write("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite as 5 notas do aluno " + nomeAluno);
            nota1 = Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());
            nota3 = Convert.ToDouble(Console.ReadLine());
            nota4 = Convert.ToDouble(Console.ReadLine());
            nota5 = Convert.ToDouble(Console.ReadLine());

            mediaAluno = (nota1 + nota2 + nota3 + nota4 + nota5)/5;
            
            Console.WriteLine("A media da nota do Aluno "+nomeAluno+ " é: " + mediaAluno);
        }
    }
}
