int firstNumber = int.Parse(Console.ReadLine()??"0");
int secondNumber = int.Parse(Console.ReadLine()??"0");

if(secondNumber%firstNumber == 0)
{
    Console.WriteLine(secondNumber+" is multiple "+firstNumber);
}
else
{
    Console.WriteLine(secondNumber+" is not multiple "+firstNumber+", remainde of division is "+secondNumber%firstNumber);
}