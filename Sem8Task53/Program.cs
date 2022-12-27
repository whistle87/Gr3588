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
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];           
            Console.Write(matrix[i,j]+"  ".Substring(matrix[i,j].ToString().Length)); 
            Console.ResetColor();          
        }
        Console.WriteLine();
    }
}

void Change2dArray (int[,] matr)
{
    int temp =0;
    for (int i =0; i<matr.GetLength(1); i++)
    {
        temp = matr[0,i];
        matr[0,i] = matr[matr.GetLength(0)-1,i];
        matr[matr.GetLength(0)-1,i] = temp;
    }
}

int row = ReadData("Enter am amount of row ");
int column = ReadData("Enter am column of row ");
int[,] arr2D = Fill2DArray(row, column, 1,10);
Print2DArrayColor(arr2D);
Change2dArray(arr2D);
Console.WriteLine();
Print2DArrayColor(arr2D);