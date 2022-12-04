// считываем данные с консоли
int inputNumber = int.Parse(Console.ReadLine()??"0");
// проверяем корректность введеных данных
if(inputNumber>99)
{
    // вычисляем количество цифры в введенном числе
    int numberOfDigits = (int)Math.Round(Math.Log10((double)inputNumber));
    // выводим 3-ю цифру числа
    Console.WriteLine((inputNumber/(int)Math.Pow(10, (numberOfDigits-3)))%10);
}
else
{
    Console.WriteLine("There isn't third number");
}