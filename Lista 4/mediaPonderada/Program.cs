using System;

namespace mediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno;
            double nota1, nota2, nota3, nota4, notaMedia;

            Console.Write("Qual o nome do aluno: ");
            nomeAluno = Console.ReadLine();

            Console.Write("Digite a nota do 1º bimestre do " +nomeAluno+ ": ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota do 2º bimestre do " +nomeAluno+ ": ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite a nota do 3º bimestre do " +nomeAluno+ ": ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite a nota do 4º bimestre do " +nomeAluno+ ": ");
            nota4 = Convert.ToDouble(Console.ReadLine());
            
            notaMedia = (nota1+(nota2*2)+(nota3*3)+(nota4*4))/10;

            if(notaMedia >= 7){
                Console.WriteLine("A nota do aluno " + nomeAluno+ " foi: " + notaMedia);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Voce Foi APROVADO");
                Console.ResetColor();
                
            } else{
                Console.WriteLine("A nota do aluno " + nomeAluno+ " foi: " + notaMedia);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Voce Foi REPROVADO");
                Console.ResetColor();
            }
        }
    }
}