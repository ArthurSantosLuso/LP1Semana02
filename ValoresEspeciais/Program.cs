using System;
using System.Security.Cryptography.X509Certificates;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
        // Variáveis inteiras
        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(sbyte.MaxValue);

        Console.WriteLine(byte.MinValue);
        Console.WriteLine(byte.MaxValue);

        Console.WriteLine(short.MinValue);
        Console.WriteLine(short.MaxValue);

        Console.WriteLine(ushort.MinValue);
        Console.WriteLine(ushort.MaxValue);

        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);

        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);

        Console.WriteLine(ulong.MinValue);
        Console.WriteLine(ulong.MaxValue);

        // Variáveis de ponto flutuante
        Console.WriteLine(float.MinValue);
        Console.WriteLine(float.MaxValue);

        Console.WriteLine(double.MinValue);
        Console.WriteLine(double.MaxValue);

        Console.WriteLine(decimal.MinValue);
        Console.WriteLine(decimal.MaxValue);

        Console.WriteLine(1.2/0);
        Console.WriteLine(-1.2/0);
        Console.WriteLine(0.0/0.0);

        // Declarar um var com o valor maximo do tipo unit
        uint a = uint.MaxValue;

        //Imprimir o resultado do overflow do tipo unit
        Console.WriteLine(a + 1);

        //Imprimir o resultado do overflow do tipo float

        float b = float.MaxValue;
        float overflowPositive = b * 2;
        Console.WriteLine(overflowPositive);

        b = float.MinValue;
        float overflowNegative = b * 2;
        Console.WriteLine(overflowNegative);

        }
    }
}
