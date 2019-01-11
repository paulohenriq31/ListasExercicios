using System;

namespace estoqueMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int estoqueMedio, estoqueMinino, estoqueMaximo;
            
            Console.WriteLine("Digite a quantida MINIMA do seu estoque");
            estoqueMinino = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade MAXIMA do seu estoque");
            estoqueMaximo = Convert.ToInt32(Console.ReadLine());

            estoqueMedio = (estoqueMinino + estoqueMaximo) / 2;

            Console.WriteLine("O valor da media do seu estoque é: " + estoqueMedio);

        }
    }
}