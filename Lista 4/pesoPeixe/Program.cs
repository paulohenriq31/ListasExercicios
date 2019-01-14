using System;

namespace pesoPeixe
{
    class Program
    {
        static void Main(string[] args)
        {
            int P/*PESO*/, E/*EXCESSO*/, M = 0/*MULTA*/; 
            Console.Write("QUAL O PESO DO PEIXE: ");
            P = Convert.ToInt32(Console.ReadLine());

            E = (P - 50);

            if (E <= 0){
                Console.WriteLine("O peso do peixe nao ultrapassou o limite");
                                
            } else if (E > 0){
                Console.WriteLine("O peso do peixe ultrapassou " +E+ "KG do limite");
                M = (E * 4);
                Console.WriteLine("O valor da multa sera de R$"+M+",00");
            }
       }
    }
}
