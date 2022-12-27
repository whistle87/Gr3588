
float Factor(int n)
{
    float i, x =1;
    for(i=1; i<=n; i++)
    {
        x*=i;
    }
    return x;
}

int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    return inputNum;
}

void PrintPascalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        for (int j = 0; j <= (nRow-i); j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factor(i) / (Factor(j)*Factor(i-j)));
        }
        Console.WriteLine();
    }
}

int countRow = ReadData("введите количество строк треугольника Паскаля");
PrintPascalTriangle(countRow);