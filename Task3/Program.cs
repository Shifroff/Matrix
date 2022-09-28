// Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел 
//(размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34
int n = Prompt("Enter number of rows = ");
int m = Prompt("Enter number of columns = ");

if (n*m > 50)
   Console.WriteLine("Enter another i and j  (j*i<50) "); 
else
    FillPrintArray(n,m); 

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

void FillPrintArray(int n, int m)
    {
    Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                List<int>arr = new List<int>();
                int v = rnd.Next(10,99);
                while(arr.Contains(v)) v = rnd.Next(10,99);
                for (int j = 0; j < m; j++)
                {
                    while(arr.Contains(v)) v = rnd.Next(10,99);
                    arr.Add(v);
                }
                foreach (int item in arr) Console.Write(item.ToString()+"  ");
                {
                Console.WriteLine();
                }
            }
    }