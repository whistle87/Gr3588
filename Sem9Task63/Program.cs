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

string LineGenLen(int num)
{
    if (num <= 0)
    {
        return string.Empty;
    }
    else
    {
        string outLine = num + " "+ LineGenLen(num - 1);
        return outLine;
    }
}
//
int number = ReadData("Enter number N: ");
string resultLine = LineGenLen(number);
PrintResult(resultLine);
