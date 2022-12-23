//method print array with double numbers and every digit print different colour
void Print2DArrayColor(double[,] matrix)
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
            string numString = matrix[i,j].ToString();
            for (int elem = 0; elem<numString.Length; elem++)
            {   
                Console.ForegroundColor = col[new System.Random().Next(0, 16)];
                Console.Write(numString[elem]);
            }
            Console.Write("           ".Substring(matrix[i,j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
// method read data from console
int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    return inputNum;
}
// method fill array with random double numbers
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder)+rand.NextDouble();
            array2D[i,j] = Math.Round(array2D[i,j],3);
        }
    }

    return array2D;
}

//
int row = ReadData("Enter an amount of row ");
int column = ReadData("Enter an amount of column ");
double[,] arr2D = Fill2DArray(row, column, 1, 50);
Print2DArrayColor(arr2D);