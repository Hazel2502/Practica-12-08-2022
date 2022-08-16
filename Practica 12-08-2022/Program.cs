using System;

namespace Practica_12_08_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nota promedio");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= object && nota <= 10)
            {
                if (nota >= 6)
                {
                    Console.WriteLine("Aprobado");
                }
                else if (nota >= 5)
                {
                    Console.WriteLine("Preposion");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            else
            {
                Console.WriteLine("La nota no es correcta");
            }
        }
    }    
}
