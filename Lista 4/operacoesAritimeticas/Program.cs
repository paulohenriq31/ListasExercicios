using System;

namespace operacoesAritimeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.Write("Dige o primeiro numero: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a soma de " +a+" + "+b+" é igual a "+(a+b));

            Console.WriteLine("a subtração de " +a+" - "+b+" é igual a "+(a-b));

            Console.WriteLine("a multiplicação de " +a+" * "+b+" é igual a "+(a*b));

            Console.WriteLine("a divisão de " +a+" / "+b+" é igual a "+(a/b));

        }
    }
}
