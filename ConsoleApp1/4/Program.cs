using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);

            Console.WriteLine("Ingrese tu edad");
            double edad = double.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
            double prom;
            Console.WriteLine("Calcule el promedio ");
            Console.WriteLine("Ingresen nota 1");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresen nota 2");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresen nota 3");
            double n3 = double.Parse(Console.ReadLine());
            prom = n1 + n2 + n3;
            Console.WriteLine("EL promedio es" + prom);
        }
    }
}
