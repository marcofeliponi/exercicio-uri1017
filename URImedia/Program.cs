using System;
using System.Globalization;

namespace URImedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int H, KMH;
            double L;

            H = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            KMH = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            L = (H * KMH) / 12.0;

            Console.WriteLine(L.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
