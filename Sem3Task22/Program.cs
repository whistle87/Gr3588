// solution
int inputNum = ReadData("Enter number ");
string outLine = LineBuild(inputNum,1);
PrintData("", outLine);
outLine = LineBuild(inputNum,2);
PrintData("", outLine);
//method read user's data
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}

// method calculate result
string LineBuild(int num, int pow)
 {
    string line = string.Empty;
    for (int i=1; i<num; i++)
    {
        line = line + Math.Pow(i,pow) + " ";
    }
    line = line + Math.Pow(num,pow);
    return line;
 }

// method print result
void PrintData(string msg, string line)
{
    Console.WriteLine(msg+line);
}

