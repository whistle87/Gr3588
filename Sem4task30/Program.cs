//solution
int number = ReadData("Enter a length of array: ");
int[] array = GenArray(number);
PrintResult("Array: ", array);

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

int[] GenArray(int len)
{
    int[] outArray = new int[len];
    for (int i=0; i <len; i++)
    {
        outArray[i] = new Random().Next(0,2);
    }
    return  outArray;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i=0;i<array.Length-1;i++)
    {
        Console.Write(array[i]+",");
    }
    Console.Write(array[array.Length-1]+"]");
}

void PrintResult(string line, int[] arr)
{
    Console.WriteLine(line);
    PrintArray(arr);
}