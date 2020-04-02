using System;

namespace BinaryTree
{
    class Program
    {
    static void Main(string[] args)
    {
        Tree tree = new Tree();//создаем дерево
        Random random = new Random();//вызываем рандом
        int x = 0;
        Console.WriteLine("Please, set count of Roots");
        int count = Convert.ToInt32(Console.ReadLine());//указываем количество вершин нашего дерева
        for (int i =0;i<count;i++)//заполняем
            tree.Add(random.Next(0, 200), tree.Root);

        string input;
        do//меню
        {
            Console.WriteLine("o - out, a - add, s - search, q - quit");
            input = Console.ReadLine();
            switch(input)
            {
                case "o":
                    Console.WriteLine("[Preorder]");
                    tree.PreOdrer(tree.Root);
                    Console.WriteLine("[Inorder]");
                    tree.InOdrer(tree.Root);
                    break;
                case "a":
                    Console.Write(" > ");
                    x = Convert.ToInt32(Console.ReadLine());
                    tree.Add(x, tree.Root);
                    Console.Write(" Ok! Cool! ");
                    break;
                case "s":
                    Console.Write(" > ");
                    x = Convert.ToInt32(Console.ReadLine());
                    var result = tree.Search(x,tree.Root);
                    if (result != null) Console.WriteLine($"I found it: {result.Info} [{result.Appears}]");
                    if (result == null) Console.WriteLine($"Seems like nothing has been found, try again or don't bother me");
                    break;
                default:
                    continue;
            }
        } while (input != "q");
    }
    }
}
