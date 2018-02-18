using rgik.Migrations;
using rgik.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace rgik.DAL
{
    /// <summary>
    ///  Define records
    /// </summary>
    public class rgikInitializer : MigrateDatabaseToLatestVersion<rgikContext,Configuration>
    {

        public static void SeedRgikData(rgikContext context)
        {
            var gatunki = new List<Gatunek>
            {
                new Gatunek() { GatunekId = 1, NazwaGatunku = "RPG",NazwaPlikuObrazkaGatunku = "rpg.png"},
                new Gatunek() { GatunekId = 2, NazwaGatunku = "Bijatyki",NazwaPlikuObrazkaGatunku = "bijatyka.png"},
                new Gatunek() { GatunekId = 3, NazwaGatunku = "Strzelanki",NazwaPlikuObrazkaGatunku = "strzelanka.png"},
                new Gatunek() { GatunekId = 4, NazwaGatunku = "Gry Akcji",NazwaPlikuObrazkaGatunku = "gryAkcji.png"},
                new Gatunek() { GatunekId = 5, NazwaGatunku = "MMORPG",NazwaPlikuObrazkaGatunku = "mmorpg.png"},
                new Gatunek() { GatunekId = 6, NazwaGatunku = "Sportowe",NazwaPlikuObrazkaGatunku = "sportowe.png"},
                new Gatunek() { GatunekId = 7, NazwaGatunku = "Strategiczne",NazwaPlikuObrazkaGatunku = "strategiczne.png"},
                new Gatunek() { GatunekId = 8, NazwaGatunku = "Horrory",NazwaPlikuObrazkaGatunku = "horror.png"},
                new Gatunek() { GatunekId = 9, NazwaGatunku = "Fantastyka",NazwaPlikuObrazkaGatunku = "fantastyka.png"},
                new Gatunek() { GatunekId = 10, NazwaGatunku = "Historyczne",NazwaPlikuObrazkaGatunku = "historia.png"}
            };
            gatunki.ForEach(g => context.Gatunek.AddOrUpdate(g));
            context.SaveChanges();

            var platformy = new List<Platforma>
            {
                new Platforma() {PlatformaId = 1,NazwaPlatformy = "PC" },
                new Platforma() {PlatformaId = 2,NazwaPlatformy = "Linux" },
                new Platforma() {PlatformaId = 3,NazwaPlatformy = "Konsola" },
                new Platforma() {PlatformaId = 4,NazwaPlatformy = "Telefon" },
            };
            platformy.ForEach(p => context.Platforma.AddOrUpdate(p));
            context.SaveChanges();

            var gry = new List<Gra>
            {
                new Gra() { GraId=1,GatunekId=1,PlatformaId=1,NazwaGry="Gothic",Producent = "Piranha Bytes",Wydawca="JoWood",
                WydawcaPL="CDP",DataWydania = new DateTime(2002,11,29),DataWydaniaWPolsce = new DateTime(2003,04,16),
                Ocena=1,TrybGry=TrybGry.SinglePlayer,NazwaPlikuObrazka="gothic.png",Parametry = new Parametry("pentium 3 700 mhz","GeForce2 Ti",256,3),
                Plusy = new List<string> (){ "Długość","Fabuła","Interakcja","Ilosc Elementow" }, Minusy = new List<string> { "Bugi","Poziom trudnosci" },Opis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla et pulvinar est. Phasellus ac eleifend turpis, sed vehicula justo. Integer at suscipit tortor, nec malesuada nunc. Phasellus vel volutpat tortor. Suspendisse elit felis, auctor vitae maximus pulvinar, mollis et lorem. Maecenas varius convallis odio, ut tristique leo placerat in. Vivamus eget mauris ultrices, ornare mi eu, placerat nisi. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nam ut ullamcorper purus, euismod sodales sapien. Sed neque turpis, bibendum at urna eu, hendrerit tincidunt arcu. Duis rhoncus faucibus tortor, ut hendrerit dolor ornare id. Maecenas lacinia aliquam cursus. Morbi dapibus interdum feugiat."+

                "Ut fermentum mi dolor. Etiam ac tortor nunc. Proin ac laoreet elit. Nam eget nulla et diam euismod aliquet. Interdum et malesuada fames ac ante ipsum primis in faucibus. Suspendisse fermentum justo et egestas commodo. Nunc mi lacus, sollicitudin nec faucibus ut, convallis eu diam. Sed vehicula sed lacus id pretium. Donec sollicitudin quis neque ac ultrices. Suspendisse vitae tempus dolor. In gravida ullamcorper dolor id rhoncus. Sed quis dolor tristique, elementum lectus sed, placerat nisl. Nullam ac gravida justo."+

                "Donec dapibus varius mattis. Vivamus et diam vitae augue pellentesque volutpat. Sed turpis purus, ullamcorper eu efficitur vulputate, laoreet et nisl. Aliquam lacinia dui at dui dictum pulvinar. Morbi at nisl ornare, bibendum neque in, lobortis erat. In odio arcu, tempor et egestas eu, ultricies id mauris. Vestibulum eget laoreet ligula. Nunc at interdum diam."+

                "Aliquam maximus nunc gravida aliquet volutpat. Duis et mi ornare, dictum ante a, eleifend libero. Donec lacinia massa sed mi hendrerit volutpat. Vivamus in massa at tortor tristique faucibus. Morbi posuere et diam eget porta. Vestibulum id convallis neque. Fusce non lacus cursus, aliquet est vel, mattis magna. Nam tristique lorem felis, non gravida sapien tincidunt in. Pellentesque sollicitudin eget magna quis hendrerit."+

                "Nulla quis sodales dui. Nullam facilisis, arcu at viverra consectetur, neque libero faucibus urna, eu ullamcorper erat tellus at tellus. Maecenas dapibus suscipit est, vel euismod ipsum iaculis non. Cras placerat erat eu malesuada hendrerit. Donec sagittis auctor nunc, id auctor nunc porttitor eget. Donec posuere malesuada risus, et faucibus ex egestas id. Fusce eget orci at diam sollicitudin suscipit congue non tellus. Etiam sollicitudin nisl odio, non rutrum nunc condimentum non. Vivamus augue libero, lacinia id ornare quis, pharetra ultricies quam. Etiam interdum lacus eget maximus tempor. Fusce a est nec justo pulvinar semper ut lacinia risus. Donec velit augue, dictum nec quam nec, maximus porta ex. Nunc consectetur odio volutpat laoreet ullamcorper."
                ,OpisSkrocony = "Lorem ipsumed quis lorem felis."
                ,SzacowanaDlugoscGry = 50,},

                new Gra() { GraId=2,GatunekId=2,PlatformaId=2,NazwaGry="Wiedzmin",Producent = "CDP",Wydawca="CDP",
                WydawcaPL="CDP",DataWydania = new DateTime(2007,10,26),DataWydaniaWPolsce = new DateTime(2007,10,26),
                Ocena=1,TrybGry=TrybGry.SinglePlayer,NazwaPlikuObrazka="wiedzmin.png",Parametry = new Parametry("Intel Pentium 4 2.4","GeForce 6660",1024,8),
                Plusy = new List<string> (){ "Grafika","Fabuła","Dubbing","Wielkosc" },Minusy = new List<string> { "Walka","Bugi","Niewiedza"},Opis = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla et pulvinar est. Phasellus ac eleifend turpis, sed vehicula justo. Integer at suscipit tortor, nec malesuada nunc. Phasellus vel volutpat tortor. Suspendisse elit felis, auctor vitae maximus pulvinar, mollis et lorem. Maecenas varius convallis odio, ut tristique leo placerat in. Vivamus eget mauris ultrices, ornare mi eu, placerat nisi. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nam ut ullamcorper purus, euismod sodales sapien. Sed neque turpis, bibendum at urna eu, hendrerit tincidunt arcu. Duis rhoncus faucibus tortor, ut hendrerit dolor ornare id. Maecenas lacinia aliquam cursus. Morbi dapibus interdum feugiat."+

                "Ut fermentum mi dolor. Etiam ac tortor nunc. Proin ac laoreet elit. Nam eget nulla et diam euismod aliquet. Interdum et malesuada fames ac ante ipsum primis in faucibus. Suspendisse fermentum justo et egestas commodo. Nunc mi lacus, sollicitudin nec faucibus ut, convallis eu diam. Sed vehicula sed lacus id pretium. Donec sollicitudin quis neque ac ultrices. Suspendisse vitae tempus dolor. In gravida ullamcorper dolor id rhoncus. Sed quis dolor tristique, elementum lectus sed, placerat nisl. Nullam ac gravida justo."+
                
                "WITCHER WITCHER WITCHER Aliquam maximus nunc gravida aliquet volutpat. Duis et mi ornare, dictum ante a, eleifend libero. Donec lacinia massa sed mi hendrerit volutpat. Vivamus in massa at tortor tristique faucibus. Morbi posuere et diam eget porta. Vestibulum id convallis neque. Fusce non lacus cursus, aliquet est vel, mattis magna. Nam tristique lorem felis, non gravida sapien tincidunt in. Pellentesque sollicitudin eget magna quis hendrerit."+

                "Nulla quis sodales dui. Nullam facilisis, arcu at viverra consectetur, neque libero faucibus urna, eu ullamcorper erat tellus at tellus. Maecenas dapibus suscipit est, vel euismod ipsum iaculis non. Cras placerat erat eu malesuada hendrerit. Donec sagittis auctor nunc, id auctor nunc porttitor eget. Donec posuere malesuada risus, et faucibus ex egestas id. Fusce eget orci at diam sollicitudin suscipit congue non tellus. Etiam sollicitudin nisl odio, non rutrum nunc condimentum non. Vivamus augue libero, lacinia id ornare quis, pharetra ultricies quam. Etiam interdum lacus eget maximus tempor. Fusce a est nec justo pulvinar semper ut lacinia risus. Donec velit augue, dictum nec quam nec, maximus porta ex. Nunc consectetur odio volutpat laoreet ullamcorper."
                ,OpisSkrocony = "WITCHER WITCHER !!!"
                ,SzacowanaDlugoscGry = 100,}
            };
            gry.ForEach(g => context.Gra.AddOrUpdate(g));
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            var ksiazki = new List<Ksiazka>
            {
                new Ksiazka() { KsiazkaId = 1,GatunekId=9,NazwaKsiazki="Metro2033",Producent="	Dmitrij Głuchowski",Wydawca="Eksmo",WydawcaPL="Insignis",DataWydania = new DateTime(2005,1,1),DataWydaniaWPolsce=new DateTime(2010,02,24),Ocena=1,NazwaPlikuObrazka="metro.png",
                Opis="Ut fermentum mi dolor. Etiam ac tortor nunc. Proin ac laoreet elit. Nam eget nulla et diam euismod aliquet. Interdum et malesuada fames ac ante ipsum primis in faucibus. Suspendisse fermentum justo et egestas commodo. Nunc mi lacus, sollicitudin nec faucibus ut, convallis eu diam. Sed vehicula sed lacus id pretium. Donec ",
                OpisSkrocony="Metro2033 to ksiązka ...",WadyIZalety = new WadyIZalety(new List<string> { "nowa","ogroma","fabula"},new List<string> { "zgubienie sie","dziwne  watki","w" })},

                new Ksiazka() { KsiazkaId = 2,GatunekId=8,NazwaKsiazki="Inni",Producent="James Herbert",Wydawca="Pan",WydawcaPL="Zysk i S-ka",DataWydania = new DateTime(1999,2,4),DataWydaniaWPolsce=new DateTime(2002,01,01),Ocena=1,NazwaPlikuObrazka="inni.png",
                Opis="Seget nulla et diam euismod aliquet. Interdum et malesuada fames ac ante ipsum primis in faucibus. Suspendisse fermentum justo et egestas commodo. Nunc mi lacus, sollicitudin nec faucibus ut, convallis eu diam. Sed vehicula sed lacus id pretium. Donec ",
                OpisSkrocony="Inni to ksiązka o tematuce ...",WadyIZalety = new WadyIZalety(new List<string> { "wciagajac","dziwna","wyjatkowa"},new List<string> { "czsami zbugienie","na wyrost"})}
            };
            ksiazki.ForEach(k => context.Ksiazka.AddOrUpdate(k));
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}