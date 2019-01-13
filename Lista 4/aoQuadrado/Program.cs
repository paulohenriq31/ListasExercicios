/*Efetuar a leitura de um valor numérico inteiro e apresentar o resultado do valor lido elevado ao quadrado.
 */
using System;

namespace aoQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, elevado;
            
            Console.WriteLine("Digite um numero");
            valor = Convert.ToInt32(Console.ReadLine());

            elevado = valor*valor;

            Console.WriteLine("O valor de "+valor+" elevado ao quadradro é de "+elevado);

        }
    }
}
