//Создаем массив
using SortingAlgoritms;

Console.WriteLine("Введите количество эелментов");
int n = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[n];

//Иницилизируем элементы массива  
Console.WriteLine("Вводите элементы");
for(int i = 0; i < n; i++)
{
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

//Вывод массива
Console.Write("Массив перед сортировкой:"); 
for(int i = 0; i < n; i++)
{
    Console.Write($"{ Array[i] } ");
}

Console.Write("Выберите алгоритм сортировки: 1 - пузырьковый, 2 - выбором, 3 - вставками");
int numSort = Convert.ToInt32(Console.ReadLine());

switch (numSort)
{
    case 1:
        Bubble.bubbleSort(Array, n);
        break;
    case 2:
        Select.selectSort(Array, n);
        break;
}
    