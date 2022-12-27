// method read data from console
int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    return inputNum;
}

// method fill matrix with random int numbers
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

(int x, int y) SearchMinElement(int[,] matrix)
{
    int min = matrix[0,0];
    int row =0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j]<min)
            {
                min = matrix[i,j];
                row = i;
                column = j;
            }
        }
    }
    return (row, column);
}

int[,] Convert2DArray(int[,] arr, int x, int y)
{
    int[,] outArray = new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    int rowNew = 0;
    int columnNew = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        columnNew = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i!=x && j!=y)
            {
                outArray[rowNew, columnNew] = arr[i,j];      
            }
            if(j!=columnNew) columnNew++;
        }
        if(i!=x) rowNew++;
    }
    return outArray;
}
//solution
int row = ReadData("Enter an amount of row ");
int column = ReadData("Enter an amoun of column ");
int[,] arr2D = Fill2DArray(row, column, 0, 99);
Print2DArrayColor(arr2D);
Console.WriteLine();
(int x, int y) minElement = SearchMinElement(arr2D);
int[,] out2DArray = Convert2DArray(arr2D, minElement.x, minElement.y);
Print2DArrayColor(out2DArray);