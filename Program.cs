﻿using System;
using CsharpFundamentals.Math;

namespace CsharpFundamentals
{
    class Program // Arrays in C#
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            
            var flags = new bool[3];
            flags[0] = true;
            
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            
            var names = new string[3] { "John", "Doe", "Jane" };
            
        }
    }
}

