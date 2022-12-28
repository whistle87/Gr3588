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

string RecMN(int m, int n)
{
    string outLine = string.Empty;
    if (m >= n)
    {
        return outLine + n;
    }
    else
    {
        outLine = m + " "+ RecMN(m + 1,n);
        return outLine;
    }
}
//
int numberM = ReadData("Enter number M: ");
int numberN = ReadData("Enter number N: ");
string resultLine = numberM<numberN? RecMN(numberM, numberN):RecMN(numberN, numberM);
PrintResult(resultLine);
