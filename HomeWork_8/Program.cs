/*
Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] Create2dRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void Show2dArray(int[,] array, string info)
{
    Console.WriteLine(info);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void SortingMinMaxItemArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

/*
Console.WriteLine("Input the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min element: ");
int startValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max element: ");
int endValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dRandomArray(row, column, startValue, endValue);
Show2dArray(myArray, "Сreated array:");

SortingMinMaxItemArray(myArray);
Show2dArray(myArray, "Sorted array: ");
*/
/*
Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int MinSumRows(int[,] array)
{
    int index = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) minSum = sum;
        else
        if (sum < minSum)
        {
            minSum = sum;
            index = i;
        }
    }
    return index;
}

Console.WriteLine("Input the number of rows (should be more than columns): ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min element: ");
int startValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max element: ");
int endValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dRandomArray(row, column, startValue, endValue);
Show2dArray(myArray, "Сreated array:");

Console.Write($"Minimum sum of elements in a row with index {MinSumRows(myArray)}");
