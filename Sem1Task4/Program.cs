// считываем данные с консоли
string? input1Line = Console.ReadLine(); 
string? input2Line = Console.ReadLine();
string? input3Line = Console.ReadLine();

// Проверяем, что данные не пустые
if(input1Line!=null&&input2Line!=null&&input3Line!=null)
{
    // Преобразыем введеное число из строковой переменной в целочисленную
    int input1Number = int.Parse(input1Line);
    int input2Number = int.Parse(input2Line);
    int input3Number = int.Parse(input3Line);

// Сравниваем числа и выводим результат в консоль
    if (input1Number>input2Number)
    {
        if (input1Number>input3Number)
        {
            Console.WriteLine("max = "+input1Number);
        }
        else
        {
            Console.WriteLine("max = "+input3Number);
        }        
    }
    else 
    {
        if (input2Number>input3Number)
        {
            Console.WriteLine("max = "+input2Number);
        }
        else
        {
            Console.WriteLine("max = "+input3Number);
        }
    }
           
}
