﻿using System;

namespace Generics
{
    class program
    {
        public static void toPrint(int[] inputArray)
        {
            foreach (int element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------");
        }



        public static void toPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine("-----------------------");
        }

        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine("-----------------------");
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'a', 'b', 'c', 'd' };
            program.toPrint(intArray);
            program.toPrint(doubleArray);
            program.toPrint(charArray);
        }
    }
}