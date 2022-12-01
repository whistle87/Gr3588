// считываем данные с консоли
string? inputLine = Console.ReadLine(); 

// Проверяем, что данные не пустые
if(inputLine!=null)
{
    // Преобразыем введеное число из строковой переменной в целочисленную
    int inputNumber = int.Parse(inputLine);
    
    // Находим квадрат числа
    int outResult = inputNumber*inputNumber;

    // Выводим результат в консоль
    Console.WriteLine(outResult);
}
