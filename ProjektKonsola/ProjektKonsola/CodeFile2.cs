using System;
public class Program
{
    public static int Parser(string input)
    {
        int a = int.Parse(input);
        return a;
    }
    public static void Main()
    {
        Console.WriteLine("Witaj w programie Kalkulator");
        Console.WriteLine("Podaj tryb kalkulatora: ");
        Console.WriteLine("[1] - Standard\n[2] - Matura");
        string mode = Console.ReadLine();
        switch (Parser(mode))
        {
            case 1:
                { Console.WriteLine("coś"); break; }
            case 2:
                { break; }
            default:
                {
                    break;
                }
        }

    }
}