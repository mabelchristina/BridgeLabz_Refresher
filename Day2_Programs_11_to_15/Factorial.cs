﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programs_11_to_15
{
    internal class Factorial
    {
        public int fact(int n)
        {
            int f = 1;
            for(int i=2;i<=n;i++)
            {
                f = f * i;
            }
            return f;
        }
    }
}
