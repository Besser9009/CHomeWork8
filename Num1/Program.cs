Console.Clear();
Start();
void Start()
{
    int rows = GetNumber("rows");
    int collumns = GetNumber("collumns");
    int[,] matrix = GetNewMatrix(rows, collumns);
    PrintMatrix(matrix);
    System.Console.WriteLine(" ");
    int[,] matrix2 = NewMatrix(matrix);
    PrintMatrix(matrix2);
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
int[,] NewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            for(int n = j; n > 0; n--)
            {
                if (matrix[i, n] > matrix[i, n - 1])
                {
                    int MaxNum = matrix[i, n];
                    matrix[i, n] = matrix[i, n - 1];
                    matrix[i, n - 1] = MaxNum;
                }
            }
        }
    }
    return matrix;
}