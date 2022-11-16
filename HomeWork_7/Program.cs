//Методы
double[,] CreateDoubleRamdomArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = minValue + (new Random().NextDouble() * (maxValue - minValue));
            array[i, j] = Math.Round(array[i, j], 1);
        }
    }
    return array;
}

void ShowDoubleArray(double[,] array)
{
    Console.WriteLine("The created array: ");
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($"{array[rows, columns]}\t");
        }
        Console.WriteLine();
    }
}
/*
Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Напрмиер:
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
Console.WriteLine("Input a value of rows: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a value of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max element: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateDoubleRamdomArray(str, col, min, max);
ShowDoubleArray(myArray);
*/
/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    Console.WriteLine("The created array: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

/*
Console.WriteLine("Input a value of rows: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a value of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(str,col,min,max);
ShowArray(myArray);
*/
/* 
Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void GetAverageRows(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        int count = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
                if (i == array.GetLength(0))
                sum += array[i, j];
                count++;
        }
        Console.Write($"{sum/count} ");
    }

    
    
}

Console.WriteLine("Input a value of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a value of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(row, column, min, max);
ShowArray(myArray);

GetAverageRows(myArray);