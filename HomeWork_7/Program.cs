/*
Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Напрмиер:
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double[,] Create2dDoubleRamdomArray(int rows, int columns, int minValue, int maxValue)
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

void Show2dDoubleArray(double[,] array)
{
    Console.WriteLine("The created array: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
/*
Console.WriteLine("Input the number of rows:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns:");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min element:");
int startValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max element:");
int endValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2dDoubleRamdomArray(row, column, startValue, endValue);
Show2dDoubleArray(myArray);
*/
/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
void Show2dArray(int[,] array)
{
    Console.WriteLine("The created array:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
bool IsCorrectIndexInput(int[,] array, int indexRow, int indexColumn)
{
    for (int i = 0; i < array.GetLength(0); i++) //строки
    {
        if (indexRow <= i)
        {
            for (int j = 0; j < array.GetLength(1); j++) //колонки
            {
                if (indexColumn <= j) return true;
            }
        }
    }
    return false;
}
void GetItemIndexInput(int[,] array, int indexRow, int indexColumn)
{
    Console.WriteLine($"The number with indexes [{indexRow}, {indexColumn}]" +
    $" is {array[indexRow, indexColumn]}");
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

Console.WriteLine("Input the position for rows:");
int indexRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the position for columns: ");
int indexColumns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dRandomArray(row, column, startValue, endValue);
Show2dArray(myArray);

if (IsCorrectIndexInput(myArray, indexRows, indexColumns) == true)
    GetItemIndexInput(myArray, indexRows, indexColumns);
else Console.Write($"There is no such number in the array with indexes [{indexRows}, {indexColumns}]");
*/

/* 
Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double[] GetAverageValueColumns(int[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int count = 0;
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
            count++;
        }
        resultArray[i] = Math.Round((sum / count), 1);
    }
    return resultArray;
}

void ShowAverageColumnsArray(double[] array)
{
    Console.WriteLine("The arithmetic mean of each column from source array:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}
/*
Console.WriteLine("Input the number of rows:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns:");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min element:");
int startValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max element:");
int endValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dRandomArray(row, column, startValue, endValue);
Show2dArray(myArray);

double[] newArray = GetAverageValueColumns(myArray);
ShowAverageColumnsArray(newArray);
*/