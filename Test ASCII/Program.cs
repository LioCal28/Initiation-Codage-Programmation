using System;
using System.IO;

class Program
{
    static void Main()
    {
        string asciiImage = File.ReadAllText("asciicid.txt");
        Console.WriteLine(asciiImage);
    }
}