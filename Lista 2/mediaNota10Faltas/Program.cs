using System;

namespace mediaNota10Faltas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno;
            int faltas;
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

            Console.Write("Digite a quantidade de faltas " +nomeAluno+ ": ");
            faltas = Convert.ToInt32(Console.ReadLine());            
            
            notaMedia = (nota1+nota2+nota3+nota4)/4;

            Console.Clear();

            if ( faltas > 10 & notaMedia >= 5){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O aluno " + nomeAluno + " Teve a media de " +notaMedia+ " e o total de "+faltas+" faltas");
                Console.WriteLine("O aluno " +nomeAluno+ " foi reprovado por faltas");
                Console.ResetColor();

            } else if ( faltas > 10 & notaMedia <5){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O aluno " + nomeAluno + " Teve a media de " +notaMedia+ " e o total de "+faltas+" faltas");
                Console.WriteLine("O aluno " +nomeAluno+ " foi reprovado");
                Console.ResetColor();
            } else if (faltas <= 10 & notaMedia <5 ){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O aluno " + nomeAluno + " Teve a media de " +notaMedia+ " e o total de "+faltas+" faltas");
                Console.WriteLine("O aluno " +nomeAluno+ " esta de Recuperação");
                Console.ResetColor();

            } else if (faltas <= 10 & notaMedia >= 5){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O aluno " + nomeAluno + " Teve a media de " +notaMedia+ " e o total de "+faltas+" faltas");
                Console.WriteLine("O aluno " +nomeAluno+ " foi aprovado");
                Console.ResetColor();
            }
        }
    }
}
