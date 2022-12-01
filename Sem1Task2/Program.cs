// считываем данные с консоли
string? input1Line = Console.ReadLine(); 
string? input2Line = Console.ReadLine();

// Проверяем, что данные не пустые
if(input1Line!=null&&input2Line!=null)
{
    // Преобразыем введеное число из строковой переменной в целочисленную
    int input1Number = int.Parse(input1Line);
    int input2Number = int.Parse(input2Line);

// Сравниваем числа и выводим результат в консоль
    if (input1Number>input2Number)
    {
        Console.WriteLine(input1Number+" > "+input2Number);
    }
    else
    {
        Console.WriteLine(input2Number+" > "+input1Number);
    }
       
}
