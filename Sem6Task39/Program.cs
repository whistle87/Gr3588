
int[] range = new int[2]{1,100};
int[] arr = GenArray(20,range);
Console.WriteLine("Input array");
PrintArray(arr);

int[] copyArr = SwapNewArray(arr);
Console.WriteLine("New array swap by creation new array");
PrintArray(copyArr);
Console.WriteLine("Input array");
PrintArray(arr);

int[] copyArrTwo = SwapArray(arr);
Console.WriteLine("New array swap by swap numbers");
PrintArray(copyArrTwo);
Console.WriteLine("Input array");
PrintArray(arr);


//method print array
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine();
}
//
int[] GenArray(int len, int[] range)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(range[0], range[1] + 1);
    }
    return array;
}

int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for(int i = 0; i<arr.Length/2; i++)
    {
        bufElement = arr[arr.Length-1-i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-i-1] = bufElement;
    }
    return arr;
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i = 0; i<arr.Length; i++)
    {
        outArr[i] = arr[arr.Length-1-i];
    }
    return outArr;
}