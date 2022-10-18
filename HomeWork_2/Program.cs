/*Задача 1. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
Например:
456 -> 5
782 -> 8
918 -> 1

int ReturnSecondFigure(int number)
{
    int cutThirdFigure = number / 10;
    int secondFigure = cutThirdFigure % 10;
    
    return secondFigure;
}

Console.WriteLine("Input three - digit number");
int number = Convert.ToInt32(Console.ReadLine());

int result = ReturnSecondFigure(number);
Console.Write($"The second figure of number {number} is {result}");
*/

/* 
Задача 2. Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
Например:
645 -> 5
78 -> третьей цифры нет
32679 -> 6

int ReturnThirdFigure(int number)
{
    if (number >= 100)
     {
        int countFigures = 3;
        while (number / Convert.ToInt32(Math.Pow(10, countFigures)) > 0)
            countFigures++;
        int thirdFigure = number % Convert.ToInt32(Math.Pow(10, countFigures - 2)) 
        / Convert.ToInt32(Math.Pow(10, countFigures - 3));
        return thirdFigure;
     }
     else return -1;
}
Console.WriteLine("Input any number ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ReturnThirdFigure(number);

if (result == -1)
    Console.WriteLine("This number hasn't the third figure");
else    
    Console.WriteLine($"The third figure of number {number} is {result}");


// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

bool IsWeekEnd(int day)
{
    if (day ==6 || day == 7 ) return true;
    return false;
}

Console.WriteLine("Input a day's number from 1 to 7");
int day = Convert.ToInt32(Console.ReadLine());

bool result = IsWeekEnd(day);

Console.WriteLine($"The day you input is weekend. It's {result} ");
*/