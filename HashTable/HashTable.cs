using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class HashTable
    {
        string[] data = null;
        //создаем экземпляр с нужной размерностью
        public HashTable(int size)
        {
            this.data = new string[size];
        }
        //Конвертация строк в набор символов
        public int convertStringToBytesTwo(string input)
        {
            int output = 0;
            byte[] barr = ASCIIEncoding.ASCII.GetBytes(input);
            for (int i = 0; i < barr.Length; i++)
                output += Convert.ToInt32(barr[i]);
            return output;
        }
        //Поиск пока не нашли или не нашли пустую строку или к-во шагов не привысит 
        //величину массива иначе бесконечный цикл
        public int find(string input)
        {
            int key;
            int step = 0;
            int value = convertStringToBytesTwo(input);
            while (true)
            {
                key = (((value % data.Length) + step) % data.Length) + 1;
                if (key == data.Length) key = 0;
                if (data[key] == input) break;
                if (data[key] == "") return -1;
                if (step >= data.Length) return -1;
                step++;
            }
            Console.WriteLine($"I made {step} steps with searching key {input}");
            return key;
        }
        //аналогичные комменты как и для find
        public int add(string input)
        {
            int key = 0;
            int step = 0;
            int value = convertStringToBytesTwo(input);
            while (true)
            {
                
                key = (((value % data.Length) + step) % data.Length) + 1;
                if (key == data.Length) key = 0;
                if (data[key] == null)
                {
                    data[key] = input;
                    break;
                    //return key;
                }
                if (step >= data.Length) return -1;
                step++;
            }
            Console.WriteLine($"I made {step} steps with adding key {input}");
            return key;
        }
        //простой вывод
        public void Out()
        {
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);
        }
    }
}
