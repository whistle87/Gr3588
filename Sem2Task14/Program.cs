int number = int.Parse(Console.ReadLine()??"0");

if(number%7==0 && number%23==0)
{
    Console.WriteLine("делится");
}
else
{
    Console.WriteLine("не делится");
}