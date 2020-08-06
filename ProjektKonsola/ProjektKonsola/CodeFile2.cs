using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Kalkulator");
        double a;
        double b;
        double c;
        string load = "";
        do          // nadanie wartości  parsowanie a
        {
            Console.WriteLine("Podaj a");
            try
            {
                load = Console.ReadLine();
                double.TryParse(load, out a );
            }
            catch(Exception e)      // ciało catch się  nie odpala w przypadku błędnych danych
            {
                Console.WriteLine("Zła wartość, proszę podać liczbę.");
            }
        } while (double.TryParse(load,  out a) == false);
        do          // nadanie wartości parsowanie  b
        {
            Console.WriteLine("Podaj b");
            try
            {
                load = Console.ReadLine();
                double.TryParse(load, out b);
            }
            catch       // nieważne czy z (Exception e) czy bez
            {
                Console.WriteLine("Zła wartość, proszę podać liczbę.");
            }
        } while (double.TryParse(load, out b) == false);
    }
}