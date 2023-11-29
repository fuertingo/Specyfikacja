public class ObliczanieWynagrodzenia
{
    public static float ObliczWynagrodzenie(float wartoscSprzedazy, float wysokoscPremii, float wartoscZaliczki)
    {
        float wynagrodzenie = wartoscSprzedazy * wysokoscPremii - wartoscZaliczki;

        if (wynagrodzenie < 0)
        {
            Console.WriteLine("Pracownik musi zwrócić pieniądze firmie.");
        }

        return wynagrodzenie;
    }
}