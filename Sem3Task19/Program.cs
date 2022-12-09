// read output data
int outputNumber = ReadData("Enter a five-digit number ");
// cheking the correctness of the entered datd
if (outputNumber>=10000&&outputNumber<=99999)    
{
    // create a dictionary with four-digit palondromes
    var palindrome = new Dictionary<int, int>();
    palindrome = DictionaryFill();
    // check if there is an input number in dictionary  
    bool check = PalinTest(outputNumber, palindrome);
    if (check)
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
// method fill a dictionary with four-digit palindrome
Dictionary<int, int> DictionaryFill()
{ 
    var dictionary = new Dictionary<int, int>();
    int keyNumber = 1;
        for(int secondNumber = 0; secondNumber<=9; secondNumber++)
        {
            for(int firstNumber = 1; firstNumber<=9; firstNumber++)
            {
                dictionary[keyNumber] = firstNumber*1000+secondNumber*100+secondNumber*10+firstNumber;
                keyNumber++;
            }
        }
    return dictionary;
}
// method check if the five-digit number is a palindrome
bool PalinTest(int number, Dictionary<int, int> palindrome)
{
    bool result = false;
    if (palindrome.ContainsValue((number/1000)*100+(number%100)))
    {
        result = true;
    }
    return result;
}
