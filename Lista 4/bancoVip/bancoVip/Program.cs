using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Elabore um programa que classifique os clientes de um banco em VIP ou NORMAL. Clientes regulares que adquirirem mais de 1 Milhão e que tem um bom histórico de pagamento ou que estão conosco a mais de 20 anos devem ser considerados VIP caso contrário é um cliente NORMAL. */
namespace bancoVip
{
    class Program
    {
        static void Main(string[] args)
        {
            string cliente, saldo, historicoPagamento;
            int anos;

            Console.WriteLine("===============");
            Console.WriteLine("  Banco Paulo");
            Console.WriteLine("===============");

            Console.Write("Nome Cliente: ");
            cliente = Console.ReadLine();

            Console.Write("O cliente Possui mais de 1 Milhão (s/n): ");
            saldo = Console.ReadLine();
            saldo = saldo.ToLower();

            Console.Write("O cliente " + cliente + " teve algum tipo de atraso nos ultimos anos(s/n): ");
            historicoPagamento = Console.ReadLine();
            historicoPagamento = historicoPagamento.ToLower();

            Console.Write("A quantos anos o Sr(a) " + cliente + " é nosso cliente: ");
            anos = Convert.ToInt32(Console.ReadLine());

            if (saldo == "s" || historicoPagamento == "n" || anos >= 20)
            {
                Console.WriteLine($"O cliente {cliente} é um cliente VIP");
            }else{
                Console.WriteLine($"O cliente {cliente} Infelismente não é um Cliente VIP");
            }



            Console.ReadKey();





        }
    }
}
