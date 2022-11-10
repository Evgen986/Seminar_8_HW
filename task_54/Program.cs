/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
*/

Main();

void Main()
{
    Console.Clear();
    int[,] array = GetArray(4, 4);
    Console.WriteLine("Массив со случайными значениями:");
    PrintArray(array);
    SortRowsElement(array);
    Console.WriteLine("Массив с отсортированными строками:");
    PrintArray(array);
}

void SortRowsElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)           // Перебираем строки массива
    {
        for (int j = 0; j < array.GetLength(1); j++)       // Перебираем ячейи строки
        {
            int max = array[i, j];                         // Инициализируем переменную max для фиксации максимального знач. в строке
            int indexMax = j;                              // Иниц. перемен. indexMax для фиксации индекса максимального знач. в строке
            for (int k = j; k < array.GetLength(1); k++)   // Перебираем элементы в строке для поиска максимального
            {
                if (array[i, k] > max)
                {
                    max = array[i, k];
                    indexMax = k;
                }
            }
            int temp = array[i, j];                         // Переносим максимальное значение в начало строки 
            array[i, j] = max;
            array[i, indexMax] = temp;
        }
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