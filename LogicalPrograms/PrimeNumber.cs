using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void CheckPrimeNumber()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            if (n == 0 || n == 1)
                flag = 1;
            for(int i = 2; i <= n/2; i++)
            {
                if(n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not a Prime Number");
        }
    }
}
