using System;

namespace festaInfantil
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadePessoa, valorTotal;

            Console.Write("Qual a quantidade de pessoas para a festa: ");
            quantidadePessoa = Convert.ToInt32(Console.ReadLine());

            if (quantidadePessoa <= 100 ){
                valorTotal = (quantidadePessoa*35);
            }else{
                valorTotal = (quantidadePessoa*45);
            }

            Console.WriteLine("O valor total do orçamento é R$ " + valorTotal +",00");
            
        }
    }
}
