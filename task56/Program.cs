/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


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


int rows = GetNumber("Enter the number of rows");
int columns = GetNumber("Enter the number of columns");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);


void GetLineSum(int[,] matrix)
{
    int minRowSum = 0;
    int indexMinRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
      {
        minRowSum = minRowSum + matrix[0, i];
      }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
                
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = matrix[i, j] + sum;
        }
        if(minRowSum > sum)
        {
            minRowSum = sum;
            indexMinRow = i;
        }
    }
    Console.WriteLine($"Line {indexMinRow + 1} has the min sum of elements");
       
}

GetLineSum(matrix);
