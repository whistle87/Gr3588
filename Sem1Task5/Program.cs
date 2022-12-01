string? inputLine = Console.ReadLine();

if(inputLine!=null)
{
    // Преобразыем введеное число из строковой переменной в целочисленную
    int inputNumber = int.Parse(inputLine);
   
    int startNumber = inputNumber*(-1);

    string outLine = string.Empty;

    while (startNumber<inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        startNumber++;
    }

    outLine = outLine+inputNumber;
    // Выводим результат в консоль
    Console.WriteLine(outLine);
}