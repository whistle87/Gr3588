// create instance of the class randomazer
System.Random numberSintezator = new System.Random();
// // // get new randon number
//  int number = numberSintezator.Next(10,100);
// // //print number
// // Console.WriteLine(number);
// // //get first and second number separately
//  int firstNumber = number/10;
//  int secondNumber = number%10;
// // // compare firs and second number and print max
// if(firstNumber > secondNumber)
// {
//     Console.WriteLine(firstNumber);
// }
// else
// {
//     Console.WriteLine(secondNumber);
// }

//variant 2
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();

Console.WriteLine(digits);

int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);