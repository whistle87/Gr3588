int[] range = new int[] { -10, 10 };
int[] array = GenArray(25, range);
PrintArray(array);
int sum = SumOddPos(array);
Console.WriteLine("\nСумма элементов на нечетных позициях "+sum);
List<int[]> pair = FindPair(array, range[0]); 
if (pair.Count == 0)
{
    Console.WriteLine("В массиве нет повторяющихся элементов");
}
else
{    
    Console.WriteLine("Позиции пар чисел и их значение: ");
    PrintResult(pair);
}

//method count the amount of numbers in odd position
int SumOddPos(int[] arr)
{
    int result = 0;
    for (int i=1; i<arr.Length; i+=2)
    {
        result = result + arr[i];       
    }
    return result;
}

// method create a list of pairs in the array with their value
List<int[]> FindPair(int[] array, int min)
{
    List<int[]> result = new List<int[]>();
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 1 + i; j < array.Length && array[j] >= min; j++)
        {
            if (array[i] == array[j])
            {
                int[] arrayPair = new int[3];
                arrayPair[0] = i;
                arrayPair[1] = j;
                arrayPair[2] = array[i];
                array[j] = min - 1;
                result.Add(arrayPair);
                break;
            }
        }
    }
    return result;
}
//method print array
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1] + "]");
}
//method create new array of the specified length and fill it with random numbers from the specified range
int[] GenArray(int len, int[] range)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(range[0], range[1] + 1);
    }
    return array;
}
// method print a list of pairs
void PrintResult(List<int[]> numPair)
{
    foreach (var pair in numPair)
    {
        Console.WriteLine("Число " + pair[2] + " встречается на позициях " + pair[0] + " и " + pair[1]);
    }
}
