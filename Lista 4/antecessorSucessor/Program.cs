using System;

namespace antecessorSucessor
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero =0, antecessor=0, sucessor=0;
      
            Console.WriteLine("Digite um numero");
            numero = Convert.ToInt32(Console.ReadLine());
            
            antecessor = numero -1;

            sucessor = numero +1;

            Console.WriteLine("O numero escolhido é " + numero + " o antecessor dele é " +antecessor + " e o sucessor é " + sucessor);
        }
    }
}
