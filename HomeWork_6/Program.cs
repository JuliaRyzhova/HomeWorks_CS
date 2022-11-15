/*
Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Например:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
int CountPositivNumbers(int m)
{
    int count = 0;
    for (int i = 1; i <= m; i++)
    {
        Console.Write($"Input number {i}: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0) count++;
    }
    return count;
}

Console.WriteLine("How many numbers do you want to input?: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You inputed {CountPositivNumbers(size)} positiv numbers");
*/
/*
Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
Например:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
void InterPoint(double b1, double k1, double b2, double k2)
{
    double x, y;
    if (k1 == k2) Console.WriteLine($"These straight lines have not a intersection point. They are parallel");
    else if ( k1==k2 && b1 == b2) Console.WriteLine($"These straight lines are the same");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        x = Math.Round(x, 1);
        y = k1 * x + b1;
        y = Math.Round(y, 1);
        Console.WriteLine($"These straight lines intersect at a point x = {x} y = {y}");
    }

}
Console.Write("Input a value 'b1': ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value 'k1': ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value 'b2': ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value 'k2': ");
int k2 = Convert.ToInt32(Console.ReadLine());

InterPoint(b1, k1, b2, k2);
*/