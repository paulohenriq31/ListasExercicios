/* Construa um algoritmo para pagamento de comissão de vendedores de peças automotivas, levando em consideração que a comissão do vendedor será de 5% do total da venda. O usuário deve inserir os seguintes dados abaixo, e ao final o sistema deve mostrar o valor total da compra e o valor da comissão do vendedor: 
    Identificação do vendedor 
    Código da peça 
    Preço unitário da peça 
    Quantidade vendida 
*/
using System;

namespace comissaoVendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorComissao = 0.05, comissao, valorCompra, precoPeca;
            int codigoPeca, quantidadePeca;
            string vendedor;

            Console.Clear();
            Console.Write("Digite o nome do vendedor: ");
            vendedor = Console.ReadLine();

            Console.Write("Qual o codigo da peça: ");
            codigoPeca = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual a quantidade comprada da peça: ");
            quantidadePeca = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o valor unitario da peça: ");
            precoPeca = Convert.ToDouble(Console.ReadLine());

            valorCompra = quantidadePeca*precoPeca;

            comissao = valorComissao * valorCompra;

            Console.WriteLine("O valor total da compra foi de R$ "+valorCompra);
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("E o valor da comissão do vendedor "+vendedor+" foi de R$ " +comissao);


        }
    }
}
