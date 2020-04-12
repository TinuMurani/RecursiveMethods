using RecursiveMethods.Library;
using System;
using System.Diagnostics;

namespace RecursiveMethodsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Gasirea minimului si maximului
            int[] array = ConsoleHelpers.ReadArrayFromConsole("IntArray");

            ConsoleHelpers.PrintIntArray("IntArray", array);

            Console.WriteLine($"Minimum value of the arrays is: { Helpers.MinimumValue(array, array.Length) }.", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();

            Console.WriteLine($"Maximum value of the arrays is: { Helpers.MaximumValue(array, array.Length) }.", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.ResetColor();
            */

            /* Fibonacci -- am inclus si un cronometru (probabil nu cel mai exact) in metoda
             * de generare a sirului lui Fibonacci pentru a testa timpii de procesare
             * !!! la 45 de elemente ale sirului mie imi returneaza rezultatul in putin peste 33,000 milisecunde
             
            long[] fibonacciArray = ConsoleHelpers.ReadFibonacciFromConsole("Fibonacci Sequence");

            ConsoleHelpers.PrintLongArray("Fibonacci numbers", fibonacciArray);

            long[] fibonacciSecondArray = ConsoleHelpers.ReadFibonacciFromConsole("Fibonacci Sequence");

            ConsoleHelpers.PrintLongArray("Fibonacci numbers", fibonacciSecondArray);
            */

            int[] sortedArray = ConsoleHelpers.ReadSortedArrayFromConsole("SortedArray");

            ConsoleHelpers.PrintIntArray("SortedArray", sortedArray);

            int value = ConsoleHelpers.FindArrayElement();

            Console.WriteLine($"Value { value } is at position: { Helpers.BinarySearch(sortedArray, value, 0, sortedArray.Length - 1)}", Console.ForegroundColor = ConsoleColor.Blue);
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
