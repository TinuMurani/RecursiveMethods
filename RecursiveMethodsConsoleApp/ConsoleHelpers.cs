using RecursiveMethods.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecursiveMethodsConsoleApp
{
    public static class ConsoleHelpers
    {
        private static int ReadNumber(string message, int maxAttempts, bool allowNegative, int defaultValue)
        {
            int attemptsCount = 1;
            bool isNumber = false;

            while (!isNumber)
            {
                Console.Write(message);
                string text = Console.ReadLine();

                isNumber = int.TryParse(text, out int number);

                if (isNumber && (allowNegative || (number >= 0)))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"'{text}' is not a valid number, try again ({maxAttempts - attemptsCount} attempts remaining) ...", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ResetColor();
                    isNumber = false;
                }

                attemptsCount++;

                if (attemptsCount > maxAttempts)
                {
                    Console.WriteLine($"Max attempts count exceeded, asuming {defaultValue} as default value ...", Console.ForegroundColor = ConsoleColor.DarkRed);
                    Console.ResetColor();
                    return defaultValue;
                }
            }

            return defaultValue;
        }

        public static int FindArrayElement()
        {
            int elementValue = ReadNumber($"Value of element to find = ", 3, true, 0);

            return elementValue;
        }

        public static long[] ReadFibonacciFromConsole(string arrayName)
        {
            int length = ReadNumber($"{arrayName} Length=", 3, false, 0);

            long[] array = Helpers.GenerateFibonacciSequence(length);
            
            return array;
        }

        public static int[] ReadArrayFromConsole(string arrayName)
        {
            int length = ReadNumber($"{arrayName} Length=", 3, false, 0);

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = ReadNumber($"{arrayName} Element[{i}]=", 3, true, 0);
            }

            return array;
        }

        public static int[] ReadSortedArrayFromConsole(string arrayName)
        {
            int length = ReadNumber($"{arrayName} Length=", 3, false, 0);

            int startNumber = ReadNumber($"First element=", 3, true, 0);

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = i + startNumber;
            }

            return array;
        }

        public static void PrintIntArray(string arrayName, int[] array)
        {
            string arrayElements = string.Join(", ", array ?? new int[] { });

            Console.WriteLine($"{arrayName} = [{arrayElements}]", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();
        }

        public static void PrintLongArray(string arrayName, long[] array)
        {
            string arrayElements = string.Join(", ", array ?? new long[] { });

            Console.WriteLine($"{arrayName} = [{arrayElements}]", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();
        }
    }
}
