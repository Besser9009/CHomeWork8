Console.Clear();
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Start();
void Start()
{
    int rows = GetNumber("rows");
    int collumns = GetNumber("collumns");
    int[,] matrix = GetNewMatrix(rows, collumns);
    PrintMatrix(matrix);
    int[] array = SumRows(matrix);
    MinSum(array);
}
int GetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetNewMatrix(int rows, int collumns)
{
    int[,] matrix = new int[rows, collumns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 10);
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
        Console.WriteLine(" ");
    }
}
int[] SumRows(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] += matrix[i, j];
        }
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine(" ");
    return array;
}
int MinSum(int[] array)
{
    int minIndex = 1;
    int min = array[array.Length - 1];
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex += i;
        }
    }
    Console.Write($"Наименьшая сумма чисел строки массива = {min} и это строка №{minIndex}");
    return minIndex;
}