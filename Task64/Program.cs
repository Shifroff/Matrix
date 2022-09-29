// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = Prompt("Enter N = ");

int Prompt(string message)
{
    Console.Write(message);
    string data = Console.ReadLine();
    return Convert.ToInt32(data);
}

string NumberRecursion(int a, int b)
{
    if (a>=b) return $"{a} "+ NumberRecursion(a-1,b);
    else return string.Empty;
}

Console.WriteLine(NumberRecursion(N,1));
