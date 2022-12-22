//solution
double[] equation1 = ReadData("Enter parametrs of 1 equation (y = k1*x+b1 ) in format k1,b1");
double[] equation2 = ReadData("Enter parametrs of 2 equation (y = k2*x+b2 ) in format k2,b2");
double[] equation3 = ReadData("Enter parametrs of 3 equation (y = k3*x+b3 ) in format k3,b3");
if(equation1[0]==equation2[0]||equation1[0]==equation3[0]||equation2[0]==equation3[0])
{
    PrintData("Lines don't intersect");
}
else
{
    double[] point1 = IntersectionPoint(equation1, equation2);
    double[] point2 = IntersectionPoint(equation1, equation3);
    double[] point3= IntersectionPoint(equation3, equation2);
    PrintData("Triangle area is  "+TriangleArea(point1, point2, point3));
}

//method calculate an area between the interseption points of function graphs
double TriangleArea(double[] point1, double[] point2, double[] point3)
{
    double areaTr = Math.Abs((point2[0]-point1[0])*(point3[1]-point1[1])-(point3[0]-point1[0])*(point2[1]-point1[1]))/2;
    return areaTr;
}
//method find a point of intersection of two lines
double[] IntersectionPoint(double[] equat1, double[] equat2)
{
    double[] point = new double[2];
    point[0] = (equat2[1]-equat1[1])/(equat1[0]-equat2[0]);
    point[1] = (point[0]*equat1[0]+equat1[1]);
    return point;
}
//method read user's data
double[] ReadData(string message)
{
    Console.WriteLine(message);    
    string[] paramString = (Console.ReadLine()??"0").Split(',',StringSplitOptions.RemoveEmptyEntries);
    double[] paramEquation = new double[2];
    paramEquation[0] = double.Parse(paramString[0]);
    paramEquation[1] = double.Parse(paramString[1]);
    return paramEquation;
}
//method print data to console
void PrintData(string msg)
{
    Console.WriteLine(msg);
}