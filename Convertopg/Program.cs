using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertopg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert KiloMeter to Meter");
            Console.Write("Km: ");
            int kmtom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Meter: {KMtoMconverter(kmtom)}");

            Console.ReadKey();
        }

        static float KMtoMconverter(int kmtom)
        {
            return kmtom * 1000;

        }

    }
}
