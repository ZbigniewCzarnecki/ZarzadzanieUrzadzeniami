using ZarzadzanieUrzadzeniami.Interfejsy;

namespace ZarzadzanieUrzadzeniami.Urzadzenia;

class Lampa : Urzadzenie, IPrzelaczenie
{
    public Lampa(int id, string nazwa, string lokalizacja) : base(id, nazwa, lokalizacja, Status.Wylaczone)
    {
    }

    public void Wlacz()
    {
        ZmienStatus(Status.Wlaczone);
    }

    public void Wylacz()
    {
        ZmienStatus(Status.Wylaczone);
    }

    public override string PobierzSzczegolowyOpis()
    {
        return "\n" + Nazwa + ":"
            + "\nID: " + ID
            + "\nStatus: " + PobierzStatus()
            + "\nLokalizacja: " + Lokalizacja
            + "\n";
    }
}
