using ZarzadzanieUrzadzeniami;

Lampa lampa = new Lampa(1, "LampaNocna", "Sypialnia");
Console.WriteLine(lampa.PobierzSzczegolowyOpis());
lampa.Wlacz();
Console.WriteLine(lampa.PobierzSzczegolowyOpis());
