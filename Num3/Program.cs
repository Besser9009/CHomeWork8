Console.Clear();
Start();
void Start()
{
    int minValue = GetNumber("minValue");
    int maxValue = GetNumber("maxValue");
    int[,] FirstMatrix = GetNewMatrix(minValue, maxValue);
    PrintMatrix(FirstMatrix);
    System.Console.WriteLine();
    int[,] SecondMatrix = GetNewMatrix(minValue, maxValue);
    PrintMatrix(SecondMatrix);
    System.Console.WriteLine();
    int[,] SumMatrix = GetMatrixSum(FirstMatrix, SecondMatrix);
    PrintMatrix(SumMatrix);
}
int GetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetNewMatrix(int minValue, int maxValue)
{
    int[,] matrix = new int[4, 4];
    Random rand = new Random();
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return matrix;
}
int[,] GetMatrixSum(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int n = 0;
    int[,] SumMatrix = new int[FirstMatrix.GetLength(0),SecondMatrix.GetLength(1)];
    for (int i = 0; i < SumMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < SumMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < SecondMatrix.GetLength(0); k++)
            {
                SumMatrix[i,j] += FirstMatrix[i,k] * SecondMatrix[k,j];
            }
        }
    }
    return SumMatrix;
}
void PrintMatrix(int[,] SumMatrix)
{
    for (int i = 0; i < SumMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < SumMatrix.GetLength(1); j++)
        {
            Console.Write($"{SumMatrix[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}