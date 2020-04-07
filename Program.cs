﻿using System;

namespace MyFirstDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // string place = "Coding Dojo";
            Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");

            // loop from 1 to 5 including 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            // loop from 1 to 5 excluding 5
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int start = 0;
            int end = 5;
            // loop from start to end including end
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
            // loop from start to end excluding end
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }

            // The execution section does not always have to use ++
            for (int i = 1; i < 6; i = i + 1)
            {
                Console.WriteLine(i);
            }

            int i = 1;
            while (i < 6)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            Random rand = new Random();
            for (int val = 0; val < 10; val++)
            {
                //Prints the next random value between 2 and 8
                Console.WriteLine(rand.Next(2, 8));
            }

        }
    }
}
