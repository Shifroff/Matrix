// Задайте две квадратные матрицы одного размера. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int n = Prompt("Enter number of rows = ");
int m = Prompt("Enter number of columns = ");
int[,]matrixOne = new int[n,m];
int[,]matrixTwo = new int[n,m];
int[,]matrix = new int[n,m];

FillPrintArray(matrixOne);
Console.WriteLine();
FillPrintArray(matrixTwo);
//Console.WriteLine();
Console.WriteLine();
ProductMatrix(matrix ,matrixOne,matrixTwo);

int Prompt(string message)
 {
    Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
 }
void FillPrintArray(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j <matrix.GetLength(1); j++)
    {
        matrix[i,j] = Convert.ToInt32(Console.ReadLine());
    }
   }
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(" "+matrix[i,j]);
    }
    Console.WriteLine();
   }
} 
void ProductMatrix(int[,]matrix ,int[,]matrixOne,int[,]matrixTwo)
{
    Console.WriteLine("Matrix product");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = matrixOne[i,j]*matrixTwo[i,j];
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("  " +matrix[i,j]);
    }
    Console.WriteLine();
   }
}