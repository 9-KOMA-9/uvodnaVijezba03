using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaViježba03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write(" unesite prvi broj: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" unesite drugi broj: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write(" unesite treci broj: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" prvi upisani broj je: " + x);
            Console.WriteLine(" drugi upisani broj je: " + y);
            Console.WriteLine(" treći upisani broj je: " + z);

            if (x > y && x > z)
            {
                if ((y * y) + (z * z) == (x * x))
                {
                    Console.WriteLine();
                    Console.Write(" trokut je pravokutan ");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write(" trokut nije pravokutan ");
                }

            }

            if (y > x  && y > z)
            {
                if ((x * x) + (z * z) == (y * y))
                {
                    Console.WriteLine();
                    Console.Write(" trokut je pravokutan ");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write(" trokut nije pravokutan ");
                }

            }

            if (z > y && z > x)
            {
                if ((y * y) + (x * x) == (z * z))
                {
                    Console.WriteLine();
                    Console.Write(" trokut je pravokutan ");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write(" trokut nije pravokutan ");
                }

            }

            Console.ReadKey();
        }
    }
}
