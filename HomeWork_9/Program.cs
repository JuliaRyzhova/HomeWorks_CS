/*
Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void PositivNumbers(int number)
{
    if (number >= 1)
    {
        Console.Write(number + " ");
        PositivNumbers(number - 1);
    }

}
/*
Console.Write("Input any number: ");
int num= Convert.ToInt32(Console.ReadLine());
PositivNumbers(num);
*/

/* 
Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumOfPositivNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
        return SumOfPositivNumbers(firstNumber, secondNumber + 1) + secondNumber;
    else if (secondNumber > firstNumber)
        return SumOfPositivNumbers(firstNumber + 1, secondNumber) + firstNumber;
    else
        return firstNumber;
}
/*
Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"The sum of positiv numbers between {num1} and {num2} is {SumOfPositivNumbers(num1, num2)}");
*/
/*
Задача 3.  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AckermannFunction (int m, int n)
{
  
    if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    else if (m == 0)
        return n + 1;
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}
/*
Console.Write("Input the first number (m): ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number (n): ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"The result of Ackermann function A({num1},{num2}) is {AckermannFunction(num1,num2)}");
*/