using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Node
    {
        public int Info { get; set; } //ключ
        public int Appears { get; set; }//количество повторений
        public Node Left { get; set; }//левый потомок
        public Node Right { get; set; }//правый потомок

        //конструктор
        public Node(int key)
        {
            Info = key;
            Appears = 1;
            Left = Right = null;
        }
    }
}
