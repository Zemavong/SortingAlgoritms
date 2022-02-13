using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritms
{
    internal class Bubble
    {
        public static void bubbleSort(int[] Array, int n)
        {
            //Сортировка
            Console.Write("Нажмите Enter чтобы начать сортировку");
            Console.ReadLine();
            int buffer = 0;
            for (int i = Array.Length - 1; i >= 1; i--)
                for (int k = 0; k < i; k++)
                {
                    if (Array[k] > Array[k + 1])
                    {
                        buffer = Array[k + 1];
                        Array[k + 1] = Array[k];
                        Array[k] = buffer;
                    }
                }

            //Результат
            Console.WriteLine("Массив после сортировки:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ Array[i] } ");
            }
        }
    }
}
