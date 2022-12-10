using System.Numerics;

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

BigInteger CalcFactor(int num)
{
    BigInteger count = 1;
    for (int i=1; i<=num;i++)
    {
        count *=i;
    }
    return count;
}

int number = ReadData("Enter a number: ");
BigInteger fact = CalcFactor(number);
PrintResult("factorial is " + fact);
