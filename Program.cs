using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Frist Number:");
            int prime = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Other Number:");
            int prime1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime Resualt:");

            int H = 0;
            for (int i = prime; i <= prime1; i++ )
            {
                for (int w = 1; w <= i; w++)

                {
                    if (i % w == 0)
                        w++;
                }
                if (H == 2)
                    Console.WriteLine("i");
                H = 0;
            }
        }
    }
}
