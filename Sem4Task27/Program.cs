//solution
string inputStr = ReadData("Enter a number: ");
DateTime d1 = DateTime.Now;
int res1 = VariantString(inputStr);
PrintResult($"Sum of digit is {res1}");
Console.WriteLine(DateTime.Now - d1 + " time of method using string");
DateTime d2 = DateTime.Now;
double res2 = VariantNumbers(inputStr);
PrintResult($"Sum of digit is {res2}");
Console.WriteLine(DateTime.Now - d2 + " time of method using double numbers");

// method calculates a result using string
int VariantString(string inputString)
{
    int[] numbers = ConvertToNumbers(inputString);
    int result = 0;
    for (int i=0; i < numbers.Length; i++)
    {
        result = result + numbers[i];
    }
    return result;
}
// method calculates a result using numbers
double VariantNumbers(string inputString)
{
    double result = 0;
    double inputNum = double.Parse(inputString);
    while (inputNum>0)
    {
        result = result + inputNum%10;
        inputNum = (int)inputNum/10;
    }
    return result;
}
//method read data from console
string ReadData(string message)
{
    Console.WriteLine(message);
    string inputString = Console.ReadLine()??"0";
    return inputString;
}
// method convert input string to array of numbers
int[] ConvertToNumbers(string inputString)
{
    char[] numChar = inputString.ToCharArray();
    int[] numbers = new int[numChar.Length];
    for (int i=0; i<numChar.Length; i++)
    {
        numbers[i] = ((int)numChar[i])-48;
    }
    return numbers;
}
//method print message to console
void PrintResult(string line)
{
    Console.WriteLine(line);
}