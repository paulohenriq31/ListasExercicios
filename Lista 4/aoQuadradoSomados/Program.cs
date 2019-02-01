/*Pegar quatro numeros elevar ao quadrado e somar */

using System;

namespace aoQuadradoSomados
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, somaTotal;
            Console.WriteLine("Digite o valor dos quatro numeros");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            n4 = Convert.ToDouble(Console.ReadLine());

            n1 = n1*n1;
            n2 = n2*n2;
            n3 = n3*n3;
            n4 = n4*n4;

            somaTotal = (n1+n2+n3+n4);
            //Console.Clear() serve para limpar a tela
            Console.Clear();
            Console.WriteLine("O valor total é de " +somaTotal);
        }
    }
}
