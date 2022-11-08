/*
Задача 1: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
Например:
[345, 897, 568, 234] -> 2
*/
/*
int[] CreateArrayPositivNumbers(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("The created array is: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int CountEvenArrayItems(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Input the size of the array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value of the min element in the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value of the max element in the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArrayPositivNumbers(sizeArray, min, max);
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
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("The created array is: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumItemsUnevenIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
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

Console.Write($"The sum of the elements with uneven indexes in this array is {SumItemsUnevenIndex(myArray)}");
*/
/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
Например:
[3 7 22 2 78] -> 76
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("The created array is: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int DifferenceBetweenMaxMinItems(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    Console.Write($"The min element in this array is {min}\n");
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    Console.Write($"The max element in this array is {max}\n");
    return max - min;
}

Console.Write("Input the size of the array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value of the min element in the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value of the max element in the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(sizeArray, min, max);
PrintArray(myArray);

Console.Write($"The difference between the max and min elements is {DifferenceBetweenMaxMinItems(myArray)}");
*/

