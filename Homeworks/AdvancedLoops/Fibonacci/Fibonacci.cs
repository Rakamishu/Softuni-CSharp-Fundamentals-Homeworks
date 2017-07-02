﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine(1);
                return;
            }

            int f0 = 0;
            int f1 = 1;
            int fSum = 0;

            for (int i = 0; i < n; i++)
            {
                fSum = f0 + f1;
                f0 = f1;
                f1 = fSum;
            }
            Console.WriteLine(fSum);
        }
    }
}
