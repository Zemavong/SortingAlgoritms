using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoritms
{
    internal class Select
    {
        public static void selectSort(int[] Array, int n)
        {
            //Сортировка вставками
            Console.Write("Нажмите Enter чтобы начать сортировку");
            Console.ReadLine();
            
            for (int left = 0; left < n; left++)
            {
                int min = left;
                for (int i = left; i < Array.Length; i++)
                {
                    if (Array[i] < Array[min]) {
                        min = i;
                    }
                }

                int buffer = Array[left];
                Array[left] = Array[min];
                Array[min] = buffer;
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