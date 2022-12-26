//method print array and element at given posisiotn is printed in different colour
void Print2DArrayHighlight(long[,] matrix, int row, int column)
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
    ConsoleColor.Yellow
};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==row&&j==column)
            {   
                Console.ForegroundColor = col[new System.Random().Next(0, 15)];
                Console.Write(matrix[i,j]+"              ".Substring(matrix[i,j].ToString().Length));
                Console.ResetColor();
            }
            else
            {
            Console.Write(matrix[i,j]+"              ".Substring(matrix[i,j].ToString().Length));   
            }        
        }
        Console.WriteLine();
    }
}
//method read data from console
int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    return inputNum;
}
//method fill array with sequence fibonacci
long[,] Fill2DFibonacci(int countRow, int countColumn)
{
    long[,] array2D = new long[countRow, countColumn];
    array2D[0,0] = 0;
    array2D[0,1] = 1;
    int second = 1; 
    int first = 0; 
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            if((i==0&&j==0)||(i==0&&j==1))
            {
                array2D[0,0] = 0;
                array2D[0,1] = 1;
            }     
            else
            {
            array2D[i, j] = first+second;
            first = second;
            second = (int)array2D[i,j];
            }
        }
    }

    return array2D;
}

//solution
int posRow = ReadData("Enter a row ");
int posColumn = ReadData("Enter a column ");
int numOfRow = 7;
int numOfColumn = 6;
long[,] arr2D = Fill2DFibonacci(numOfRow, numOfColumn);

if (posRow>numOfRow||posColumn>numOfColumn)
{
    Console.WriteLine("There is no such element in the matrix");
}
else
{
    Print2DArrayHighlight(arr2D, posRow, posColumn);
}
