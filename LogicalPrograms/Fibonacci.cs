using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Fibonacci
    {
        public void FibonacciSeries()
        {
            int a = 0, b = 1;
            int c = a + b;
            Console.WriteLine("Enter the limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci Series : " + a + " " + b + " ");
            for (int i = 3; i <= limit; i++)
            {
                Console.Write(c + " ");
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}
