using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int valorInicio;
            int valorStep;

            do
            {
                // Ask fot both numbers
                Console.Write("Start number: ");
                valorInicio = int.Parse(Console.ReadLine());

                Console.Write("Step number: ");
                valorStep = int.Parse(Console.ReadLine());

                // Verify if the numbers are compatible
                if (valorInicio < 2 || valorStep < 2 || valorStep >= valorInicio)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }

                if (valorInicio % valorStep != 0)
                {
                    Console.WriteLine("Start not divisible by step. Try again.");
                    continue;
                }
                
                // Cicle to print step by step till 0
                for (int aux = valorInicio; aux >= 0; aux--)
                {
                    if (aux % valorStep != 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(aux);
                    }

                }
                
                // If everything goes alright, finish the program.
                break;

            } while (true);

        }
    }
}
