//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


int m = Prompt("The Ackermann Function (A(m,n))please enter m = ");
int n = Prompt("The Ackermann Function (A(m,n))please enter n = ");

Console.WriteLine(recursion(m,n));

int recursion(int m, int n) 
{       //Ниже буквально расписана функция Аккермана 

        // Базовый случай
        if (m == 0) 
        {
            return n + 1;
        } // Шаг рекурсии / рекурсивное условие
        else if (n == 0 && m > 0) 
        {
            return recursion(m - 1, 1);
        } // Шаг рекурсии / рекурсивное условие
        else 
        {
            return recursion(m - 1, recursion(m, n - 1));
        }
    }

int Prompt(string s)
 {
    Console.Write(s);
    string x = Console.ReadLine();
    return Convert.ToInt32(x);
 }    