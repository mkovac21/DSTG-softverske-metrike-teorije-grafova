using Dizalo;
using System;
using System.Threading;
using Testovi;

namespace PokrivenostKodaDSTG
{
    public class Program
    {
        static void Main(string[] args)
        {
            KontrolaDizala kontrola = new KontrolaDizala();
            KontrolaDizalaTests testovi = new KontrolaDizalaTests();

            // TEST 1
            Console.WriteLine("IZVRŠAVANJE TESTA: 1. Konstruktor_InicijalniKatDizala_NaEkranuPisePrizemlje");
            Console.Write("Učitavanje: 0% "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 25% ..."); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 50% ......"); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 75% ......... "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 100% ............");

            testovi.Konstruktor_InicijalniKatDizala_NaEkranuPisePrizemlje();
            Console.WriteLine($"\nBrojač linija: {testovi.kontrola.brojacLinija}");
            Console.ReadKey();

            // TEST 2
            Console.WriteLine("IZVRŠAVANJE TESTA: 2. PozoviDizalo_PozvanPetiKat_IspisIspravnePutanje");
            Console.Write("Učitavanje: 0% "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 25% ..."); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 50% ......"); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 75% ......... "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 100% ............");

            testovi.PozoviDizalo_PozvanPetiKat_IspisIspravnePutanje();
            Console.WriteLine($"\nBrojač linija: {testovi.kontrola.brojacLinija}");
            Console.ReadKey();

            // TEST 3
            Console.WriteLine("IZVRŠAVANJE TESTA: 3. PozoviDizalo_PozvanTrenutniKat_IspisujeSamoTrenutniKat");
            Console.Write("Učitavanje: 0% "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 25% ..."); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 50% ......"); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 75% ......... "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 100% ............");

            testovi.PozoviDizalo_PozvanTrenutniKat_IspisujeSamoTrenutniKat();
            Console.WriteLine($"\nBrojač linija: {testovi.kontrola.brojacLinija}");
            Console.ReadKey();

            // TEST 4
            Console.WriteLine("IZVRŠAVANJE TESTA: 4. PozoviDizalo_PozvanNepostojeciKat_Iznimka");
            Console.Write("Učitavanje: 0% "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 25% ..."); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 50% ......"); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 75% ......... "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 100% ............");

            try
            {
                testovi.PozoviDizalo_PozvanNepostojeciKat_Iznimka();
                Console.WriteLine("\n[GREŠKA] Test nije uspio: Očekivana iznimka se nije dogodila.");
            } catch (InvalidBuildingFloorException)
            {
                Console.WriteLine($"\nBrojač linija: {testovi.kontrola.brojacLinija}");
            }

            Console.ReadKey();

            // TEST 5
            Console.WriteLine("IZVRŠAVANJE TESTA: 5. PozoviDizalo_PozvanaPoslovnaZonaBezLozinke_Iznimka");
            Console.Write("Učitavanje: 0% "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 25% ..."); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 50% ......"); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 75% ......... "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 100% ............");

            try
            {
                testovi.PozoviDizalo_PozvanaPoslovnaZonaBezLozinke_Iznimka();
                Console.WriteLine("\n[GREŠKA] Test nije uspio: Očekivana iznimka se nije dogodila.");
            } catch (FloorAuthorizationMissingException)
            {
                Console.WriteLine($"\nBrojač linija: {testovi.kontrola.brojacLinija}");
            }

            Console.ReadKey();

            // TEST 6
            Console.WriteLine("IZVRŠAVANJE TESTA: 6. PozoviDizalo_PozvanaPoslovnaZonaUzPogresnuLozinku_Iznimka");
            Console.Write("Učitavanje: 0% "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 25% ..."); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 50% ......"); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 75% ......... "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 100% ............");

            try
            {
                testovi.PozoviDizalo_PozvanaPoslovnaZonaUzPogresnuLozinku_Iznimka();
                Console.WriteLine("\n[GREŠKA] Test nije uspio: Očekivana iznimka se nije dogodila.");
            } catch (FloorAuthorizationMissingException)
            {
                Console.WriteLine($"\nBrojač linija: {testovi.kontrola.brojacLinija}");
            }

            Console.ReadKey();

            // TEST 7
            Console.WriteLine("IZVRŠAVANJE TESTA: 7. PozoviDizalo_PozvanaPoslovnaZonaUzIspravnuLozinku_IspisIspravnePutanje");
            Console.Write("Učitavanje: 0% "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 25% ..."); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 50% ......"); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 75% ......... "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 100% ............");

            testovi.PozoviDizalo_PozvanaPoslovnaZonaUzIspravnuLozinku_IspisIspravnePutanje();
            Console.WriteLine($"\nBrojač linija: {testovi.kontrola.brojacLinija}");
            Console.ReadKey();

            // TEST 8
            Console.WriteLine("IZVRŠAVANJE TESTA: 8. PozoviDizalo_NepotrebnoUpisanaLozinka_IspisIspravnePutanje");
            Console.Write("Učitavanje: 0% "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 25% ..."); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 50% ......"); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 75% ......... "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 100% ............");

            testovi.PozoviDizalo_NepotrebnoUpisanaLozinka_IspisIspravnePutanje();
            Console.WriteLine($"\nBrojač linija: {testovi.kontrola.brojacLinija}");
            Console.ReadKey();

            // TEST 9
            Console.WriteLine("IZVRŠAVANJE TESTA: 9. PozoviDizalo_PozvanoDizaloUKvaru_IspisPorukeKvara");
            Console.Write("Učitavanje: 0% "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 25% ..."); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 50% ......"); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 75% ......... "); Thread.Sleep(900);
            Console.Write("\rUčitavanje: 100% ............");

            testovi.PozoviDizalo_PozvanoDizaloUKvaru_IspisPorukeKvara();
            Console.WriteLine($"\nBrojač linija: {testovi.kontrola.brojacLinija}");
            Console.ReadKey();
        }
    }
}
