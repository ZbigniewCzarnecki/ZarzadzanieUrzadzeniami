namespace ZarzadzanieUrzadzeniami;

class Lampa : Urzadzenie, IPrzelaczenie, IRegulowanie
{
    private float _poziomJasnosci;

    public Lampa(int id, string nazwa, string lokalizacja) : base(id, nazwa, lokalizacja, Status.Wylaczone)
    {
    }

    public void Wlacz()
    {
        ZmienStatus(Status.Wlaczone);
    }

    public void Wylacz()
    {
        ZmienStatus(Status.Wlaczone);
    }

    public void UstawWartosc(float nowaWartosc)
    {
        _poziomJasnosci = nowaWartosc;
    }

    public override string PobierzSzczegolowyOpis()
    {
        return Nazwa + ": " + PobierzStatus() + "\n";
    }
}
