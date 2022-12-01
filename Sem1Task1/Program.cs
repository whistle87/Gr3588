// считываем данные с консоли
string? input1Line = Console.ReadLine(); 
string? input2Line = Console.ReadLine(); 

// Проверяем, что данные не пустые
if(input1Line!=null&&input2Line!=null)
{
    // Преобразыем введеное число из строковой переменной в целочисленную
    int input1Number = int.Parse(input1Line);
    int input2Number = int.Parse(input2Line);
    
    if (input1Number*input1Number == input2Number)
    {
 // Выводим результат в консоль
    Console.WriteLine("Yes");
    }
    else
    {
     Console.WriteLine("No");
    }
   
}
