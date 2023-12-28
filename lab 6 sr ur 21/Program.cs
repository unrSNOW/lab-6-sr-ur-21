double[,] matrixA = {
            { 1, -2, 3 },
            { 4, 5, -6 },
            { -7, 8, 9 }
        };

double normL = CalculateNormL(matrixA);
double normM = CalculateNormM(matrixA);

Console.WriteLine("Норма L: " + normL);
Console.WriteLine("Норма M: " + normM);
    

    static double CalculateNormL(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    double maxSum = 0;

    for (int i = 0; i < rows; i++)
    {
        double rowSum = 0;
        for (int j = 0; j < cols; j++)
        {
            rowSum += Math.Abs(matrix[i, j]);
        }
        if (rowSum > maxSum)
        {
            maxSum = rowSum;
        }
    }

    return maxSum;
}

static double CalculateNormM(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    double maxSum = 0;

    for (int j = 0; j < cols; j++)
    {
        double colSum = 0;
        for (int i = 0; i < rows; i++)
        {
            colSum += Math.Abs(matrix[i, j]);
        }
        if (colSum > maxSum)
        {
            maxSum = colSum;
        }
    }

    return maxSum;
}

