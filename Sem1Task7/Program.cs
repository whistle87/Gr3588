string? inputLine = Console.ReadLine();

if(inputLine!=null)
{
    // Преобразыем введеное число из строковой переменной в целочисленную
    int inputNumber = int.Parse(inputLine);
   
    int outNumber = inputNumber%10;
    // Выводим результат в консоль
    Console.WriteLine(outNumber);
}