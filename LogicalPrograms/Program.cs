using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter input to be executed\n 1.Fibonacci Series\n 2.Exit\n");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Fibonacci fibonacci = new Fibonacci();
                        fibonacci.FibonacciSeries();
                        break;
                    case 2:
                        flag = false;
                        break;

                }
            }
        }
    }
}
