// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите минимальное значение массива: ");
int minNum = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите максимальное значение массива: ");
int maxNum = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите искомое значение строки: ");
int findRows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите искомое значение столбца: ");
int findColums = int.Parse(Console.ReadLine() ?? "");



int[,] array = new int[rows, columns];

GetRandomArray(array);

SearchNumber(array);

PrintArray(array);

void GetRandomArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(minNum, maxNum)) / 10;
        }
    }
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void SearchNumber(int[,] inArray)
{
    if (findRows > array.GetLength(0) || findColums > array.GetLength(1))
    Console.WriteLine("такого элемента нет");
    else
    Console.WriteLine($"значение элемента {findRows} строки и {findColums} столбца равно {array[findRows-1,findColums-1]}");
}
