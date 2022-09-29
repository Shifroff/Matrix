// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int M = Prompt("Enter lower limit M = ");
int N = Prompt("Enter upper limit N = ");
Console.WriteLine(NumberRecursion(M,N));
//int sum = M-N;
//Console.WriteLine(NumberRecursion(M,N));
int NumberRecursion(int M, int N)
{
    int  sum=M; 
    if (M<=N) 
       return sum += NumberRecursion(M+1,N);
           else
      return 0;
}


int Prompt(string data)
{
    Console.Write(data);
    string x = Console.ReadLine();
    return Convert.ToInt32(x);
}