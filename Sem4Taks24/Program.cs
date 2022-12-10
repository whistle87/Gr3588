


int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}
int VariantSumSimple(int numA)
{
    int sumOfNum = 0;
    for(int i=1; i<=numA; i++)
    {
        sumOfNum+=i;
    }
    return sumOfNum;
}
int VariantSumGause(int numA)
{
    int sumOfNum = 0;
    sumOfNum = ((1+numA)*numA)/2;
    return sumOfNum;
}

int numberA = ReadData("Enter a number A: ");
DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);
DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numberA);
Console.WriteLine(DateTime.Now - d2);
PrintResult("The amount of numbers from 1 to A is " + res1); 