using System;

public class Wczytywanie
{
    public static void WczytajDane(out float miesiecznaWartoscSprzedazy, out float wartoscZaliczki)
    {
        Console.WriteLine("Podaj miesięczną wartość sprzedaży:");
        float.TryParse(Console.ReadLine(), out miesiecznaWartoscSprzedazy);

        Console.WriteLine("Podaj wartość pobranej zaliczki:");
        float.TryParse(Console.ReadLine(), out wartoscZaliczki);
    }
}