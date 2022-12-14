
int[] range = {-100,1000};
int[] array = FillArray(123,range);
PrintArray(array);
Console.WriteLine();
int result = CountElement(array, 10, 99);
PrintResult($"Theare {result} elements from 10 to 99 in array");

int CountElement(int[] arr, int min, int max)
{
    int res = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]>min&&arr[i]<max)
        {
            res ++;           
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
