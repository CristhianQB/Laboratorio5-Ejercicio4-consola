using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_Ejercicio4_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nùmero lìmite: ");
            int limite = int.Parse(Console.ReadLine());

            Console.WriteLine("Escoja una opción: ");
            Console.WriteLine("1: Números pares");
            Console.WriteLine("2: Números impares");
            Console.WriteLine("3: Factorial");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1 :
                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 2 == 0)
                        { 
                            Console.Write(i + ", ");
                        }
                    }
                    break;

                case 2 :
                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 2 != 0)
                        { 
                            Console.Write(i + ", ");
                        }
                    }
                    break;

                case 3:
                    double resul = 1;
                    for (double i = 1; i <= limite ; i++)
                    {
                        resul = resul * i;
                    }
                        Console.WriteLine("El producto es " + resul);

                    break;
            }

            Console.ReadLine();
        }
    }
}
