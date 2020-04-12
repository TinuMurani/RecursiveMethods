using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RecursiveMethods.Library
{
    public static class Helpers
    {
        public static int MinimumValue(int[] array, int n)
        {
            if (array?.Length == 0)
            {
                return 0;
            }

            if (n == 0)
            {
                return array[0];
            }

            return Math.Min(array[n - 1], MinimumValue(array, n - 1));
        }

        public static int MaximumValue(int[] array, int n)
        {
            if (array?.Length == 0)
            {
                return 0;
            }

            if (n == 0)
            {
                return array[0];
            }

            return Math.Max(array[n - 1], MaximumValue(array, n - 1));
        }

        private const int MaxNumberOfElements = 93;

        public static long[] GenerateFibonacciSequence(int elements)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (elements < 1)
            {
                return new long[] { };
            }
            else
            {
                if (elements > MaxNumberOfElements)
                {
                    // Option 1:
                    // throw exception
                    // throw new ArgumentOutOfRangeException(nameof(elements), $"Max value is {MaxNumberOfElements}");

                    // Option 2:
                    // force max number of elements
                    elements = MaxNumberOfElements;
                }

                long[] result = new long[elements];

                for (int i = 0; i < elements; i++)
                {
                    result[i] = FibonnacciNumber(i);
                }

                //for (int i = 0; i < elements; i++)
                //{
                //    if (i < 2)
                //    {
                //        result[i] = i;
                //    }
                //    else
                //    {
                //        result[i] = result[i - 2] + result[i - 1];
                //    }
                //}
                stopwatch.Stop();
                Console.WriteLine($"{ stopwatch.ElapsedMilliseconds } miliseconds", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.ResetColor();

                return result;
            }
        }

        private static long FibonnacciNumber(int n)
        {
            if (n < 2)
            {
                return n;
            }

            return FibonnacciNumber(n - 2) + FibonnacciNumber(n - 1);
        }

        public static object BinarySearch(int[] array, int valueToFind, int min, int max)
        {
            if (array?.Length == 0 || valueToFind < array[min] || valueToFind > array[max])
            {
                return "[value is not within the array]";
            }

            int middle = (min + max) / 2;

            if (valueToFind == array[middle])
            {
                return middle;
            }
            else if (valueToFind < array[middle])
            {
                return BinarySearch(array, valueToFind, min, middle);
            }
            else
            {
                return BinarySearch(array, valueToFind, middle, max);
            }
        }
    }
}
