using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs = { "A", "B", "C", "D", "E", "F", "J", "K", "L", "M" };
            int x = 0;
            Console.WriteLine("Set length of array. Input integer pls!");
            int count = Convert.ToInt32(Console.ReadLine());
            HashTable hashTable = new HashTable(count);

            string input;
            do
            {
                Console.WriteLine("o - out, a - add, s - search, q - quit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "o":
                        hashTable.Out();
                        break;
                    case "a":
                        Console.Write(" > ");
                        input = Console.ReadLine();
                        hashTable.add(input);
                        Console.Write(" Ok! Cool! ");
                        break;
                    case "s":
                        Console.Write(" > ");
                        input = Console.ReadLine();
                        int result  = hashTable.find(input);
                        if (result != -1) Console.WriteLine($"I found it! It has key {result} ");
                        if (result == -1) Console.WriteLine($"Seems like nothing has been found, try again or don't bother me");
                        break;
                    default:
                        continue;
                }
            } while (input != "q");

        }
    }
}
