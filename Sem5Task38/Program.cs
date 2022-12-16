int[] range = new int[2] {-5, 5};
int[] array = GenArray(123, range);
PrintArray(array);
int[] arrayBubble = new int[array.Length];
DateTime d1 = DateTime.Now;
int[] arrayCount = SortByCount(array, range);
Console.WriteLine("\nSorted by counting in "+(DateTime.Now-d1));
PrintArray(arrayCount);
DateTime d2 = DateTime.Now;
int[] arrayInsert = SortByInserts(array);
Console.WriteLine("\nSorted by inserts in "+(DateTime.Now-d2));
PrintArray(arrayInsert);
DateTime d3 = DateTime.Now;
arrayBubble = BubbleSort(array);
Console.WriteLine("\nSorted by bubbles method in "+(DateTime.Now-d3));
PrintArray(arrayBubble);
PrintResult("The difference between min and max is ", DiffMinMax(arrayBubble));

int DiffMinMax(int[] arr)
{
    int result = arr[arr.Length-1]-arr[0];
    return result;
}

int[] BubbleSort(int[] arr)
{
    int[] outputArr = new int[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        outputArr[i] = array[i];
    }
    for(int i=0; i<outputArr.Length; i++)
    {
        int minPozition = i;
        for(int j=i+1; j<outputArr.Length; j++)
        {
            if(outputArr[j]<outputArr[minPozition])  minPozition = j;            
        }
        int temp = outputArr[i];
        outputArr[i] = outputArr[minPozition];
        outputArr[minPozition] = temp;        
    }
    return outputArr;
}

void PrintResult(string line, int num)
{
    Console.WriteLine("\n"+line+num);
}

int[] SortByInserts(int[] array)
{
    int[] outputArr = new int[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        outputArr[i] = array[i];
    }
    for (int i = 1; i < array.Length; i++)
    {
        int j=i;
        int current = outputArr[i];
        while(j>0&&outputArr[j-1]>current)
        {
            outputArr[j]=outputArr[j-1];
            j--;
        }
        outputArr[j]=current;
    }
    return outputArr;
}

int[] SortByCount(int[] arr, int[] range)
{
    int[] countArr = new int[range[1]-range[0]+1];
    for (int i=0; i<countArr.Length; i++)
    {
        countArr[i] = 0;
    }
    for(int i=0; i<arr.Length; i++)
    {
        countArr[arr[i]-range[0]] ++;
    }
    int numElemet = 0;
    int[] outputArr = new int[array.Length];
    for (int i = 0; i < countArr.Length; i++)
    {
        if(countArr[i]>0)
        {
            for(int j=1; j<=countArr[i]; j++)
            {
                outputArr[numElemet] = i+range[0];
                numElemet++;
            }
        }
    }
    return outputArr;
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

int[] GenArray(int len, int[] range)
{
    int[] array = new int[len];
    for(int i=0; i<len; i++)
    {
        array[i] = new Random().Next(range[0],range[1]+1);
    }
    return array;
}