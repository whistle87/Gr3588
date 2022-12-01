string? inputLine = Console.ReadLine();

if(inputLine!=null)
{
    int inputNumber = int.Parse(inputLine);
    
    int outResult = inputNumber*inputNumber;
    Console.WriteLine(outResult);
}
