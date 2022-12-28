long RecPow(int a, int n)
{
    if (n <= 1)
        return a;
    return a * RecPow(a, n - 1);
}

long MyPow(int a, int pow)
{
    if (pow == 2)
        return a * a;
    if (pow == 1)
        return a;
    if (pow % 2 == 0)
    {
        return MyPow(a, pow / 2) * MyPow(a, pow / 2);
    }
    else
    {
        return MyPow(a, pow / 2) * MyPow(a, pow / 2+1);
    }
}

//method read data from console
int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    return inputNum;
}

//method print result to console
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//
int number = ReadData("Enter number: ");
int pow = ReadData("Enter pow : ");
PrintResult("Answer " + RecPow(number, pow));
PrintResult("\nAnswer " + MyPow(number, pow));
