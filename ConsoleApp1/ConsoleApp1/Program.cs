using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRect, altura, area;

            Console.Write("Ingrese base: ");
            baseRect = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            area = baseRect * altura;
            Console.WriteLine("Área: " + area);
        }
    }
}
