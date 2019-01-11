using System;

namespace experienciaCandidato
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoExperiencia;
            Console.WriteLine("Quantos anos de experiencia tem o candidato: ");
            anoExperiencia = Convert.ToInt32(Console.ReadLine());

            if (anoExperiencia <= 2){
                Console.WriteLine("O candidato tem o nivel JUNIOR");

            } else if (anoExperiencia > 2 & anoExperiencia <= 5){
                Console.WriteLine("O candidato tem o nivel PLENO");

            } else{
                Console.WriteLine("O candidato tem o nivel SÊNIOR");
            }
        }
    }
}
