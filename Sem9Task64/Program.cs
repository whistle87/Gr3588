//method read data from console
int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    return inputNum;
}

//method print result sequence to console
void PrintSequence(int num)
{    
    if (num <= 1)
    {
        Console.Write(num);
        return;
    }
    else
    {
        Console.Write(num+",");
        PrintSequence(num - 1);
    }
}
//solution
int number = ReadData("Enter number N: ");
PrintSequence(number);

