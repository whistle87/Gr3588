//solutiuon
string inputLine = ReadData("Enter a list of names: ");
string[] names = SplitNames(inputLine);
int randomNum = new Random().Next(0,names.Length);
PrintResult(names[randomNum]);

//method create names array
string[] SplitNames(string line)
{
    string[] names = line.Split(", ", StringSplitOptions.RemoveEmptyEntries);

    return names;
}
//method read data fron console
string ReadData(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine()??"0";
    return line;
}
//method print result
void PrintResult(string line)
{
    Console.WriteLine(line);
}