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

void Print2DArrayColor(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j]+"      ".Substring(matrix[i,j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    return inputNum;
}

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

void Update2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i+=2)
    {
        for (int j = 0; j < arr.GetLength(1); j+=2)
        {
            arr[i,j] = arr[i,j]*arr[i,j];
        }
    }

}

int row = ReadData("Enter an amount of row ");
int column = ReadData("Enter an amount of column ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);
Update2DArray(arr2D);
Console.WriteLine();
Print2DArrayColor(arr2D);