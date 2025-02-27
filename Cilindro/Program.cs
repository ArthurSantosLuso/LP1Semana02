using System;
using Microsoft.Win32.SafeHandles;

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
            double V = Math.PI * Math.Pow(r, 2) * a;

            // Calc da Area da superficie
            double Sa = 2 * Math.PI * r * (r + a);

            // Imprimir o Volume do cilindro
            // Testei com os valores 5 (altura) e 10 (raio)... o valor é arredondado...
            Console.WriteLine(V.ToString("0.000"));

            // Imprimir area da superfice do cilindro
            Console.WriteLine(Sa.ToString("0.000"));

        }
    }
}
