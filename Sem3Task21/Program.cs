//solution
int[] pointA = ReadData("Enter coordinate point A in format x,y,z ");
int[] pointB = ReadData("Enter coordinate point B in format x,y,z ");
PrintData("Length beetwen points ", CalculateLength(pointA[0],pointA[1],pointA[2],pointB[0],pointB[1],pointB[2]));

//method read user's data
int[] ReadData(string message)
{
    Console.WriteLine(message);
    string inputString = Console.ReadLine()??"0";
    char[] coordString = inputString.ToCharArray();
    int[] coordinate = new int[3];
    coordinate[0] = ((int)coordString[0])-48;
    coordinate[1] = ((int)coordString[2])-48;
    coordinate[2] = ((int)coordString[4])-48;
    return coordinate;
}
// method calculate result
double CalculateLength(double x1,double y1,double z1,double x2,double y2, double z2)
 {
    double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return result;
 }
// method print result
void PrintData(string msg, double len)
{
    Console.WriteLine(msg+len);
}
