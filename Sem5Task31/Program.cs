//solution
int positivSum = 0;
int negativSum = 0;
int[] range = {-9,9};
int[] testArr = FillArray(12,range);
NegotivePositivSum(testArr);
PrintArray(testArr);
Console.WriteLine();
PrintResult("Sum of positiv numbers in array is: ", positivSum);
PrintResult("Sum of negativ numbers in array is: ", negativSum);


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

void PrintResult(string line, int value)
{
    Console.WriteLine(line+value);
}

void NegotivePositivSum(int[] arr)
{
    foreach (int num in arr)
    {
        if(num>0)
        {    
            positivSum += num;
        }
        else 
        {
           negativSum += num; 
        }
    }
}

