using ZarzadzanieUrzadzeniami.Urzadzenia;

Termostat termostat = new Termostat(1, "Termostat Piętro", "Korytarz Piętro");
Lampa lampa = new Lampa(1, "LampaNocna", "Sypialnia");

Console.WriteLine(lampa.PobierzSzczegolowyOpis());
lampa.Wlacz();
Console.WriteLine(lampa.PobierzSzczegolowyOpis());
lampa.Wylacz();
Console.WriteLine(lampa.PobierzSzczegolowyOpis() + " " + termostat.PobierzSzczegolowyOpis());

termostat.UstawPoziom(22);
Console.WriteLine(termostat.PobierzSzczegolowyOpis());
