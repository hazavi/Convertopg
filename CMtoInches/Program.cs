using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMtoInches
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Convert height in cm to inches");
            Console.Write("Height?: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Fahrenheit: {CmtoInches(height)}");

            Console.ReadKey();
        }

        static double CmtoInches(int height)
        {
            return Math.Round(height / 2.54, 2) ;

        }
    }
    
}
