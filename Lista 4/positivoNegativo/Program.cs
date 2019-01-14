using System;

namespace positivoNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Digite um numero");
            n1 = Convert.ToDouble(Console.ReadLine());

            if (n1 < 0){
                Console.WriteLine("O numero " +n1+ " é negativo");
            } else if (n1 > 0){
                Console.WriteLine("O numero " +n1+ " é positivo");
            } else {
                Console.WriteLine("O numero " +n1+ " é nulo");
            }
        }
    }
}
