using System;
public class Program
{

    public static void Main()
    {
        double a = 0;
        double b, c;        // chyba się nie przydadzą
        Console.WriteLine("Witaj w programie Kalkulator");      // wiadomość powitalna
        Console.WriteLine("[1] - Standard\n[2] - Matura\n[3] - Wyjście");
    labelMode:;
        Console.Write("Podaj tryb kalkulatora: ");
        switch (Parser())       // wybór trybu matura standard 
        {
            case 1:     // tryb standard
                {
                    string operation;
                    do      // pętla na cały case 1 wydaje się nie działać - program musi się zatrzymać aby wyświetlić wynik
                    {
                        System.Console.Clear();     // wyczyszczenie ekranu
                        Console.WriteLine("[Q] Wyjście z programu");
                        Console.WriteLine("[+] Dodawanie");
                        Console.WriteLine("[-] Odejmowanie");
                        Console.WriteLine("[*] Mnożenie");
                        Console.WriteLine("[/] Dzielenie");
                        Console.WriteLine("Podaj a\nWybierz operację\nPodaj b");

                        a = Parser();
                        operation = Console.ReadLine();     // wybierz operację

                        if (operation == "+")
                        {       // dodawanie
                            a = Add(a);
                            Console.WriteLine(a);
                        }
                        else if (operation == "-")
                        {       // odejmowanie
                            a = Substract(a);
                            Console.WriteLine(a);
                        }
                        else if (operation == "*")
                        {       // mnożenie
                            a = Multiply(a);
                            Console.WriteLine(a);
                        }
                        else if (operation == "/")
                        {       // dzielenie
                            a = Devide(a);
                            Console.WriteLine(a);
                        }
                    } while (operation != "Q");     // warunek kończący pętlę i program
                    break;
                }
            case 2:     // tryb matury
                { Console.WriteLine("Implementacja matury później ;)"); goto labelMode; }
            case 3:     // wyjście z aplikacji
                { Console.WriteLine("Do POLICZENIA! HA"); break; }
            default:
                {
                    Console.WriteLine("Podałeś złą wartość.");
                    goto labelMode;
                }
        }

    }
    public static double Parser()     // metoda parsująca
    {
        string input = Console.ReadLine();
        double val = 0;
        try         //  zabezpieczenie przed wprowadzeniem liter i znaków
        {
            val = double.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Podana wartość nie jest liczbą.");
        }
        return val;
    }
    public static double Add(double a)      // metoda dodająca a (wprowadzone jako parametr) do b
    {
        double b = Parser();
        return a + b;
    }
    public static double Substract(double a)      // metoda dodająca a (wprowadzone jako parametr) do b
    {
        double b = Parser();
        return a - b;
    }
    public static double Multiply(double a)      // metoda dodająca a (wprowadzone jako parametr) do b
    {
        double b = Parser();
        return a * b;
    }
    public static double Devide(double a)      // metoda dodająca a (wprowadzone jako parametr) do b
    {
        double b = Parser();
        return a / b;
    }
}