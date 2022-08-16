using System;

namespace CALCULADORA
{
    class Program
    {
        static void Main(string[] args)
        {
            string Respuesta = "";
            do
            {
                int Num1, Num2;
                int R = 0;

                //Calculadora con operaciones basicas
                Console.WriteLine("Seleccione unas de las operaciones que desea realizar: ");

                Console.WriteLine(" SUMA");
                Console.WriteLine(" RESTA");
                Console.WriteLine(" MULTIPLICACION ");
                Console.WriteLine(" DIVISION ");
                Respuesta = Console.ReadLine();
                string eleccion = Convert.ToString(Respuesta);

                Console.WriteLine("Ingrese dos numero con el que desea realizar las operaciones");
                Console.Write("Num1:  ");
                Num1 = int.Parse(Console.ReadLine());
                Console.Write("Num2: ");
                Num2 = int.Parse(Console.ReadLine());
                Console.ReadLine();
                switch (eleccion)
                {
                    case "SUMA":
                        Console.WriteLine("El resultado de la SUMA es: ");
                        R = Num1 + Num2;
                        Console.WriteLine("{0} + {1} = {2}", Num1, Num2, R);
                        break;
                    case "RESTA":
                        Console.WriteLine("El resultado de la RESTA  es:");
                        R = Num1 - Num2;
                        Console.WriteLine("{0} - {1} = {2}", Num1, Num2, R);
                        break;
                    case "MULTIPLICACION":
                        Console.WriteLine("El resultado de la MULTIPLICACION es:");
                        R = Num1 * Num2;
                        Console.WriteLine("{0} * {1} = {2}", Num1, Num2, R);
                        break;
                    case "DIVISION":
                        Console.WriteLine("El resultado de la DIVISION  es:")
                        R = Num1 / Num2;
                        Console.WriteLine("{0} * {1} = {2}", Num1, Num2, R);

                        break;
                }
                Console.Write("¿Desea Continuar? S/N: ");
                Respuesta = Console.ReadLine();
            }
            while (Respuesta == "s" || Respuesta == "S");
        }
    }
}
