using System;
public class Program
{

    public static void Main()
    {
        double a, b, c;
        Console.WriteLine("Witaj w programie Kalkulator");      // wiadomość powitalna
        Console.WriteLine("[1] - Standard\n[2] - Matura");
    labelMode:;
        Console.Write("Podaj tryb kalkulatora: ");
        string load = Console.ReadLine();
        switch (Parser(load))       // wybór trybu matura standard 
        {
            case 1:     // tryb standard
                {
                    System.Console.Clear();     // wyczyszczenie ekranu
                    Console.WriteLine("[0] Wyjście z programu");
                    Console.WriteLine("[1] Dodawanie");
                    Console.WriteLine("[2] Odejmowanie");
                    Console.WriteLine("[3] Mnożenie");
                    Console.WriteLine("[4] Dzielenie");
                    Console.Write("Podaj a: ");
                    a = Parser(load);       //  wczytanie liczby wydaje sie nie działać !!!

                    switch (Parser(load))
                    {
                        case 0:     // wyjście z programu
                            {

                                break;
                            }
                        case 1:     // dodawanie
                            {

                                break;
                            }
                        case 2:     // odejmowanie
                            {

                                break;
                            }
                        case 3:     // mnożenie
                            {

                                break;
                            }
                        case 4:
                            {       // dzielenie

                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    break;
                }
            case 2:     // tryb matury
                { Console.WriteLine("Implementacja matury później ;)"); break; }
            case 3:     // wyjście z aplikacji
                { Console.WriteLine("Do POLICZENIA! HA"); break; }
            default:
                {
                    Console.WriteLine("Podałeś złą wartość.");
                    goto labelMode;
                }
        }

    }
    public static double Parser(string input)      // metoda parsująca
    {
        double a = 0;
        try         //  zabezpieczenie przed wprowadzeniem liter i znaków
        {
            a = double.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Podana wartość nie jest liczbą.");
        }
        return a;
    }
}