using System;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            int cont = 0;

            Console.WriteLine("Ingrese el numero de repeticiones que desea: ");
            int Limite = int.Parse(Console.ReadLine());

            while (condition)
            {
                if (cont == Limite)
                    condition = false;

                Console.WriteLine(cont);
                cont++;
            }
        }
    }
}
