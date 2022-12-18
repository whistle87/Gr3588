
int[] array = GenArray(123,100,999);
PrintArray(array);
Console.WriteLine();
int count = CountEven(array);
Console.WriteLine("Sorted array:");
SortArray(array);
PrintArray(array);
PrintResult($"\nThere are {count} even elements in array");

void SortArray(int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int minPoz = i;
        for(int j=i+1;j<array.Length;j++)
        {
            if (array[j]<array[minPoz]) minPoz = j;
        }
        int temp = array[i];
        array[i] = array[minPoz];
        array[minPoz] = temp;
    }
}

int CountEven(int[] arr)
{
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2==0)
        {
            count ++;
        }
    }
    return count;
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

int[] GenArray(int len, int min, int max)
{
    int[] array = new int[len];
    for(int i=0; i<len; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}
