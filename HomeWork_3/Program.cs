// Задача 1. Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//Например:
//14212 -> нет
//12821 -> да
//23432 -> да

bool IsPalindrom(int number)
{

    if (number / Convert.ToInt32(Math.Pow(10, 4)) == number % 10)
    if (number / Convert.ToInt32(Math.Pow(10, 3)) % 10 == number / 10 % 10) return true;
    return false;
}        
           
Console.WriteLine ("Input the five digit number:");
int number = Convert.ToInt32(Console.ReadLine());

bool result= IsPalindrom(number);

Console.WriteLine(result ? "Tne number is palindrome" : "The number isn't palindrome");


// Задача 3. Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
//Например:
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

// Решение без использования метода
/*
Console.WriteLine("Input any number from 1 to 10");
int number = Convert.ToInt32(Console.ReadLine());

    int current = 1;
    while(current <= number)
    {
        Console.Write((Math.Pow(current, 3)) + ", ");
        current ++;
    }
*/
// Решение с использованием метода и массива
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

Console.WriteLine("Input any nubmer from 1 to 10");
int lenght = Convert.ToInt32(Console.ReadLine()) + 1;
 // new int [10] - оператор создающий новый массив из "N" эл-ов
int [] array = new int [lenght];

FillArray(array); // метод, заполняющий массив

Console.WriteLine("===>"); 

PrintArray(array); //метод, выводящий массив на печать


Console.WriteLine();
*/