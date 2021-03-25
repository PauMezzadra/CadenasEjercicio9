using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasEjercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "";
            do
            {
                Console.WriteLine("Ingrese un texto y yo se lo mostraré en mayúsculas");
                texto = Console.ReadLine().ToUpper();
                if (texto == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
                else
                {
                    Console.WriteLine($"Su frase es: {texto}");
                }
            } while (texto == "");

            Console.ReadKey();
        }
    }
}
