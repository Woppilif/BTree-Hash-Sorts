using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
class Tree
{
    public Node Root;//вершина 
    //различные типы конструкторов
    public Tree()
    {
        Root = null;
    }

    public Tree(int key)
    {
        Root = new Node(key);
    }
    //добавление
    public Node Add(int key,Node node)
    {
        if(Root == null)
        {
            Root = new Node(key);
            return Root;
        }
        if(node == null) return new Node(key);

        if (key < node.Info) node.Left = Add(key, node.Left);
        else if (key > node.Info) node.Right = Add(key, node.Right);
        if(key == node.Info)
        {
            node.Appears++;
            return node;
        }
        return node;
    }
    //специально для читаемого вывода
    private string TabMaker(int count)
    {
        string output = string.Empty;
        for (int i = 0; i < count; i++)
            output += "\t";
        return output;
    }
    //вывод в пряом порядке
    public void PreOdrer(Node node,int step=-1)
    {
        if (node == null) return;
        step++;
        Console.WriteLine($"{TabMaker(step)}({node.Info}) [{node.Appears}]");
        PreOdrer(node.Left,step);
        PreOdrer(node.Right,step);
        return;
    }
    // * в симметричном порядке
    public void InOdrer(Node node, int step = -1)
    {
        if (node == null) return;
        step++;
        InOdrer(node.Left, step);
        Console.WriteLine($"{TabMaker(step)}({node.Info}) [{node.Appears}]");
        InOdrer(node.Right, step);
        return;
    }
    // поиск
    public Node Search(int key,Node node)
    {
        if (node == null) return null;
        if (key == node.Info) return node;
        if (key < node.Info) return Search(key, node.Left);
        else if (key > node.Info) return Search(key, node.Right);
        return null;

    }
}
}
