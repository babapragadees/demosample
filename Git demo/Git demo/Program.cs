﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(addtwonumbers(10,20));
            Console.WriteLine(addtwoproduct(10,100));
            
        }
        #region Add two numbers
        public static int addtwonumbers(int a, int b)
        {
            return a + b;
        }
        #endregion
        #region Add two products
        public static int addtwoproduct(int a, int b)
        {
            return a * b;
        }
       #endregion
    }
}
