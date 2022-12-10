int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int VariantLog(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}
int VariantString(int num)
{
    int count = num.ToString().Length;
    return count;
}
int VariantCycle(int num)
{
    int count = 0;
    while (num > 0)
    {
        count ++;
        num = num / 10;
    }
    return count;
}

int number = ReadData("Enter a number ");
DateTime d1 = DateTime.Now;
int res1 = VariantLog(number);
PrintResult($"There are {res1} digits in number");
Console.WriteLine(DateTime.Now - d1 + " log");
DateTime d2 = DateTime.Now;
int res2 = VariantString(number);
PrintResult($"There are {res2} digits in number");
Console.WriteLine(DateTime.Now - d2 + " string");
DateTime d3 = DateTime.Now;
int res3 = VariantCycle(number);
PrintResult($"There are {res3} digits in number");
Console.WriteLine(DateTime.Now - d3 + " cycle");