// считываем данные с консоли
string? inputLine = Console.ReadLine(); 

// Проверяем, что данные не пустые
if(inputLine!=null)
{
    // Преобразыем введеное число из строковой переменной в целочисленную
    int inputNumber = int.Parse(inputLine);
    // вводим счетчик, начинать отсчте будем с первой четной цифры 2
    int count = 2;
    // вводим пустую переменую для записи результата
    string result = string.Empty;   
    // в цикле добавляем четные числа от 2 до заданного числа
    while (count<inputNumber)
    {
        if(count+1 == inputNumber) // если счетчик меньше введеного чиисла на 1, то к результу добавляем только его, без запятой
        {
            result = result + count;
        }
        else 
        {
            result = result + count + ", ";
        }
        
        count = count + 2;
    }
    // Проверяем четное ли введеное число и если да, то приписываем его к результату
    if(inputNumber%2==0)
    {
        result = result + inputNumber;
    }
   
    // Выводим результат в консоль
    Console.WriteLine(result);
   
}
