// solution
int inputNum = ReadData("Enter number ");
string[] firstRow = LineBuild(inputNum,1).Split(" ");
string[] secondRow = LineBuild(inputNum,3).Split(" ");
Console.Write(" ");
for(int i=1; i<=LineBuild(inputNum,3).Length; i++) {Console.Write("_");}
Console.Write("\n");
// add spaces to first row in accordance with the secont row
string[] space = new string[inputNum];
for(int num=0; num< inputNum; num++)
{
    for (int i=1; i<=(secondRow[num].Length-firstRow[num].Length); i++) 
    {
        space[num] = space[num] + " ";
    }
    firstRow[num]= space[num] + firstRow[num];
}
// create a line between rows
string[] line = new string[inputNum];
for(int num=0; num < inputNum; num ++)
{
    line[num]= String.Concat(Enumerable.Repeat("_", secondRow[num].Length));
}
// print table
PrintData(firstRow);
PrintData(line);
PrintData(secondRow);
PrintData(line);

//method read user's data
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}

// method calculate result
string LineBuild(int num, int pow)
 {
    string line = string.Empty;
    for (int i=1; i<num; i++)
    {
        line = line + Math.Pow(i,pow) + " ";
    }
    line = line + Math.Pow(num,pow);
    return line;
 }

// method print row
void PrintData(string[] line)
{
    foreach (var num in line)
    {
        Console.Write($"|{num}");
    }
    Console.WriteLine("|");
}