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
    return index + 1;
}
/*
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

Console.Write($"Minimum sum of elements in {MinSumRows(myArray)} row");
*/
/*
Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

bool PossibleResultMatrix(int[,] array1, int[,] array2)
{
return (array1.GetLength(1) == array2.GetLength(0));
}

// Принцип работы- умножаем первую строку 1-й матрицы на 1-ый столбец второй матрицы
int[,] ResultMatrix(int[,] array1, int[,] array2)
{
    int[,] resultMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    resultMatrix[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }return resultMatrix;   
}
/*
Console.WriteLine("Input the number of rows for first matrix: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns for first matrix: ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min element: ");
int startValue1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max element: ");
int endValue1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input the number of rows for second matrix: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns for second matrix: ");
int column2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min element: ");
int startValue2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max element: ");
int endValue2 = Convert.ToInt32(Console.ReadLine());

int[,] firstMartix = Create2dRandomArray(row1, column1, startValue1, endValue1);
Show2dArray(firstMartix, "First matrix");


int[,] secondMatrix = Create2dRandomArray(row2, column2, startValue2, endValue2);
Show2dArray(secondMatrix, "Second matrix");

if(PossibleResultMatrix(firstMartix,secondMatrix) == true)
{
    int[,] resMatrix = ResultMatrix(firstMartix, secondMatrix);
    Show2dArray(resMatrix, "The resulting matrix: ");
}
else Console.Write("Error. The number of columns of the first matrix must " + 
"be equal to the number of rows of the second matrix!!!");
*/

/*
Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/