int inputNumber = int.Parse(Console.ReadLine()??"0");

if(inputNumber>99&&inputNumber<1000)
{
    Console.WriteLine("Second number: "+(inputNumber/10)%10);
}
else
{
    Console.WriteLine("Number isn't correct, it should be from 100 to 999");
}