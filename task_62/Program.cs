/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
*/
Main();

void Main()
{
    Console.Clear();
    int[,] array = new int[4, 4];
    FillSpiralArray(array);
    PrintArray(array);
}

void FillSpiralArray(int[,] array)
{
    int count = 10;                                             // Счетчик для заполнения массива - с 10 для равномерного вывода в консоли
    int differenceToOne = count-1;                              // Переменная для вычисления заполненных ячеек массива
    // Заполняем периметр массива                                                        
    for (int i = 0; i < array.GetLength(1); i++)                // Двигаемся в право по первой строке
    {
        array[0, i] = count;
        count++;
    }
    for (int j = 1; j < array.GetLength(0); j++)                // Двигаемся вниз по крайней правой колнке
    {
        array[j, array.GetLength(1) - 1] = count;
        count++;
    }
    for (int i = array.GetLength(1) - 2; i >= 0; i--)           // Двигаемся в лево по нижней строке
    {
        array[array.GetLength(0) - 1, i] = count;
        count++;
    }
    for (int j = array.GetLength(0) - 2; j > 0; j--)            // Двигаемся вверх по крайней левой колонке до значения 1
    {
        array[j, 0] = count;
        count++;
    }
    // Определяем точку для заполнения массива внутри периметра
    int coordRows = 1;                  
    int coordColumns = 1;
    // Начинаем заполнять массив внутри периметра
    while (count-differenceToOne < array.GetLength(0) * array.GetLength(1))     // Цикл будет заполнять массив пока кол-во заполненных ячеек меньше 
    {                                                                           // чем количество ячеек масива
        while (array[coordRows, coordColumns + 1] == 0)         // Пока в ячейке справа значение равно 0
        {
            array[coordRows, coordColumns] = count;
            count++;
            coordColumns++;
        }
        while (array[coordRows + 1, coordColumns] == 0)         // Пока в ячейке снизу значение равно 0
        {
            array[coordRows, coordColumns] = count;
            count++;
            coordRows++;
        }
        while (array[coordRows, coordColumns - 1] == 0)         // Пока в ячейке слева значение равно 0
        {
            array[coordRows, coordColumns] = count;
            count++;
            coordColumns--;
        }
        while (array[coordRows - 1, coordColumns] == 0)         // Пока в ячейке сверху значение равно 0
        {
            array[coordRows, coordColumns] = count;
            count++;
            coordRows--;
        }
    }
    // Заполняем последнюю пустую ячейку
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) array[i, j] = count;
        }
    }
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}