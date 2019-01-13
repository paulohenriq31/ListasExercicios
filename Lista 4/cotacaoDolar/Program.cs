/*Conversão da moeda em Dolar para Real */

using System;

namespace cotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, real = 3.71, conversaoDolar;

            Console.WriteLine("Este programa foi feito no dia 12/01/2018 com o valor do Dolar a R$ 3,71");
            //Vai esperar 3 segundos para execultar o proximo codigo
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            Console.Write("Qual a quantia em Dolar $ ");
            dolar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            conversaoDolar = (dolar*real);

            Console.Write("O valor de $ " +dolar+ " Dolar em Reais é de R$ " +conversaoDolar);
            Console.ReadKey();
            Console.Clear();





        }
    }
}
