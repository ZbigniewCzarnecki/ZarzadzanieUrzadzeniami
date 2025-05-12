using ZarzadzanieUrzadzeniami.Interfejsy;

namespace ZarzadzanieUrzadzeniami.Urzadzenia;

class Termostat : Urzadzenie, IRegulowanie
{
    private int _temperatura;

    public Termostat(int id, string nazwa, string lokalizacja) : base(id, nazwa, lokalizacja, Status.Wlaczone)
    {
    }

    public override string PobierzSzczegolowyOpis()
    {
        return "\n" + Nazwa + ":"
            + "\nID: " + ID
            + "\nStatus: " + PobierzStatus()
            + "\nLokalizacja: " + Lokalizacja
            + "\nDocelowana Temperatura: " + _temperatura + "°C";
    }

    public void UstawPoziom(int nowaWartosc)
    {
        _temperatura = nowaWartosc;
    }
}
