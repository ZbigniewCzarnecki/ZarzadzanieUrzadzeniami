namespace ZarzadzanieUrzadzeniami.Urzadzenia;

class CzujnikRuchu : Urzadzenie
{
    private int _czasWykrycia = 1;

    public CzujnikRuchu(int id, string nazwa, string lokalizacja) : base(id, nazwa, lokalizacja, Status.Wlaczone)
    {
    }

    public override string PobierzSzczegolowyOpis()
    {
        return "\n" + Nazwa + ":"
            + "\nID: " + ID
            + "\nStatus: " + PobierzStatus()
            + "\nLokalizacja: " + Lokalizacja
            + "\nCzas Wykrycia: " + _czasWykrycia
            + "\n";
    }
}
