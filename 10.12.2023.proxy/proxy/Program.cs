// See https://aka.ms/new-console-template for more information

using proxy;

class Program
{
    static void Main()
    {
        ITextFile textFile = new ProxyTextFile("example.txt");

        textFile.PrintContent();

        textFile.PrintContent();
    }
}