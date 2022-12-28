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

// method calculate Ackerman function
int AckermanFunction(int m, int n)
{    
  if (m == 0)
    return n + 1;
  else
    if ((m > 0) && (n == 0))
      return AckermanFunction(m - 1, 1);
    else
      return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

//solution
int m = ReadData("Enter number m: ");
int n = ReadData("Enter number n: ");
int result = AckermanFunction(m, n);
PrintResult("Akkerman function is "+result);