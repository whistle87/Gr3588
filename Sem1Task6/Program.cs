// считываем данные с консоли
string? inputLine = Console.ReadLine(); 

// Проверяем, что данные не пустые
if(inputLine!=null)
{
    // Проверяем остаток от деления на 2 и выводим результат
    int inputNumber = int.Parse(inputLine);
    if (inputNumber%2==0)
    {
        Console.WriteLine("число четное");
    }
    else
    {
        Console.WriteLine("число не четное");
    }
   
}
