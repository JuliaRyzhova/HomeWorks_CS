/*Задача 1. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
Например:
456 -> 5
782 -> 8
918 -> 1
*/
/*
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
*/
/*
int ReturnThirdFigure(int number)
{
    if (number >= 100) //Проверяем на кол-во цифр, если их больше 3, т.е. число больше 100
     {
        int countFigures = 3; //счетчик цифр в числе
        while (number / Convert.ToInt32(Math.Pow(10, countFigures)) > 0) // Цикл будет работать пока не дойдем до трехзначного числа. Math.Pow(10 в степени счетчика цифр)
            countFigures++;
        int thirdFigure = number % Convert.ToInt32(Math.Pow(10, countFigures - 2)) 
        / Convert.ToInt32(Math.Pow(10, countFigures - 3)); // Избавляемся от лишних правых и левых цифр с помощью целочисленного деления и остатка от деления. Чтобы искать другие цифры в числе, например вторую или шестую, то в последней скобке укажим вместо -3, тот номер числа который будем искать, в первой скобке- предпослднее число от искомого)
        return thirdFigure;
     }
     return -1; //Вернем ошибку, если введено меньшее число
}
Console.WriteLine("Input any number ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ReturnThirdFigure(number);


if (result == -1)
    Console.WriteLine("This number hasn't the third figure");
else    
    Console.WriteLine($"The third figure of number {number} is {result}");
*/

/* Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
bool IsWeekEnd(int day)
{
    if (day ==6 || day == 7 ) return true;
    return false;
}

Console.WriteLine("Input a day's number from 1 to 7");
int day = Convert.ToInt32(Console.ReadLine());

bool result = IsWeekEnd(day);

//Вывод булевого итога Console.WriteLine (результат какой? Если true "Text 1" : если False "Text 2")
Console.WriteLine (result ? "The day you input is weekend" : "The day is you input isn't weekend");

*/