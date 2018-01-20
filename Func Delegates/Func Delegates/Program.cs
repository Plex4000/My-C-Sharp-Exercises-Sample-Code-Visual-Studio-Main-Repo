﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegates
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);
        }
    }
}
