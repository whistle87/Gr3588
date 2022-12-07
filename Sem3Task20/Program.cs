//method read user's data
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}
//solution
int coordX1 = ReadData("Enter coordinate x1");
int coordY1 = ReadData("Enter coordinate y1");
int coordX2 = ReadData("Enter coordinate x2");
int coordY2 = ReadData("Enter coordinate y2");

// method calculate result
double CalculateLength(double x1,double y1,double x2,double y2)
 {
    double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    return result;
 }

// method print result
void PrintData(string msg, double len)
{
    Console.WriteLine(msg+len);
}

PrintData("Length beetwen points ", CalculateLength(coordX1,coordY1,coordX2,coordY2));