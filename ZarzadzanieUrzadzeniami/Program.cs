using ZarzadzanieUrzadzeniami;
using ZarzadzanieUrzadzeniami.Interfejsy;
using ZarzadzanieUrzadzeniami.Urzadzenia;

InteligentnyDom _domGrusza = new("Dom Pod Gruszą");
_domGrusza.DodajUrzadzenie(new Lampa(1, "Lampka nocna", "Sypialnia"));
_domGrusza.DodajUrzadzenie(new Lampa(2, "Lampka do czytania", "Gabinet"));
_domGrusza.DodajUrzadzenie(new Lampa(3, "Żyrandol", "Jadalnia"));
_domGrusza.DodajUrzadzenie(new Termostat(4, "Termostat Piętro", "Korytarz Piętro"));
_domGrusza.DodajUrzadzenie(new Termostat(5, "Termostat Parter", "Korytarz Parter"));
_domGrusza.DodajUrzadzenie(new CzujnikRuchu(6, "Czujnik światła przed drzwiami wejściowymi", "Drzwi wejściwe"));
_domGrusza.DodajUrzadzenie(new CzujnikRuchu(7, "Czujnik światła korytarz", "Korytarz Piętro"));

_domGrusza.WyswietlStatusWszystkichUrzadzen();

_domGrusza.UsunUrzadzeniePoID(7);
_domGrusza.WlaczWszystkiePrzelaczalne();
_domGrusza.UstawWszystkieRegulowalne(34);

var _urzadzenieID5 = _domGrusza.ZnajdzUrzadzeniePoID(5);
if(_urzadzenieID5 is IRegulowanie regulowalne)
{
    regulowalne.UstawPoziom(19);
}

_domGrusza.WyswietlStatusWszystkichUrzadzen();
