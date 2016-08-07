using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZarzadzanieSerwisem.Models;

namespace ZarzadzanieSerwisem.DAL
{
    public class Initializer : DropCreateDatabaseAlways<SerwisContext>
    {
        protected override void Seed(SerwisContext context)
        {
            SeedPrzyjeteUrzadzenieData(context);
            base.Seed(context);
        }

        private void SeedPrzyjeteUrzadzenieData(SerwisContext context)
        {

            var KategoriaInit = new List<Kategoria>
            {
                new Kategoria() {KategoriaId = 1, KategoriaTytul = "Sony" },
                new Kategoria() {KategoriaId = 2, KategoriaTytul = "HP" },
                new Kategoria() {KategoriaId = 3, KategoriaTytul = "Samsung" },
                new Kategoria() {KategoriaId = 4, KategoriaTytul = "Toshiba" },
            };
            KategoriaInit.ForEach(i => context.Kategoria.Add(i));



            var DokumentInit = new List<Dokument>
            {
                new Dokument() {DokumentId = 1, Tytul = "Laptop Sony model so421", KategoriaId = 1  },
                new Dokument() {DokumentId = 2, Tytul = "Laptop Sony model so422", KategoriaId = 1  },
                new Dokument() {DokumentId = 3, Tytul = "Laptop Sony model so423", KategoriaId = 1 },
                new Dokument() {DokumentId = 4, Tytul = "Laptop HP model HP421", KategoriaId = 2  },
                new Dokument() {DokumentId = 5, Tytul = "Laptop HP model HP422", KategoriaId = 2 },
                new Dokument() {DokumentId = 6, Tytul = "Laptop HP model HP423", KategoriaId = 2  },
                new Dokument() {DokumentId = 7, Tytul = "Laptop HP model HP424", KategoriaId = 2  },
                new Dokument() {DokumentId = 8, Tytul = "Laptop HP model HP425", KategoriaId = 2 },
                new Dokument() {DokumentId = 9, Tytul = "Laptop HP model HP426", KategoriaId = 2  },
                new Dokument() {DokumentId = 10, Tytul = "Laptop HP model HP427", KategoriaId = 2 },
                new Dokument() {DokumentId = 11, Tytul = "Laptop HP model HP428", KategoriaId = 2  },
                new Dokument() {DokumentId = 12, Tytul = "Laptop Samsung model so421", KategoriaId = 3  },
                new Dokument() {DokumentId = 13, Tytul = "Laptop Samsung model so422", KategoriaId = 3 },
                new Dokument() {DokumentId = 14, Tytul = "Laptop Samsung model sa423", KategoriaId = 3  },
                new Dokument() {DokumentId = 15, Tytul = "Laptop Toshiba model to421", KategoriaId = 4 },
                new Dokument() {DokumentId = 16, Tytul = "Laptop Toshiba model to422", KategoriaId = 4 },
                new Dokument() {DokumentId = 17, Tytul = "Laptop Toshiba model to423", KategoriaId = 4 },
                new Dokument() {DokumentId = 18, Tytul = "Laptop Toshiba model to424", KategoriaId = 4 },

            };
            DokumentInit.ForEach(i => context.Dokument.Add(i));

            var Magazynierzy = new List<Magazynier>
            {
                new Magazynier() {MagazynierId = 1, MagazynierImie = "Daniel", MagazynierNazwisko= "Fabiański" },
                new Magazynier() {MagazynierId = 2, MagazynierImie = "Tomasz", MagazynierNazwisko = "Raczek" } ,
                new Magazynier() {MagazynierId = 3, MagazynierImie =  "Bartłomiej", MagazynierNazwisko = "Muzykalny" }
            };
            Magazynierzy.ForEach(i => context.Magazynier.Add(i));

            var Serwisanci = new List<Serwisant>
            {
                new Serwisant() {SerwisantId = 1, SerwisantImie= "Marcin", SerwisantNazwisko = "Poczatek"},
                new Serwisant() {SerwisantId = 2, SerwisantImie= "Damian", SerwisantNazwisko = "Loczek"},
                new Serwisant() {SerwisantId = 3, SerwisantImie= "Grzegorz", SerwisantNazwisko = "Rogalski"},
                new Serwisant() {SerwisantId = 4, SerwisantImie= "Wojciech", SerwisantNazwisko = "Pierniczek"},
            };
            Serwisanci.ForEach(i => context.Serwisant.Add(i));

            var StatusNapraw = new List<StatusNaprawy>
            {
                new StatusNaprawy () {StatusNaprawyId = 1, StatusNaprawyNazwa = "Zniszczone u klient - brak możliwości naprawy"},
                new StatusNaprawy () {StatusNaprawyId = 2, StatusNaprawyNazwa = "Wycenione - oczekiwanie na akceptacje przez klienta" },
                new StatusNaprawy () {StatusNaprawyId = 3, StatusNaprawyNazwa = "Naprawione" }  ,
                new StatusNaprawy () {StatusNaprawyId = 4, StatusNaprawyNazwa = "Zniszczone podczas naprawy - SCRAP" } ,
                new StatusNaprawy () {StatusNaprawyId = 5, StatusNaprawyNazwa = "Brak części" },
            };
            StatusNapraw.ForEach(i => context.StatusNaprawy.Add(i));

            var StatusMagazyn = new List<StatusMagazynowy>
            {
                new StatusMagazynowy () {StatusMagazynowyId = 1, StatusMagazynowyNazwa = "Przyjęte do magazynu"},
                new StatusMagazynowy () {StatusMagazynowyId = 2, StatusMagazynowyNazwa = "Przekazane do naprawy" },
                new StatusMagazynowy () {StatusMagazynowyId = 3, StatusMagazynowyNazwa = "Po Naprawie - OK" }  ,
                new StatusMagazynowy () {StatusMagazynowyId = 4, StatusMagazynowyNazwa = "Po Naprawie - SCRAP" } ,
                new StatusMagazynowy () {StatusMagazynowyId = 5, StatusMagazynowyNazwa = "Brak części" },
            };
            StatusMagazyn.ForEach(i => context.StatusMagazynowy.Add(i));

            var Usterki = new List<Usterka>
            {
                new Usterka () {UsterkaId = 1, UsterkaNazwa = "Uszkodzone mechanicznie"},
                new Usterka () {UsterkaId = 2, UsterkaNazwa = "Niedolut" },
                new Usterka () {UsterkaId = 3, UsterkaNazwa = "Poprawa czyjejś naprawy" }  ,
                new Usterka () {UsterkaId = 4, UsterkaNazwa = "SCRAP" } ,
                new Usterka () {UsterkaId = 5, UsterkaNazwa = "Uszkodzone wewnętrznie" },
            };
            Usterki.ForEach(i => context.Usterka.Add(i));

            var wNaprawie = new List<PrzyjeteUrzadzenie>
           {
                new PrzyjeteUrzadzenie() {
                    PrzyjeteUrzadzenieId = 1,
                    PrzyjeteUrzadzenieTytul = "Laptop HP",
                    PrzyjeteUrzadzenieInformacje = "Laptop Zalany. Klient zostawił laptop na dworze podczas deszczu.Laptop Zalany. Klient zostawił laptop na dworze podczas deszczu.Laptop Zalany. Klient zostawił laptop na dworze podczas deszczu.Laptop Zalany. Klien",
                    PrzyjeteUrzadzenieNazwaKlienta = "Bartłomiej Nowak",
                    PrzyjeteUrzadzenieTelKontaktowy = "721319573",
                    PrzyjeteUrzadzenieEmail = "alsenq@gmail.com",
                    PrzyjeteUrzadzenieDataPrzyjecia = System.DateTime.Now,
                    StatusMagazynowyId = 1,
                    StatusNaprawyId = 1,
                    PrzyjeteUrzadzenieWycena = 650,
                    MagazynierId = 1,
                    SerwisantId = 1 },

                new PrzyjeteUrzadzenie() {
                    PrzyjeteUrzadzenieId = 2,
                    PrzyjeteUrzadzenieTytul = "Laptop HP",
                    PrzyjeteUrzadzenieInformacje = "Laptop Zalany. Klient zostawił laptop na dworze podczas deszczu.Laptop Zalany. Klient zostawił laptop na dworze podczas deszczu.Laptop Zalany. Klient zostawił laptop na dworze podczas deszczu.Laptop Zalaz",
                    PrzyjeteUrzadzenieNazwaKlienta = "Bartłomiej Nowak",
                    PrzyjeteUrzadzenieTelKontaktowy = "721319573",
                    PrzyjeteUrzadzenieEmail = "alsenq@gmail.com",
                    PrzyjeteUrzadzenieDataPrzyjecia = System.DateTime.Now,
                    StatusMagazynowyId = 1,
                    StatusNaprawyId = 1,
                    PrzyjeteUrzadzenieWycena = 650,
                    MagazynierId = 1,
                    SerwisantId = 1, },
                 };
            wNaprawie.ForEach(k => context.PrzyjeteUrzadzenie.Add(k));

            var UrzadzWNaprawie = new List<UrzadzNapr>
            {
                new UrzadzNapr {
                    UrzadzNaprId = 1,
                    PrzyjeteUrzadzenieId = 1,
                UrzadzNaprDataWpisu = System.DateTime.Now,
                StatusNaprawyId = 2,
                SerwisantId = 1,
                Usterka1Id = 3,
                Usterka2Id = 3,
                UrzadzNaprPozycja1 = "J301",
                UrzadzNaprPozycja2 = "J302",
                UrzadzNaprPozycja3 = "J303",
                UrzadzNaprPozycja4 = "J304",
                UrzadzNaprBrakujacaCzesc1 = "Zawias metalowy",
                UrzadzNaprBrakujacaCzesc2 = "Zawias Plastikowy",
                }
            };
            UrzadzWNaprawie.ForEach(k => context.UrzadzNapr.Add(k));


            //new PrzyjeteUrzadzenie() {PrzyjeteUrzadzenieId = 2, PrzyjeteUrzadzenieInformacje = "Urwana Cewka. Nieudana naprawa w innym serwisie. Poprzednio problemy z grafiką. Uszkodzony prawdopodobnie mostek północny.",
            //    PrzyjeteUrzadzenieTytul = "Płyta Główna MSI", PrzyjeteUrzadzenieNazwaKlienta = "Ireneusz Pomyślny", PrzyjeteUrzadzenieWycena = 300, MagazynierId = 1, PrzyjeteUrzadzenieDataPrzyjecia = System.DateTime.Now  },

            //new PrzyjeteUrzadzenie() {PrzyjeteUrzadzenieId = 3, PrzyjeteUrzadzenieInformacje = "Nagle przestał się włączać. Informacja od klienta: Laptop ostatnio często się przegrzewał i resetował.",
            //    PrzyjeteUrzadzenieTytul = "Laptop Dell", PrzyjeteUrzadzenieNazwaKlienta = "Firma: Elektryczni Kowalscy sp. z o.o", PrzyjeteUrzadzenieWycena = 700 , MagazynierId = 1, PrzyjeteUrzadzenieDataPrzyjecia = System.DateTime.Now },

            //new PrzyjeteUrzadzenie() {PrzyjeteUrzadzenieId = 4, PrzyjeteUrzadzenieInformacje = "Urwane wejścia gniazda sluchawkowego.Urwane wejścia gniazda sluchawkowego. Urwane wejścia gniazda sluchawkowego. Urwane wejścia gniazda sluchawkowego. Urwane wejścia gniazda sluchawkowego. Urwane wejścia gniazda sluchawkowego. Inormacja od klienta: komputer uszkodzony podczas przeprowadzki, sprawdzić czy nie zostały uszkodzone inne podzespoły",
            //    PrzyjeteUrzadzenieTytul = "Stacja Komputerowa gotowa Tesco", PrzyjeteUrzadzenieNazwaKlienta = "Konrad Kowalczyk", PrzyjeteUrzadzenieWycena = 50, MagazynierId = 1, PrzyjeteUrzadzenieDataPrzyjecia = System.DateTime.Now  }




            context.SaveChanges();
        }
    }
}