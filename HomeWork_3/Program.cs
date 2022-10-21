// Задача 1. Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//Например:
//14212 -> нет
//12821 -> да
//23432 -> да

// Решение для любого числа:
/*
bool IsPalindrom (int number)
{
    int countFigures = 1; // кол-во цифр
    int reservNumber = number; // переменная для просчета кол-ва цифр
    while (reservNumber / 10 > 0)
    {   
        reservNumber = reservNumber / 10;
        countFigures ++;
    }
    while (number/ Convert.ToInt32(Math.Pow(10, countFigures -1)) == number % 10) return true;
        number = number / 10 % (countFigures -2); //отсекаем первую и последнюю цифру
        countFigures --;
    return false;     
}                

Console.Write("Input any number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsPalindrom(number);

Console.WriteLine(result ? $"The number {number} is palindrome" : $"The number {number} isn't palindrome");
*/
// Решение для 5-значного числа
/*
bool IsPalindrom(int number)
{
        if (number / Convert.ToInt32(Math.Pow(10, 4)) != number % 10) return false;
        if (number / Convert.ToInt32(Math.Pow(10, 3)) % 10 == number / 10 % 10) return true;
        return false;
    // Еще одно возможное решение. Но тот вариант, который я оставила выполнит меньше
    // операций, если на первом if выпадет false, то прогр-а прекратит работу и
    // не будет сравнивать следующие числа.
    //if (number / Convert.ToInt32(Math.Pow(10, 4)) == number % 10)
    //if (number / Convert.ToInt32(Math.Pow(10, 3)) % 10 == number / 10 % 10) return true;
    //return false;
}        
           
Console.WriteLine ("Input the five digit number:");
int number = Convert.ToInt32(Console.ReadLine());

bool result= IsPalindrom(number);

if (number >= 10000 && number < 100000)
    Console.WriteLine(result ? $"The number {number} is palindrome" : $"The number {number} isn't palindrome");
else    
    Console.WriteLine("Invalid number. Try again");
*/


// Задача 2. Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.
//Например:
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// Формула нах-я расстояния √ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2
/*
double IsDistance(double x, double y, double z, double x2, double y2, double z2)
{
    double dis = Convert.ToDouble(Math.Sqrt
    (Convert.ToDouble(Math.Pow(x2 - x,2)) + 
    (Convert.ToDouble(Math.Pow(y2 - y, 2)) + 
    (Convert.ToDouble(Math.Pow(z2 - z, 2))))));
    return dis;
}

Console.WriteLine("Input value x of A");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input value y of A");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input value z of A");
double z = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input value x of B");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input value y of B");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input value z of B");
double z1 = Convert.ToDouble(Console.ReadLine());

double result = IsDistance(x, y, z, x1, y1, z1);
result = Math.Round(result, 2);

Console.WriteLine($"The distance between the specified points A and B is {result}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
//Например:
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

// Решение с использованием метода
/*
void Cube(int number)
{
    int current = 1;
    while(current <= number)
    {
        Console.Write((Math.Pow(current, 3)) + " ");
        current ++;
    }
}    
Console.Write("Input any positiv number: ");
int number = Convert.ToInt32(Console.ReadLine());

Cube(number);
*/
// Решение с использованием цикла for
/*
void Cube(int number)
{
    for (int count = 1; count <= number; count ++)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
    }
}

Console.Write("Input any positiv number: ");
int number = Convert.ToInt32(Console.ReadLine());

Cube(number);
*/

// Решение с использованием массива
/*
void FillArray(int [] cube)
{
    int lenght = cube.Length;
    int index = 1;
    while (index < lenght)
    {
        cube[index] =Convert.ToInt32(Math.Pow(index, 3));
        index++;
    }
}
void PrintArray(int [] newCub)
{
    int count = newCub.Length; //обозначили кол-во эл-ов массива
    int position = 1; // тот же индекс, просто чтобы не повторятся обозначили как position
    while (position < count)
    {
        Console.WriteLine(newCub[position]);
        position++;
    }
}

Console.WriteLine("Input any positiv number");
int lenght = Convert.ToInt32(Console.ReadLine()) + 1;
 // new int [10] - оператор создающий новый массив из "N" эл-ов
int [] array = new int [lenght];

FillArray(array); // метод, заполняющий массив

Console.WriteLine("===>"); 

PrintArray(array); //метод, выводящий массив на печать


Console.WriteLine();
*/