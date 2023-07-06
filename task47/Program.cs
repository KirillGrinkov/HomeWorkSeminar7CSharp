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

double[,] array = new double[rows, columns];

GetRandomArray(array);

PrintArray(array);

void GetRandomArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(minNum, maxNum)) / 10;
        }
    }
}


void PrintArray(double[,] inArray)
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
