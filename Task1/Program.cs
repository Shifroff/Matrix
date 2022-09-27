//  Задайте двумерный массив. Напишите программу, 
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Номер строки с наименьшей суммой элементов: 1 строка
// (допускается указывать индекс строки в массиве, в данном примере - 0)


internal class Program
{
    private static void Main(string[] args)
    {
        int numLine = Prompt("Enter number of lines = ");
        int numColumn = Prompt("Enter number of columns = ");
        int[,] matrix = new int[numLine, numColumn];
        FillPrintMatrix(matrix);
        MinLine(matrix);

        void MinLine(int[,] matrix)
        {
            int[] sum = new int[numLine];
            int count = 0;
            for (int i = 0; i < numLine; i++)
            {
                for (int j = 0; j < numColumn; j++)
                {
                    sum[i] += matrix[i, j];
                   
                }
            }
            for (int i = 0; i < numLine; i++)
            {
                int min = sum[0];
                if (sum[i] < min)
                {
                    min = sum[i];
                    count = i ;
                }
            }
            Console.WriteLine("Number of min line = " + count);
        }

        void FillPrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < numLine; i++)
            {
                for (int j = 0; j < numColumn; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < numLine; i++)
            {
                for (int j = 0; j < numColumn; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        int Prompt(string message)
        {
            Console.Write(message);
            string value = Console.ReadLine();
            return Convert.ToInt32(value);
        }
    }
}
