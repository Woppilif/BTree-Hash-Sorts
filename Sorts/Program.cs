using System;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Set length of array. Input integer pls!");
                int count = Convert.ToInt32(Console.ReadLine());
                int[] arr = Generate(count);
                BubbleSort bubbleSort = new BubbleSort(arr);
                foreach (int i in bubbleSort.Sort())
                    Console.WriteLine(i);
                Console.WriteLine($"c {bubbleSort.Comparsion} s {bubbleSort.Shifts}");
                Console.ReadLine();

                InsertionSort insertionSort = new InsertionSort(arr);
                foreach (int i in insertionSort.Sort())
                    Console.WriteLine(i);
                Console.WriteLine($"c {insertionSort.Comparsion} s {insertionSort.Shifts}");
            }
        }

        static int[] Generate(int size)
        {
            Random random = new Random(1111);
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(0, 100);
            return array;
        }
    }
}
