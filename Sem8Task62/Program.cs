//method read data from console
int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    return inputNum;
}

// method fill matrix spirally
int[,] Fill2DArraySpiral(int countRow, int countColumn, int number)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countColumn; i++)
    {
        array2D[0, i] = number;
        number++;
    }
    for (int i = 1; i < countRow; i++)
    {
       array2D[i,countColumn-1] = number;
       number++; 
    }
    for (int i = countColumn-2; i >=0 ; i--)
    {
        array2D[countRow-1,i] = number;
        number++; 
    }
    for (int i =countRow-2; i > 0; i--)
    {
        array2D[i,0] = number;
        number++; 
    }
    for (int i = 1; i < countColumn-1; i++)
    {
        array2D[1, i] = number;
        number++;
    }
    for (int i = countColumn-2; i >0 ; i--)
    {
        array2D[countRow-2,i] = number;
        number++; 
    }

    return array2D;
}
//methos print matrix to array
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

//solution
int startNum = ReadData("Enter a first number ");
int row = 4;
int column = 4;
int[,] array2DSpiral = Fill2DArraySpiral(row, column, startNum);
Print2DArrayColor(array2DSpiral);
