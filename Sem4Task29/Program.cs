//solution
int len = ReadData("Enter a length of an array: ");
int[] range = ReadRange("Enter a range of numbers in format From,To");
int[] answer = FillArray(len, range);
PrintResult("Array: ",answer);

//method extract range numbers from console
int[] ReadRange(string message)
{
    Console.WriteLine(message);
    int[] numbers = new int[2];
    string inputStr = Console.ReadLine()??"0";
    string[] inputNum = inputStr.Split(',');
    numbers[0] = int.Parse(inputNum[0]);
    numbers[1] = int.Parse(inputNum[1]);
    return numbers;
}
//method read data from console
int ReadData(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
//method fill array with random nimbers from range
int[] FillArray(int len, int[] range)
{
    int[] array = new int[len];
    for(int i=0; i<len; i++)
    {
        array[i] = new Random().Next(range[0],range[1]+1);
    }
    return array;
}
// method print array
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i=0;i<array.Length-1;i++)
    {
        Console.Write(array[i]+",");
    }
    Console.Write(array[array.Length-1]+"]");
}
//method print message to console
void PrintResult(string line, int[] array)
{
    Console.WriteLine(line);
    PrintArray(array);
}