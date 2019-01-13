using System;

namespace media4notas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double nota1, nota2, nota3, nota4, mediaAluno;
            string aluno;
            
            Console.Write("Escreva o nome do Aluno: ");
            aluno = Console.ReadLine();

            Console.Write("Digite a primeira nota do " + aluno +": ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite a segunda nota do "+ aluno+ ": ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite a terceira nota do " + aluno + ": ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite a quarta nota do " + aluno + ": ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            mediaAluno = (nota1 + nota2 + nota3 + nota4)/4;
            
            Console.Write("A media da nota do aluno: " + aluno + " é: " +mediaAluno);
        }
    }
}
