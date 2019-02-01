using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imparParPositivoNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Informe um numero qualquer: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0 && numero > 0)
            {
                Console.WriteLine("O valor Informado é positivo e par");
            }
            else if(numero % 2 != 0 && numero > 0)
            {
                Console.WriteLine("O valor infomado é positivo e impar");
            }
            else if (numero % 2 == 0 && numero < 0)
            {
                Console.WriteLine("O valor informado é negativo e par");
            }
            else if (numero % 2 != 0 && numero < 0)
            {
                Console.WriteLine("O valor informado é negativo e impar");
            }
            else
            {
                Console.WriteLine("ERRO 404!!!");
            }

            Console.ReadKey();

        }
    }
}
