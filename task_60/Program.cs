/*  Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
               Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

Main();

void Main()
{
    Console.Clear();
    int[,,] array = GetArray(3, 3, 3);
    Console.WriteLine("Массив со случайными значениями:");
    PrintArray(array);
}

int[,,] GetArray(int sizeArray1, int sizeArray2, int sizeArray3)        // Метод заполнения 3-х мерного массива неповторяющимися числами
{
    int[,,] array = new int[sizeArray1, sizeArray2, sizeArray3];
    int count = 99;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = count;
                count--;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[j, k, i]} ({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}