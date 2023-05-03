
using Lab_4;

class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText($@"{Environment.CurrentDirectory}\..\..\..\some.txt");
        char[] symbols = text.ToCharArray();

        Console.WriteLine(text);
        Console.WriteLine();

        int uppercaseCount = MyTextReader.CountUppercaseLetters(symbols);
        Console.WriteLine($"Number of uppercase letters in the file: {uppercaseCount}");

        List<char> symbolList = new List<char>(symbols);
        int uppercaseCountList = MyTextReader.CountUppercaseLetters(symbolList);
        Console.WriteLine($"Number of uppercase letters in the file (using List): {uppercaseCountList}");
    }

    
}
