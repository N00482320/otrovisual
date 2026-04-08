using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prom4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, promedio;
            Console.Write("Nota 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            if (promedio >= 11)
                Console.WriteLine("Aprobado con: " + promedio);
            else
                Console.WriteLine("Desaprobado con: " + promedio); 
            Console.ReadKey();


        }
    }
}
