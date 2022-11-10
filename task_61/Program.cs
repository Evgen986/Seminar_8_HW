/* Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного
треугольника.
*/

Main();

void Main()
{
    Console.Clear();
    Console.Write("Введите число N для задания треугольника: ");
    int n = int.Parse(Console.ReadLine());
    int[,] pascalTriangle = new int[n, n];
    FillPascalTriangle(pascalTriangle);
    PrintTriangleArray(pascalTriangle);
}

void FillPascalTriangle(int[,] array)
{
    array[0, 0] = 1;
    array[1, 0] = 1;
    array[1, 1] = 1;
    for (int i = 2; i < array.GetLength(0); i++)
    {
        array[i, 0] = 1;
        for (int j = 1; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
}

void PrintTriangleArray(int[,] array)                   // Метод корректно выводит треугольник до n=10, потом треуг. нарушается
{                                                       // нужно доделать.
    int count = array.GetLength(0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count2 = count;
        if (i > 4) count2--;
        while (count2 >= 0)
        {
            Console.Write(" ");
            count2--;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0) Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
        count--;
    }
}