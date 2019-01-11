using System;

namespace media30Alunos
{
    class Program
    {
        static void Main(string[] args)
        {

            double nota1, nota2, nota3, nota4, notaMedia;
            //estou usando a variavel "i" como um contador 
            int quantAluno, i=1;
            string nomeAluno;

            Console.Write ("Qual a quantidade de alunos: ");
            quantAluno = Convert.ToInt32(Console.ReadLine());
            
            while(i <= quantAluno){
                Console.Write("Qual o nome do "+i+"º aluno: ");
                nomeAluno = Console.ReadLine();

                Console.Write("Digite a nota do 1º bimestre do " +nomeAluno+ ": ");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a nota do 2º bimestre do " +nomeAluno+ ": ");
                nota2 = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Digite a nota do 3º bimestre do " +nomeAluno+ ": ");
                nota3 = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Digite a nota do 4º bimestre do " +nomeAluno+ ": ");
                nota4 = Convert.ToDouble(Console.ReadLine());

                notaMedia = (nota1+nota2+nota3+nota4)/4;

                if(notaMedia <5){
                    Console.WriteLine("O aluno "+nomeAluno+" ficou com "+notaMedia+" de media" );
                    Console.WriteLine("O aluno foi REPROVADO");
                }else{
                    Console.WriteLine("O aluno "+nomeAluno+" ficou com "+notaMedia+" de media" );
                    Console.WriteLine("O aluno foi APROVADO");
                }
                //vai esperar 3 segundos para execultar o proximo comando
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                //a cada vez que ele passa aqui adiciona mais um na contagem
                i++;
            }
        }
    }
}
