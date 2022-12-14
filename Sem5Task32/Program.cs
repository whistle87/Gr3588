int[] range = {-9,9};
int[] array = FillArray(10,range);
PrintArray(array);
Console.WriteLine();
PrintArray(InverseArray(array));
//============================
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

int[] InverseArray (int[] array)
{
    int[] outArray = new int[array.Length];
    for(int i=0; i<array.Length; i++)
    {
        outArray[i] = array[i]*(-1);
    }
    return outArray;
}