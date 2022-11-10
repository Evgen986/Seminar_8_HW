/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

Main();

void Main()
{
    Console.Clear();
    int[,] array = GetArray(2, 2);
    int[,] array2 = GetArray(2, 2);
    Console.WriteLine("Матрица №1");
    PrintArray(array);
    Console.WriteLine("Матрица №2");
    PrintArray(array2);
    int[,] matrix = MultiplicationMatrix(array, array2);
    Console.WriteLine("Произведение матриц №1 и №2");
    PrintArray(matrix);
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))                           // Ветвление на соответсвие правилу произведения матриц
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return matrixResult;
    }
    else
    {
        Console.WriteLine("Матрицы не совместимы! Количество столбцов матрицы №1 \nи количество колонок матрицы №2 должны быть равны!");
        return matrixResult;
    }
}

int[,] GetArray(int sizeRows, int sizeColumns)
{
    int[,] array = new int[sizeRows, sizeColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}