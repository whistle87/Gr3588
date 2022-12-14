
int[] array = GenArray(123,100,999);
PrintArray(array);
Console.WriteLine();
int count = CountEven(array);
PrintResult($"There are {count} even elements in array");
Console.WriteLine("Sorted array:");
SortArray(array);
PrintArray(array);

void SortArray(int[] array)
{
    //int[] outputArray = new int[array.Length];
    int temp = array[0];
    for (int i=0; i<array.Length-1; i++)
    {
        for(int j=i+1;j<array.Length-1;j++)
        {
            if (array[i]>array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
   // return array;
}

int CountEven(int[] arr)
{
    int count = 0;
    for (int i=0; i<arr.Length-1; i++)
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
