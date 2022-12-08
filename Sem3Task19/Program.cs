// read output data
int outputNumber = ReadData("Enter a five-digit number ");
// cheking the correctness of the entered datd
if (outputNumber>=10000&&outputNumber<=99999)    
{
    // create a dictionary with four-digit palondromes
    var palindrome = new Dictionary<int, int>();
    int keyNumber = 1;
        for(int secondNumber = 0; secondNumber<=9; secondNumber++)
        {
            for(int firstNumber = 1; firstNumber<=9; firstNumber++)
            {
                palindrome[keyNumber] = firstNumber*1000+secondNumber*100+secondNumber*10+firstNumber;
                keyNumber++;
            }
        }

    //create four digit number from output data
    int numFourDigit = ((outputNumber/1000)*100)+(outputNumber%100);

    // check if there is a number in dictionary  
    if (palindrome.ContainsValue(numFourDigit))
    {
        PrintData(outputNumber, " is a palindrome");
    }
    else
    {
        PrintData(outputNumber, " is not a palindrome");
    }
}
else
{
    Console.WriteLine("Input number isn't correct. It shoul be from 10000 to 99999");
}
// method read input data from console
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}
// method print result to console 
void PrintData(int num, string msg)
{
    Console.WriteLine(num+msg);
}