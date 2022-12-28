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

int RecSumDigit(int number)
{
    if (number <= 10 ) return number;
    else return  number%10 + RecSumDigit(number/10); 
}
//
int inputNumber = ReadData("Enter number: ");
int result = RecSumDigit(inputNumber);
PrintResult("Sum of digit " + result);
