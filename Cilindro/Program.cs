using System;
using System.Globalization;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Altura do cilindro
            double a = double.Parse(Console.ReadLine());

            // Raio do cilindro
            double r = double.Parse(Console.ReadLine());

            // Calc do volume
            double V = Math.PI * Math.Pow(r,2) * a;

            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "{0:F3}", V));

        }
    }
}
