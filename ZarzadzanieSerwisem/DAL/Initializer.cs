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
            SeedSerwisowaneData(context);
            base.Seed(context);
        }

        private void SeedSerwisowaneData(SerwisContext context)
        {
            var wNaprawie = new List<PrzyjeteUrzadzenie>
           {
                new PrzyjeteUrzadzenie() {SerwisowaneId = 1, SerwisowaneTresc = "Laptop Zalany. Klient zostawił laptop na dworze podczas deszczu.", SerwisowaneTytul = "Laptop HP", SerwisowaneNazwaKlienta = "Bartłomiej Nowak", SerwisowaneWycena = 650, MagazynierId = 1, DataPrzyjecia = System.DateTime.Now },
                new PrzyjeteUrzadzenie() {SerwisowaneId = 2, SerwisowaneTresc = "Urwana Cewka. Nieudana naprawa w innym serwisie. Poprzednio problemy z grafiką. Uszkodzony prawdopodobnie mostek północny.", SerwisowaneTytul = "Płyta Główna MSI", SerwisowaneNazwaKlienta = "Ireneusz Pomyślny", SerwisowaneWycena = 300, MagazynierId = 1, DataPrzyjecia = System.DateTime.Now  },
                new PrzyjeteUrzadzenie() {SerwisowaneId = 3, SerwisowaneTresc = "Nagle przestał się włączać. Informacja od klienta: Laptop ostatnio często się przegrzewał i resetował.", SerwisowaneTytul = "Laptop Dell", SerwisowaneNazwaKlienta = "Firma: Elektryczni Kowalscy sp. z o.o", SerwisowaneWycena = 700 , MagazynierId = 1, DataPrzyjecia = System.DateTime.Now },
                new PrzyjeteUrzadzenie() {SerwisowaneId = 4, SerwisowaneTresc = "Urwane wejścia gniazda sluchawkowego.Urwane wejścia gniazda sluchawkowego. Urwane wejścia gniazda sluchawkowego. Urwane wejścia gniazda sluchawkowego. Urwane wejścia gniazda sluchawkowego. Urwane wejścia gniazda sluchawkowego. Inormacja od klienta: komputer uszkodzony podczas przeprowadzki, sprawdzić czy nie zostały uszkodzone inne podzespoły", SerwisowaneTytul = "Stacja Komputerowa gotowa Tesco", SerwisowaneNazwaKlienta = "Konrad Kowalczyk", SerwisowaneWycena = 50, MagazynierId = 1, DataPrzyjecia = System.DateTime.Now  }

           };
            wNaprawie.ForEach(k => context.Serwisowane.Add(k));

            var Magazynierzy = new List<Magazynier>
            {
                new Magazynier() {MagazynierId = 1, MagazynierImie = "Daniel", MagazynierNazwisko= "Fabiański" },
                new Magazynier() {MagazynierId = 2, MagazynierImie = "Tomasz", MagazynierNazwisko = "Raczek" } ,
                new Magazynier() {MagazynierId = 3, MagazynierImie =  "Bartłomiej", MagazynierNazwisko = "Muzykalny" }
            };
            Magazynierzy.ForEach(i => context.Magazynier.Add(i));
            context.SaveChanges();
        }
    }
}