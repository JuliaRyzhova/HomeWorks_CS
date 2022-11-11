// Основные методы
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("The created array is: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

/*
Задача 1: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
Например:
[345, 897, 568, 234] -> 2
*/
/*
int CountEvenArrayItems(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}

Console.Write("Input the size of the array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int min = 100;
int max = 999;

int[] myArray = CreateRandomArray(sizeArray, min, max);
PrintArray(myArray);

Console.Write($"This array has {CountEvenArrayItems(myArray)} even elements");
*/
/*
Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
Например:
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int SumItemsOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Write("Input the size of the array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value of the min element in the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value of the max element in the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(sizeArray, min, max);
PrintArray(myArray);

Console.Write($"The sum of the elements with odd indexes in this array is {SumItemsOddIndex(myArray)}");
*/
/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
Например:
[3 7 22 2 78] -> 76
*/
/*
double[] CreateDoubleRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = minValue + (new Random().NextDouble()) * (maxValue - minValue);
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}
void PrintDoubleArray(double[] array)
{
    Console.Write("The created array is: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

double DiffBetweenMaxMinItems(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    Console.Write($"The min element in this array is {min}\n");
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    Console.Write($"The max element in this array is {max}\n");
    return Math.Round(max - min, 2);
}

Console.Write("Input the size of the array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value of the min element in the array: ");
double min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value of the max element in the array: ");
double max = Convert.ToInt32(Console.ReadLine());

double[] myDoubleArray = CreateDoubleRandomArray(sizeArray, min, max);
PrintDoubleArray(myDoubleArray);

Console.Write($"The difference between the max and min elements is {DiffBetweenMaxMinItems(myDoubleArray)}");
*/

