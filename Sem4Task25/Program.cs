//calculator
string inpitLine = ReadData("Enter an numbers to calculate ");
double[] numbers = ExtractNum(inpitLine);
char sign = ExtractSign(inpitLine);
double answer = Calculate(numbers, sign);
PrintResult(answer);

//method read data from console
string ReadData(string message)
{
    Console.WriteLine(message);
    string inputString = Console.ReadLine()??"0";
    return inputString;
}
// method extract numbers from entered expression
double[] ExtractNum(string inputStr)
{
    double[] numbers = new double[2];
    string[] inputNum = inputStr.Split('+','-','*','/','^');
    numbers[0] = double.Parse(inputNum[0]);
    numbers[1] = double.Parse(inputNum[1]);
    return numbers;
}
// method return the entered sign of mathematical operation
char ExtractSign(string inputStr)
{
    char mathSign = ' ';
    if (inputStr.Contains('+')) mathSign = '+';
    if (inputStr.Contains('-')) mathSign = '-';
    if (inputStr.Contains('*')) mathSign = '*';
    if (inputStr.Contains('/')) mathSign = '/';
    if (inputStr.Contains('^')) mathSign = '^';
    return mathSign;
}
// method calculate an answer usind numbes and sign
double Calculate (double[] numbers, char mathSign)
{
    double result = 0;
    switch (mathSign)
    {
    case '+':
        result = Addition(numbers[0],numbers[1]);
        break;
    case '-':
        result = Subtraction(numbers[0],numbers[1]);
        break;
    case '*':
        result = Multiplication(numbers[0],numbers[1]);
        break;   
    case '/':
        result = Dividion(numbers[0],numbers[1]);
        break;
    case '^':
        result = CalcPow(numbers[0],numbers[1]);
        break;
    }
    return result;
}
// method calcutale the value of num1+num2
double Addition(double num1, double num2)
{
    double result = num1+num2;
    return result;
}
// method calcutale the value of num1-num2
double Subtraction(double num1, double num2)
{
    double result = num1-num2;
    return result;
}
// method calcutale the value of num1/num2
double Dividion(double num1, double num2)
{
    double result = (double)num1/num2;
    return result;
}
// method calcutale the value of num1*num2
double Multiplication(double num1, double num2)
{
    double result = num1*num2;
    return result;
}
// method calcutale the value of num1^num2
double CalcPow(double num1, double num2)
{
    double result = 1;
    for (double i=1; i<=num2; i++)
    {
        result = result*num1;
    }
    return result;
}
// method print result to console
void PrintResult(double num)
{
    Console.Write(num);
}