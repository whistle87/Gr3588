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

// method count sum of numbers from number1 to number2
int SumOfNumbersInInterval(int number1, int number2)
{
    int result = 0;
    if (number1 >= number2)
    {
        return result+number2;
    }
    else
    {
        result = result + number1+ SumOfNumbersInInterval(number1 + 1, number2);
        return result;
    }
}

//solution
int numberM = ReadData("Enter number M: ");
int numberN = ReadData("Enter number N: ");
int resultSum =
    numberM < numberN
        ? SumOfNumbersInInterval(numberM, numberN)
        : SumOfNumbersInInterval(numberN, numberM);
PrintResult("Sum of numbers is "+resultSum);
