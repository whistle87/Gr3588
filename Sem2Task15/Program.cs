// считываем данные с консоли
int inputNumber = int.Parse(Console.ReadLine()??"0");
// создаем новый словарь с номерами дней недели и указанием выходной это день или нет
 var week = new Dictionary<int, string>()
{
    { 1, "Нет"},
    { 2, "Нет"},
    { 3, "Нет"},
    { 4, "Нет"},
    { 5, "Нет"},
    { 6, "Да"},
    { 7, "Да"}
};    
// проверяем корректность введеных данных
if(inputNumber>=1&&inputNumber<=7)
{
   // выводим результат
    Console.WriteLine(week[inputNumber]);
}
else
{
    Console.WriteLine("It's not correct number. Input number from 1 to 7");
}