﻿using System;

namespace MathSolution
{
    class Program
    {
        private Math math= new Math();
        static void Main(string[] args)
        {
            Console.WriteLine("1+1="+math.Add(1,1));
        }
    }
}
