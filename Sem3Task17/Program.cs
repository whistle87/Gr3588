// // rading data
// Console.WriteLine("Enter coordinate x");
// int coordX = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("Enter coordinate y");
// int coordY = int.Parse(Console.ReadLine()??"0");

int coordX = ReadData("Enter x coordinate");
int coordY = ReadData("Enter y coordinate");
PrintQuarterTest();
// method defines a quarter by coordinate
void PrintQuarterTest()
 {
 if (coordX>0&&coordY>0) Console.WriteLine("Point in 1 quarter");
 if (coordX>0&&coordY<0) Console.WriteLine("Point in 2 quarter");
 if (coordX<0&&coordY<0) Console.WriteLine("Point in 3 quarter");
 if (coordX<0&&coordY>0) Console.WriteLine("Point in 4 quarter");
 }
//method read user's data
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}