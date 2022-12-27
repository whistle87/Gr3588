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

//method sort an array with inserts method
void SortByInserts(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int j=i;
        int current = array[i];
        while(j>0&&array[j-1]<current)
        {
            array[j]=array[j-1];
            j--;
        }
        array[j]=current;
    }    
}

//method sort rows of matrix
void SortRow2dArray(int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        int[] sortRow = new int[matrix.GetLength(1)];
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            sortRow[j] =  matrix[i,j];
        }
        SortByInserts(sortRow);
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = sortRow[j];
        }       
    }
}

//solution
int row = ReadData("Enter am amount of row ");
int column = ReadData("Enter am column of row ");
int[,] arr2D = Fill2DArray(row, column, 0, 99);
Print2DArrayColor(arr2D);
Console.WriteLine();
SortRow2dArray(arr2D);
Print2DArrayColor(arr2D);
