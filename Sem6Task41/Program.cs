//solution
int numOfPress = ReadData ("Enter an amount of keyboar press ");
PrintResult($"Press any kyes {numOfPress} times ");
string inputString = ReadKeyboardPress(numOfPress);
int[] inputNum = ConvertToIntArray(inputString);
PrintResult("\nAmount of positive is "+PositiveCount(inputNum));

//method count an amont of positive numbers in array
int PositiveCount(int[] num)
{
    int result = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i]>0) result++;
    }
    return result;
}

//method read data from console every keyboard press and return a string with input data
string ReadKeyboardPress(int num)
{
    string inputString = String.Empty;
    for (int i=1; i<= num; i++)
    {
        string key = Console.ReadKey().Key.ToString();
        switch (key)
        {
            case "NumPad0": inputString = inputString + "0"; break;
            case "D0": inputString = inputString + "0"; break;
            case "D1": inputString = inputString + "1"; break;
            case "NumPad1": inputString = inputString + "1"; break;
            case "NumPad2": inputString = inputString + "2"; break;
            case "D2": inputString = inputString + "2"; break;
            case "D3": inputString = inputString + "3"; break;
            case "NumPad3": inputString = inputString + "3"; break;
            case "NumPad4": inputString = inputString + "4"; break;
            case "D4": inputString = inputString + "4"; break;
            case "NumPad5": inputString = inputString + "5"; break;
            case "D5": inputString = inputString + "5"; break;
            case "D6": inputString = inputString + "6"; break;
            case "NumPad6": inputString = inputString + "6"; break;
            case "D7": inputString = inputString + "7"; break;
            case "NumPad7": inputString = inputString + "7"; break;
            case "D8": inputString = inputString + "8"; break;
            case "NumPad8": inputString = inputString + "8"; break;
            case "D9": inputString = inputString + "9"; break;
            case "NumPad9": inputString = inputString + "9"; break;
            case "Subtract": inputString = inputString + "-"; break;
            case "OemMinus": inputString = inputString + "-"; break;
            default: inputString = inputString + ","; break;
        }        
    }
    return inputString;
}
// method convert string array to array of numbers
int[] ConvertToIntArray(string inputLine)
{
    char[] inputCharArray = inputLine.ToCharArray();
    int count = 0;
    string[] inputNumStr = new string[inputCharArray.Length];
    for (int i = 0; i < inputCharArray.Length; i++)
    {
        if (inputCharArray[i]=='-')
        {
            count ++;
            inputNumStr[count] = "-";
        }
        else
        {
            if(char.IsDigit(inputCharArray[i]))
            {
                inputNumStr[count] =inputNumStr[count] + inputCharArray[i];
            }
            else
            {
                count++;
            }
        }
    }
    int[] inputNum = new int[inputNumStr.Length];
    for (int i = 0; i < inputNumStr.Length; i++)
    {
        int.TryParse(inputNumStr[i], out inputNum[i]);
    }    
    return inputNum;
}

//method print result
void PrintResult(string line)
{
    Console.WriteLine(line);
}
//method read data from console
int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine()??"0");
    return inputNum;
}