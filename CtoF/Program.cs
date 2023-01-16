using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtoF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Convert Celsius to Fahrenheit");
                Console.Write("Celsius: ");
                int ctof = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Fahrenheit: {CtoF(ctof)}");

                Console.ReadKey();
            }

            static float CtoF(int ctof)
            {
                return (ctof * 9/5) + 32 ;

        }
    }
}
