using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = new int[6] { 1,9,7,5,6,8};

            foreach (int g in arr)
            {
                Console.WriteLine(g);
                // display original array
            }

            Console.WriteLine("\nAfter Sort:");
            Array.Sort(arr);

            foreach (int g in arr)
            {
                Console.WriteLine(g);
                // display sorted array
            }

            Console.WriteLine("\nB sorts between :");
        }
    }
}
