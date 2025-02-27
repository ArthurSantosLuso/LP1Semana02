using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
        // Variáveis inteiras
        sbyte sbyteMin = sbyte.MinValue;
        sbyte sbyteMax = sbyte.MaxValue;
        Console.WriteLine(sbyteMin);
        Console.WriteLine(sbyteMax);

        byte byteMin = byte.MinValue;
        byte byteMax = byte.MaxValue;
        Console.WriteLine(byteMin);
        Console.WriteLine(byteMax);

        short shortMin = short.MinValue;
        short shortMax = short.MaxValue;
        Console.WriteLine(shortMin);
        Console.WriteLine(shortMax);

        ushort ushortMin = ushort.MinValue;
        ushort ushortMax = ushort.MaxValue;
        Console.WriteLine(ushortMin);
        Console.WriteLine(ushortMax);

        int intMin = int.MinValue;
        int intMax = int.MaxValue;
        Console.WriteLine(intMin);
        Console.WriteLine(intMax);

        uint uintMin = uint.MinValue;
        uint uintMax = uint.MaxValue;
        Console.WriteLine(uintMin);
        Console.WriteLine(uintMax);

        long longMin = long.MinValue;
        long longMax = long.MaxValue;
        Console.WriteLine(longMin);
        Console.WriteLine(longMax);

        ulong ulongMin = ulong.MinValue;
        ulong ulongMax = ulong.MaxValue;
        Console.WriteLine(ulongMin);
        Console.WriteLine(ulongMax);

        // Variáveis de ponto flutuante
        float floatMin = float.MinValue;
        float floatMax = float.MaxValue;
        Console.WriteLine(floatMin);
        Console.WriteLine(floatMax);

        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;
        Console.WriteLine(doubleMin);
        Console.WriteLine(doubleMax);

        decimal decimalMin = decimal.MinValue;
        decimal decimalMax = decimal.MaxValue;
        Console.WriteLine(decimalMin);
        Console.WriteLine(decimalMax);
        }
    }
}
