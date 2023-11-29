


public class ObliczaniePremii
{
    public static float ObliczPremie(float wartoscSprzedazy)
    {
        float wysokoscPremii;

        if (wartoscSprzedazy < 10000)
        {
            wysokoscPremii = 0.1f; // 10%
        }
        else if (wartoscSprzedazy >= 10000 && wartoscSprzedazy <= 14999)
        {
            wysokoscPremii = 0.12f; // 12%
        }
        else if (wartoscSprzedazy >= 15000 && wartoscSprzedazy <= 17999)
        {
            wysokoscPremii = 0.14f; // 14%
        }
        else if (wartoscSprzedazy >= 18000 && wartoscSprzedazy <= 21999)
        {
            wysokoscPremii = 0.16f; // 16%
        }
        else
        {
            wysokoscPremii = 0.18f; // 18%
        }

        return wysokoscPremii;
    }
}