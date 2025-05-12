using ZarzadzanieUrzadzeniami.Interfejsy;
using ZarzadzanieUrzadzeniami.Urzadzenia;

namespace ZarzadzanieUrzadzeniami
{
    class InteligentnyDom
    {
        private string _nazwaDomu;
        private List<Urzadzenie> _listaUrzadzen = new();

        public InteligentnyDom(string nazwaDomu)
        {
            _nazwaDomu = nazwaDomu;
        }

        public void DodajUrzadzenie(Urzadzenie urzadzenie)
        {
            _listaUrzadzen.Add(urzadzenie);
        }

        public void UsunUrzadzeniePoID(int id)
        {
            var urzadzenie = _listaUrzadzen.FirstOrDefault(u => u.ID == id);
            if (urzadzenie != null)
            {
                _listaUrzadzen.Remove(urzadzenie);
            }
        }

        public Urzadzenie? ZnajdzUrzadzeniePoID(int id)
        {
            return _listaUrzadzen.FirstOrDefault(u => u.ID == id);
        }

        public void WyswietlStatusWszystkichUrzadzen()
        {
            Console.WriteLine("Statusy urządzeń w domu: " + _nazwaDomu);
            foreach (var urzadzenie in _listaUrzadzen)
            {
                Console.WriteLine(urzadzenie.PobierzSzczegolowyOpis());
            }
        }

        public void WlaczWszystkiePrzelaczalne()
        {
            foreach (var urzadzenie in _listaUrzadzen)
            {
                if (urzadzenie is IPrzelaczenie przelaczalne)
                {
                    przelaczalne.Wlacz();
                }
            }
        }

        public void UstawWszystkieRegulowalne(int nowyPoziom)
        {
            foreach (var urzadzenie in _listaUrzadzen)
            {
                if (urzadzenie is IRegulowanie regulowalne)
                {
                    regulowalne.UstawPoziom(nowyPoziom);
                }
            }
        }
    }
}
