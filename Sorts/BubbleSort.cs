using System;
using System.Collections.Generic;
using System.Text;

namespace Sorts
{
    class BubbleSort
    {
        private int[] Array;
        public int Comparsion; //к-во сравнений
        public int Shifts; //к-во перестановок
        public BubbleSort(int[] array)
        {
            Array = new int[array.Length];
            array.CopyTo(Array, 0);
        }

        public int[] Sort()
        {
            int temp;
            for (int i = 1; i < Array.Length - 1; i++)
            {
                for (int j = Array.Length - 1; j>= i; j--)
                {
                    if (Array[j - 1] > Array[j]) // если текущий элемент меньше предыдущего
                    {
                        temp = Array[j - 1]; // меняем их местами
                        Array[j - 1] = Array[j];
                        Array[j] = temp;
                        Shifts++;
                    }
                    Comparsion++;
                }
            }

            return Array;
        }
    }
}
