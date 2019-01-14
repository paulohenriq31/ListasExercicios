using System;

namespace maior3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, n3;
            Console.WriteLine("Digite 3 numeros para ver qual o maior:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            
            if (n1 > n2 && n1 > n3){
                Console.WriteLine("O maior é o " + n1);
            } else if (n2 > n1 && n2 > n3){
                Console.WriteLine("O maior numero é o " +n2);
            } else if (n3 > n1 && n3 > n2){
                Console.WriteLine("O maior numero é o " +n3);
            } else {
                Console.WriteLine("Os 3 numeros são iguais");
            }
        }
    }
}
