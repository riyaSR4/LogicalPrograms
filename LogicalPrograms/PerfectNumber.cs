using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void CheckPerfectNumber()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for(int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine(i);
                    total += i;
                }
            }
            if(num.Equals(total))
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not a Perfect Number");
        }
    }
}
