using System;

namespace diferenciaQuadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, diferencia, aoQuadrado;

            Console.Write("Dige un numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            diferencia = a-b;

            aoQuadrado = diferencia*diferencia;

            Console.WriteLine("A diferencia entre "+a+" e "+b+" é de " + diferencia);

            Console.WriteLine("O valor de " + diferencia + " ao quadrado é de "+aoQuadrado);
            



        }
    }
}
