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

                // Verify if the numbers are not compatible
                if (valorInicio < 2 || valorStep < 2 || valorStep >= valorInicio)
                {
                    // Throw the error message
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    continue;
                }

                // verify if the 'valorInicio' is not divisible by 'valorStep'
                if (valorInicio % valorStep != 0)
                {
                    // Throw the error message
                    Console.WriteLine("Start not divisible by step. Try again.");
                    continue;
                }
                
                // Cicle to print step by step till 0
                for (int aux = valorInicio; aux >= 0; aux--)
                {
                    // Verificcation to make sure the next number is a step
                    if (aux % valorStep != 0)
                    {
                        continue;
                    }
                    else
                    {
                        // Is is a step, then print it
                        Console.WriteLine(aux);
                    }

                }
                
                // If everything goes alright, finish the program.
                break;

            } while (true);

        }
    }
}
