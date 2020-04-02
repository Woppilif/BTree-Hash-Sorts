using System;
using System.Collections.Generic;
using System.Text;

namespace Sorts
{
    class InsertionSort
    {
        private int[] Array;
        public int Comparsion; //к-во сравнений
        public int Shifts; //к-во перестановок
        public InsertionSort(int[] array)
        {
            Array = new int[array.Length];
            array.CopyTo(Array, 0);
        }

        public int[] Sort()
        {
            int temp,j;
            for (int i = 0; i < Array.Length ; i++)
            {
                temp = Array[i];
                j = i - 1;
                while((j>=0) && (Array[j] > temp))
                {
                    Array[j + 1] = Array[j];
                    j -= 1;
                    Shifts++;
                    Comparsion++;
                }
                Comparsion++;
                Array[j + 1] = temp;

            }
            return Array;
        }
    }
}
