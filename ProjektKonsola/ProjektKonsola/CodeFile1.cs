using System;
public class Calculator
{
    private double a;
    private double b;
}
public class Program
{
    public static double Parser(string text)
    {
        double a = 0;
        try
        {
            a = double.Parse(text);
        }
        catch (Exception e)
        {
            Console.WriteLine("To nie cyfra! Proszę podać prawidłową wartość.");
        }
        return a;
    }

    public static void Main()
    {
        Console.WriteLine("Witaj w TurboCalculator - Console Edition!\nWersja standardowa jest ustawiona domyślnie.");
        Console.WriteLine("Proszę wcisnąć 'T' aby przejść do werjsi Turbo.");
        //if ()
        /*string getvalue = Console.ReadLine();
        double a = Parser(getvalue);
        Console.WriteLine("a = " + a);*/
    }
}
