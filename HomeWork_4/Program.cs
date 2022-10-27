/* Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
Например:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
// Решение церез цикл

int MathPower(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a; 
    }
        return result;
    
}
Console.WriteLine("Input value of A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input value of B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = MathPower(a, b);
Console.WriteLine($"{a} to the degree of {b} is {result}");

// Решение без цикла
/*
int MathPower(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a, b));
    return result;
}

Console.WriteLine("Input value of A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input value of B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = MathPower(a, b);
Console.WriteLine($"{a} to the degree of {b} is {result}");
*/

/* Задача 2. Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
Например:
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int Sum(int number)
{
    int result = 0;
    while (number >= 0 )
    {
        result += number % 10;
        number /= 10;
    }
    return result += number;
}
Console.WriteLine("Input any positiv number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Sum(number);
Console.WriteLine($"The sum of the digits of {number} is {result}");
*/

/* Задача 3. Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
Например:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/