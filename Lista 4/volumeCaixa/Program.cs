/*Elaborar um programa que calcule e apresente o valor do volume de uma caixa retangular, utilizando a fórmula VOLUME = COMPRIMENTO * LARGURA * ALTURA
*/
using System;

namespace volumeCaixa
{
    class Program
    {
        static void Main(string[] args)
        {

            double COMPRIMENTO, LARGURA, ALTURA;
            
            Console.Write("Digite o comprimento da caixa em cm: ");
            COMPRIMENTO = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o largura da caixa em cm: ");
            LARGURA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da caixa em cm: ");
            ALTURA = Convert.ToDouble(Console.ReadLine());

            Console.Write("O volume da caixa é de " +(COMPRIMENTO*LARGURA*ALTURA));



        }
    }
}
