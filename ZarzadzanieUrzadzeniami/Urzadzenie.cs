namespace ZarzadzanieUrzadzeniami;
abstract class Urzadzenie
{
    private int _idUrzadzenia;
    private string _nazwaPrzyjazna;
    private string _lokalizacja;
    private Status _status = Status.Wylaczone;
   
    protected enum Status
    {
        Wlaczone,
        Wylaczone
    }

    protected string Nazwa
    {
        get => _nazwaPrzyjazna;
        set => _nazwaPrzyjazna = value;
    }

    protected Urzadzenie(int id, string nazwa, string lokalizacja, Status status)
    {
        _idUrzadzenia = id;
        _nazwaPrzyjazna = nazwa;
        _lokalizacja = lokalizacja;
        _status = status;
    }

    protected Status PobierzStatus()
    {
        return _status;
    }

    protected void ZmienStatus(Status nowyStatus)
    {
        _status = nowyStatus;
    }

    public abstract string PobierzSzczegolowyOpis();
}
