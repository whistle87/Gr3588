System.Random numberSintezator = new System.Random();

int num = new Random().Next(100,1000);
Console.WriteLine(num);

// int firstNumber = num/100;
// int secondNumber = num%10;

int result  = (num/100)*10+(num%10);

Console.WriteLine(result);