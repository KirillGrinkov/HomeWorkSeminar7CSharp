// 

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите минимальное значение массива: ");
int minNum = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите максимальное значение массива: ");
int maxNum = int.Parse(Console.ReadLine() ?? "");

int[,] array = new int[rows, columns];

GetRandomArray(array);

PrintArray(array);

Console.WriteLine();

RowSum(array);


void GetRandomArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minNum, maxNum);
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

void RowSum(int[,]inArray)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = (sum + array[i, j]);
        }
        sum = sum / rows;
        Console.Write(sum + "     ");
    }
}