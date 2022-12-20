
int a = ReadData("Input a: ");
int b = ReadData("Input a: ");
int c = ReadData("Input a: ");
PrintResult(TriangleTest(a,b,c));

bool TriangleTest(int a, int b, int c)
{
    return (a+b>c&&b+c>a&&a+c>b);
}

int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine()??"0");
    return inputNum;
}

void PrintResult(bool res)
{
    if(res)
    {
        Console.Write("It can be so triangle");
    }
    else
    {
        Console.Write("It can't be so triangle");
    }
}