﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;

            int j = i ?? 0;

            Console.WriteLine(j);
        }
    }
}
