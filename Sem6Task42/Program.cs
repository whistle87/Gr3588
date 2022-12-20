
int outputNum = ReadData("Enter a number");
PrintResult("Bin number is "+DecToBin(outputNum));
PrintResult("Bin number2 is "+DecToBinNativ(outputNum));

int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine()??"0");
    return inputNum;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

string DecToBin(int num)
{
    string outBin= String.Empty;
    while(num > 0)
    {
        outBin = (num%2)+outBin;
        num = num/2;       
    }
    return outBin;
}

string DecToBinNativ(int num)
{
    return Convert.ToString(num,2);
}