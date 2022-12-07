//method read user's data
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}

// method defines a quarter by coordinate
void PrintRange(int num)
 {
 if (num == 1) Console.WriteLine("x>0, y>0");
 if (num == 2) Console.WriteLine("x>0, y<0");
 if (num == 3) Console.WriteLine("x<0, y<0");
 if (num == 4) Console.WriteLine("x<0, y>0");
 }

int quarter = ReadData("Enter a quarter");
PrintRange(quarter);


