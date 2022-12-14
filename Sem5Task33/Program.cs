
int[] range = {1,100};
int[] array = FillArray(20,range);
PrintArray(array);
Console.WriteLine();
int element = ReadData("Enter a number: ");
int result = SearchElem(array, element);
if (result>=0)
{
    PrintResult("Element is found in posisition: "+result);
}
else
{
    PrintResult("Element is not found");
}

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

int SearchElem(int[] arr, int element)
{
    int res = -1;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]==element)
        {
            res = i;
            break;
        }
    }
    return res;
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

int[] FillArray(int len, int[] range)
{
    int[] array = new int[len];
    for(int i=0; i<len; i++)
    {
        array[i] = new Random().Next(range[0],range[1]+1);
    }
    return array;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}
