// считываем данные с консоли
string? lineA = Console.ReadLine(); 

// Проверяем, что данные не пустые
if(lineA!=null)
{
//     // Создаем массив дней недели
//     string[] dayWeek = new string[7];
//     dayWeek[0] = "Понедельник";
//     dayWeek[1] = "Вторник";
//     dayWeek[2] = "Среда";
//     dayWeek[3] = "Четверг";
//     dayWeek[4] = "Пятница";
//     dayWeek[5] = "Суббота";
//     dayWeek[6] = "Воскресенье";
//     // Преобразыем введеное число из строковой переменной в целочисленную
    int inputNum = int.Parse(lineA);
// // выводим день недели
//     Console.WriteLine(dayWeek[num-1]);
   // string outDayOfWeek = string.Empty;
    // switch(inputNum)
    // {
    //     case 1: outDayOfWeek = "понедельник"; break;
    //     case 2: outDayOfWeek = "вторник"; break;
    //     case 3: outDayOfWeek = "среда"; break;
    //     case 4: outDayOfWeek = "четверг"; break;
    //     case 5: outDayOfWeek = "пятница"; break;
    //     case 6: outDayOfWeek = "суббота"; break;
    //     case 7: outDayOfWeek = "воскресенье"; break;
    //     default: outDayOfWeek = "это не день недели!"; break;
    // }
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNum));

    Console.WriteLine(outDayOfWeek);
}
