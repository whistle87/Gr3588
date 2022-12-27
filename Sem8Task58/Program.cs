// method read data from console
int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    return inputNum;
}

// method fill array with random int numbers
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder);
        }
    }
    return array2D;
}

//method print coloured matrix
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]
    {
        ConsoleColor.Black,
        ConsoleColor.Blue,
        ConsoleColor.Cyan,
        ConsoleColor.DarkBlue,
        ConsoleColor.DarkCyan,
        ConsoleColor.DarkGray,
        ConsoleColor.DarkGreen,
        ConsoleColor.DarkMagenta,
        ConsoleColor.DarkRed,
        ConsoleColor.DarkYellow,
        ConsoleColor.Gray,
        ConsoleColor.Green,
        ConsoleColor.Magenta,
        ConsoleColor.Red,
        ConsoleColor.White,
        ConsoleColor.Yellow
    };
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[matrix[i, j] % 15];
            Console.Write(matrix[i, j] + "    ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int aRows = matrixA.GetLength(0);
    int aCols = matrixA.GetLength(1);
    int bRows = matrixB.GetLength(0);
    int bCols = matrixB.GetLength(1);
    // if (aCols != bRows)
    // throw new Exception("Non-conformable matrices in MatrixProduct");
    int[,] result = new int[aRows, bCols];
    for (int i = 0; i < aRows; ++i) // каждая строка A
        for (int j = 0; j < bCols; ++j) // каждый столбец B
            for (int k = 0; k < aCols; ++k)
                result[i, j] += matrixA[i, k] * matrixB[k, j];
    return result;
}

int firstRow = ReadData("Enter am amount of row in first matrix");
int firstColumn = ReadData("Enter am amount of column in first matrix");
int secondRow = ReadData("Enter am amount of row in second matrix");
int secondColumn = ReadData("Enter am amount of column in second matrix ");
int[,] firstMatrix = Fill2DArray(firstRow, firstColumn, 0, 5);
Print2DArrayColor(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = Fill2DArray(secondRow, secondColumn, 0, 10);
Print2DArrayColor(secondMatrix);
Console.WriteLine();
if (firstColumn == secondRow)
{
    int[,] multMatrix = MatrixMultiplication(firstMatrix, secondMatrix);
    Print2DArrayColor(multMatrix);
}
else
{
    Console.Write("This matrix can't be multiplied");
}
