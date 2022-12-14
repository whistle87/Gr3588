
int[] range = {-10,10};
int[] array = FillArray(20,range);
PrintArray(array);
Console.WriteLine();
int[] newArr = ConvertArray(array);
PrintArray(newArr);

int[] ConvertArray(int[] arr)
{
    int[] outArr = new int[arr.Length/2];
    for(int i=0; i<arr.Length/2; i++)
    {
        outArr[i] = arr[i]*arr[arr.Length-1-i];
    }
    return outArr;
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
