Console.Clear();
Start();
void Start()
{
    int[,,] matrix = GetRandomMatrix();
    PrintMatrix(matrix);
    System.Console.WriteLine(" ");
    int[,,] matrix2 = RedactMassiv(matrix);
    PrintMatrix(matrix2);
}
int[,,] GetRandomMatrix()
{
    int[,,] matrix = new int[2, 2, 2];
    var rand = new Random();
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int d = 0; d < 2; d++)
            {
                matrix[i, j, d] = rand.Next(10, 100);
            }
        }
    }
    return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int d = 0; d < matrix.GetLength(2); d++)
            {
                Console.Write($"{matrix[i, j, d]}{(i,j,d)}  ");
            }
            System.Console.WriteLine("");
        }
    }
}
int[,,] RedactMassiv(int[,,] matrix)
{
    int d = 1;
    int j = 1;
    int[,,] matrix2 = matrix; 
    for (int i = 1; i < matrix2.GetLength(0); i++)
    {
        while (matrix2[i, j, d] == matrix2[i - 1, j, d]) matrix2[i, j, d] = new Random().Next(10, 100);
        for (; j < matrix2.GetLength(1); j++)
        {
            while (matrix2[i, j, d] == matrix2[i, j - 1, d]) matrix2[i, j, d] = new Random().Next(10, 100);
            for (; d < matrix2.GetLength(2); d++)
            {
                while (matrix2[i, j, d] == matrix2[i, j, d - 1]) matrix2[i, j, d] = new Random().Next(10, 100);
            }
        }
    }
    return matrix2;
}