void Test (int numFirst, int numSecond)
{
    bool result = (numFirst/numSecond==numSecond);
    if(result==true)Console.WriteLine("Number "+numFirst+" is a square of "+numSecond);
    else Console.WriteLine("Number "+numFirst+" is not a square of "+numSecond);
}

int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");
Test(number1,number2);
Test(number2,number1);