/*  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
*/
Main();

void Main()
{
    Console.Clear();
    int[,] array = GetArray(8, 4);
    PrintArray(array);
    Console.WriteLine($"Наименьшаяя сумма элементов находится в строке: {FindRowSmallSumElements(array)}");
}

int FindRowSmallSumElements(int[,] array)
{
    int minSumElementsRow = 0;
    int indexSmallRows = 0;
    for (int i = 0; i < 1; i++)                         // Находим сумму элементов 1 строки, для задания точки сравнения
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minSumElementsRow += array[i, j];
        }
    }
    for (int i = 1; i < array.GetLength(0); i++)        // Сравниваем оставшиеся строки массива
    {
        int sumElements = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElements += array[i, j];
        }
        if (sumElements < minSumElementsRow)            // Если сумма элементов строки меньше находящегося значения в переменной 
        {   minSumElementsRow = sumElements;            // minSumElementsRow присваеваем ее в данную переменную и фиксируем индекс
            indexSmallRows = i;                         // строки
        }
    }
    return indexSmallRows + 1;                          // добавляем к индексу 1, т.к. индекс массива начинается с 0.
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