//method fill matrix with random numbers
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder);
        }
    }
    return array2D;
}
// method print matrix and each diogonal is printed in different colour
void Print2DArrAndAwgDiag(string[,] matrix)
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
            int colOfDiag = 1;
            if(i<=j)
            {   

                if (Math.Abs(14+i-j)>0&&Math.Abs(14+i-j)<15) {colOfDiag = Math.Abs(14+i-j);}
                else 
                {
                    while (colOfDiag>15)
                    {
                        colOfDiag = colOfDiag - Math.Abs(14+i-j);
                    }
                }
            }
            else
             {
                if (Math.Abs(14+-i+j)>0&&Math.Abs(14+-i+j)<15) {colOfDiag = Math.Abs(14+-i+j);}
                else 
                {
                    while (colOfDiag>15)
                    {
                        colOfDiag = colOfDiag - Math.Abs(14+-i+j);
                    }
                }
            }

            Console.ForegroundColor = col[colOfDiag];
            Console.Write(matrix[i, j] + "      ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
//method count awerage of each diagonal of matrix and save it to array
double[] AwgDiag(double[,] arr)
{
    int amountOfDag = arr.GetLength(0) + arr.GetLength(1) - 3;
    double[] awgDigonal = new double[arr.GetLength(0) + arr.GetLength(1) - 3];
    int buf = 0;
    for (int num = 0; num < arr.GetLength(0) - 1; num++)
    {
        int sumDiag = 0;
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if ((i - j) == num)
                {
                    sumDiag = sumDiag + (int)arr[i, j];
                    count++;                    
                }
            }
        }
        double awg = (double)(sumDiag) / (double)count;
        awgDigonal[num] = Math.Round(awg, 2);
        buf = num;        
    }
    for (int i=0; i <= buf/2 ; i++)
    {
        double temp = awgDigonal[i];
        awgDigonal[i] = awgDigonal[buf-i];
        awgDigonal[buf-i] = temp;
    }
    for (int num = 1; num < arr.GetLength(1) - 1; num++)
    {
        int sumDiag = 0;
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if ((i - j) == (-1) * num)
                {
                    sumDiag = sumDiag + (int)arr[i, j];
                    count++;
                }
            }
        }
        double awg = (double)(sumDiag) / (double)count;
        awgDigonal[buf + num] = Math.Round(awg, 2);        
    }

    return awgDigonal;
}
//method add avarege value to each diogonal
string[,] AddAwgOfDiagonalToArray (double[,] matrix, double[] awgOfDiag)
{
    string[,] outMatrix = new string[matrix.GetLength(0) + 1, matrix.GetLength(1) + 1];
    for (int i = 0; i < outMatrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < outMatrix.GetLength(1) - 1; j++)
        {
            outMatrix[i, j] = matrix[i, j].ToString();
        }
    }
    outMatrix[0,outMatrix.GetLength(1)-1] = " ";
    outMatrix[outMatrix.GetLength(0)-1,0] = " ";
    outMatrix[1,outMatrix.GetLength(1)-1] = "-";
    outMatrix[outMatrix.GetLength(0)-1,1] = "-";

    for (int j = 2; j < outMatrix.GetLength(1); j++)
    {
        outMatrix[outMatrix.GetLength(0) - 1, j] = awgOfDiag[(j-2)].ToString();
    }
    int count = 0;
    for (int i = 2; i < outMatrix.GetLength(0)-1 ; i++)
    {
        outMatrix[i, outMatrix.GetLength(1) - 1] = awgOfDiag[(awgOfDiag.Length - 1 - count)].ToString();
        count ++;
    }
    return outMatrix;
}

// solution 
double[,] array2D = Fill2DArray(15, 10, 1, 15);
double[] arrOfAwgDiagonal = AwgDiag(array2D);
string[,] arr2DWithAwgDiagonal = AddAwgOfDiagonalToArray(array2D, arrOfAwgDiagonal);
Print2DArrAndAwgDiag(arr2DWithAwgDiagonal);

