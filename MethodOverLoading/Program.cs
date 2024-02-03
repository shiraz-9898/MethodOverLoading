using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();

            Console.WriteLine(c1.Sum(8.9, 6));

            Console.WriteLine(c1.Sum(8, 4));

            Console.ReadKey();
        }
    }

    public class Calculation
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Sum(int x, double y)
        {
            return x + y;

        }

        public double Sum(double x, int y)
        {
            return x + y;

        }
    }
}
