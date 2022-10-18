
/* Задача 1: Напишите программу, которая на вход принимает два числа и 
выдаёт, какое число большее, а какое меньшее.
Например:
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.Write("Input the first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int maxNumber = firstNumber;

if  (secondNumber > maxNumber)
    Console.WriteLine($"Max number is {secondNumber}");
else
    Console.WriteLine($"Max number is {maxNumber}");


Задача 2: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
Например:
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.Write("Input the first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int maxNumber = firstNumber;

if (secondNumber > maxNumber)
    maxNumber = secondNumber;
if (thirdNumber > maxNumber)
    maxNumber = thirdNumber;
Console.Write($"Max number is {maxNumber}");

Задача 3:Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.Write("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    Console.Write($"Number {number} is even,is divisible by 2 without remainder ");
else 
    Console.Write($"Number {number} is not even");
*/
/*
Задача 4: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
Console.Write("Input any positiv integer number ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;

while(current <= number)
{
    if (current % 2 == 0)
        Console.Write(current + " ");
    current += 2;
}
*/
 
//                                  Методы
//Задача 1: Напишите программу, которая на вход принимает два числа и 
//выдаёт, какое число большее, а какое меньшее. Решение с испо-ем метода.
//Например:
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*
int MaxNumber(int firstNumber, int secondNumber)
{
    int max = firstNumber;
    if (secondNumber > max) return secondNumber;
    else return max;
}

Console.WriteLine("Input the first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int max = MaxNumber(firstNumber, secondNumber);
Console.WriteLine($"Bigger number is {max}");
*/
//Задача 2: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел. С испол-ем метода.
//Например:
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
/*
int MaxNumber(int firstNumber, int secondNumber, int thirdNumber)
{
    int max = firstNumber;
    if (secondNumber > max) max = secondNumber;
    if (thirdNumber > max) max = thirdNumber;
    return max;
}

Console.WriteLine("Input the first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the third number");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = MaxNumber(firstNumber, secondNumber, thirdNumber);

Console.Write($" Max number is {max}");
*/
/*
Задача 3:Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка). С исп-ем метода.
Например:
4 -> да
-3 -> нет
7 -> нет
*/
/*
bool IsEven (int number)
{
    if (number % 2 == 0) return true;
    return false;
}
Console.WriteLine("Input any number");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsEven(number);

Console.WriteLine(result ? $"Number {number} is even" : $"Number {number} isn't even");

*/