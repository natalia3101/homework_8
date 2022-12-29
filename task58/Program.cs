/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }

    }

    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int rows = GetNumber("Enter the number of rows for matrix 1");
int columns = GetNumber("Enter the number of columns for matrix 1");
int rows2 = GetNumber("Enter the number of rows for matrix 2");
int columns2 = GetNumber("Enter the number of columns for matrix 2");
int[,] matrix1 = InitMatrix(rows, columns);
int[,] matrix2 = InitMatrix(rows2, columns2);

if (columns != rows2)
{
  Console.WriteLine("The matrixes cannot be multiplied");
}

PrintMatrix(matrix1);
PrintMatrix(matrix2);


int[,] FindProductOfMatix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
      for (int i = 0; i < matrix1.GetLength(0); i++)
      {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
          for (int k = 0; k < matrix1.GetLength(1); k++)
          {
            matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
          }
        }
      }
    return matrix3;
}


PrintMatrix(FindProductOfMatix(matrix1, matrix2));
