using System;

namespace Somar2
{
    class Program
    {
        static void Main(string[] args)
        {
            //VAR
            int valor1, valor2, valorTotal;

            Console.WriteLine("Digite o 1º numero");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 2º numero");
            valor2 = Convert.ToInt32(Console.ReadLine());

            valorTotal = (valor1 + valor2) * valor1;

            Console.WriteLine("O valor do (" + valor1 + " + " + valor2 + ") * " + valor1);

        }
    }
}
