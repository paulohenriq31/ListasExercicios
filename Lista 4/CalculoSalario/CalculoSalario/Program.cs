using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Elabore um algoritmo que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. 
*/
namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            //C = Codigo
            //N = Numero de horas trabalhadas
            //E = Horas Extra

            double C=0, N=0, E=0, salario=0;

            Console.Write("Digite o seu codigo de funcionario: ");
            C = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de horas trabalhadas: ");
            N = Double.Parse(Console.ReadLine());

            //Ganho R$ 10,00/h
            //50 horas semanais

            //escolha caso ultrapaase o limite
            if (N <= 50)
            {
                salario = (N * 10);
                Console.WriteLine("O valor do seu salario será: R$ " + salario + ",00");
                Console.WriteLine("Não ouve hora extra: " + E);


            }
            else
            {
                salario = (50 * 10);
                Console.WriteLine("O valor do seu salario será: R$ " + salario + ",00");

                N = (N - 50);
                E = (N * 20);
                Console.WriteLine("Terá um acrecimo no valor de R$ " + E + ",00 por " + N + " hora(s) extras");
                
            }
           
            Console.ReadKey();


        }
    }
}
