/* Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
Например:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
// Решение церез цикл
/*
int ExponentiationAB(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;

}
Console.WriteLine("Input the value of A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the value of B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = ExponentiationAB(a, b);
Console.WriteLine($"{a} to the degree of {b} is {result}");
*/

/* Задача 2. Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
Например:
452 -> 11
82 -> 10
9012 -> 12
*/
// Решение с циклом for
/*
int SumDigitsOfNumber(int number)
{
    int result = 0;
    for (; number > 0; number /= 10)
    {
        result += number % 10;
    }
    return result;
}
Console.WriteLine("Input any positiv number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of the digits of number {number} is {SumDigitsOfNumber(number)}");
*/

/* Задача 3. Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
Например:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
int[] CreateArrayForUserInput(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input the number with the index {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("\nThe created array is: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Write("Input number of array elements: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArrayForUserInput(sizeArray);
PrintArray(myArray);
*/