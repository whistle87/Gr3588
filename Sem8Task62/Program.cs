//method read data from console
int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    return inputNum;
}

// method fill matrix spirally
void Fill2DArraySpiral(int[,] array2D, int number, int[] startPosition)
{    
    for (int i = startPosition[1]; i < array2D.GetLength(1)-startPosition[1]; i++)
    {
        array2D[startPosition[0], i] = number;
        number++;
    }
    for (int i = startPosition[0]+1; i < array2D.GetLength(0)-startPosition[0]; i++)
    {
       array2D[i,array2D.GetLength(1)-1-startPosition[1]] = number;
       number++; 
    }
    for (int i = array2D.GetLength(1)-2-startPosition[1]; i >=startPosition[1] ; i--)
    {
        array2D[array2D.GetLength(0)-1-startPosition[0],i] = number;
        number++; 
    }
    for (int i =array2D.GetLength(0)-2-startPosition[0]; i > startPosition[0]; i--)
    {
        array2D[i,startPosition[1]] = number;
        number++; 
    }
    startPosition[0]++;
    startPosition[1]++;
    bool matrixEmpty = false;
    for (int i = startPosition[0]; i < array2D.GetLength(0); i++)
    {
        for (int j = startPosition[1]; j < array2D.GetLength(1); j++)
        {
            if (array2D[i,j]==0) matrixEmpty = true;
        }
    }
    if (matrixEmpty)  Fill2DArraySpiral(array2D, number, startPosition);
    else return;
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
int row = ReadData("Enter an amount of row ");
int column = ReadData("Enter an amoun of column ");
int[,] array2D = new int[row, column];
int[] startPosition = new int[2] {0,0};
Fill2DArraySpiral(array2D, startNum, startPosition);
Print2DArrayColor(array2D);
