// Задача 1. Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//Например:
//14212 -> нет
//12821 -> да
//23432 -> да

bool IsPalindrome(int number)
    //if (number => 10000 || number < 100000)
        {
            if (number / 10000 == number % 10)
            {
                if (number / 1000 == number / 10 % 10)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    //return -1;

Console.WriteLine ("Input the five digit number:");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsPalindrome(number);

//if (result == -1)
//Console.WriteLine("Invalid number");
Console.WriteLine(result ? "Tne number is palindrome" : "The number isn't palindrome");

