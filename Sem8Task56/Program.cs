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

int[] CalculateSumOfRow(int[,] matrix)
{
    int[] sumOfRow = new int [matrix.GetLength(0)];
    for (int i = 0; i < sumOfRow.Length; i++)
    {
        sumOfRow[i] = 0;
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfRow[i] = sumOfRow[i] + matrix[i,j];
        }
    }
    return sumOfRow;
}

//method print array of sum
void PrintSumArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Sum of elements in {i} row is {array[i]}");
    }    
}
// method sort an array with bubbles method
void BubbleSort(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        int minPozition = i;
        for(int j=i+1; j<arr.Length; j++)
        {
            if(arr[j]<arr[minPozition])  minPozition = j;            
        }
        int temp = arr[i];
        arr[i] = arr[minPozition];
        arr[minPozition] = temp;        
    }
}
void PrintResult(string line, int num)
{
    Console.Write(line+num);
}

////solution
int row = ReadData("Enter am amount of row ");
int column = ReadData("Enter am column of row ");
int[,] arr2D = Fill2DArray(row, column, 0, 10);
Console.WriteLine();
Print2DArrayColor(arr2D);
Console.WriteLine();
int[] sumOfRow = CalculateSumOfRow(arr2D);
PrintSumArray(sumOfRow);
BubbleSort(sumOfRow);
Console.WriteLine();
PrintResult("Min sum of row is ",sumOfRow[0]);


