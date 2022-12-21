
int number = ReadData("Enter a number ");
PrintResult("Fibbonachi: "+Fibbanachi(number));

string Fibbanachi(int num)
{
    string outLine = "0 1";
    int buf = 0;
    int last = 1;
    int first = 0;
    for(int i=2; i<num; i++)
    {
        outLine = outLine + " " + (last+first).ToString();
        buf = last;
        last = last+first;
        first = buf;
    }
    return outLine;
}

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