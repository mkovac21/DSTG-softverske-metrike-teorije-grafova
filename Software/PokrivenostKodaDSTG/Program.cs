using Dizalo;
using System;
using System.Threading;
using Testovi;

namespace PokrivenostKodaDSTG
{
    public class Program
    {
        // Instanca klase s testovima
        private static readonly KontrolaDizalaTests testovi = new KontrolaDizalaTests();

        private static void Main(string[] args)
        {
            bool programRadi = true;

            while (programRadi)
            {
                Console.Clear();
                Console.WriteLine("==================================================================");
                Console.WriteLine("                  DIZALO - SUSTAV ZA TESTIRANJE                   ");
                Console.WriteLine("==================================================================");
                Console.WriteLine(" 1. Test: Inicijalni kat (Prizemlje)");
                Console.WriteLine(" 2. Test: Poziv na 5. kat");
                Console.WriteLine(" 3. Test: Poziv na trenutni kat");
                Console.WriteLine(" 4. Test: Nepostojeći kat (Iznimka)");
                Console.WriteLine(" 5. Test: Poslovna zona bez lozinke (Iznimka)");
                Console.WriteLine(" 6. Test: Poslovna zona kriva lozinka (Iznimka)");
                Console.WriteLine(" 7. Test: Poslovna zona ispravna lozinka");
                Console.WriteLine(" 8. Test: Nepotrebna lozinka");
                Console.WriteLine(" 9. Test: Dizalo u kvaru");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine(" A. IZVRŠI SVE TESTOVE ODJEDNOM");
                Console.WriteLine(" 0. Izlaz");
                Console.WriteLine("==================================================================");
                Console.Write("Vaš odabir: ");

                char keyChar = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                if(keyChar != 'A')
                {
                    PokrivenostKoda.Resetiraj();
                }

                switch (keyChar)
                {
                    case '0':
                        programRadi = false;
                        break;
                    case '1':
                        IzvrsiTest("1. Konstruktor_InicijalniKatDizala_NaEkranuPisePrizemlje", testovi.Konstruktor_InicijalniKatDizala_NaEkranuPisePrizemlje);
                        RezultatTablica();
                        Console.ReadKey();
                        break;
                    case '2':
                        IzvrsiTest("2. PozoviDizalo_PozvanPetiKat_IspisIspravnePutanje", testovi.PozoviDizalo_PozvanPetiKat_IspisIspravnePutanje);
                        RezultatTablica();
                        Console.ReadKey();
                        break;
                    case '3':
                        IzvrsiTest("3. PozoviDizalo_PozvanTrenutniKat_IspisujeSamoTrenutniKat", testovi.PozoviDizalo_PozvanTrenutniKat_IspisujeSamoTrenutniKat);
                        RezultatTablica();
                        Console.ReadKey();
                        break;
                    case '4':
                        IzvrsiTest("4. PozoviDizalo_PozvanNepostojeciKat_Iznimka", testovi.PozoviDizalo_PozvanNepostojeciKat_Iznimka);
                        RezultatTablica();
                        Console.ReadKey();
                        break;
                    case '5':
                        IzvrsiTest("5. PozoviDizalo_PozvanaPoslovnaZonaBezLozinke_Iznimka", testovi.PozoviDizalo_PozvanaPoslovnaZonaBezLozinke_Iznimka);
                        RezultatTablica();
                        Console.ReadKey();
                        break;
                    case '6':
                        IzvrsiTest("6. PozoviDizalo_PozvanaPoslovnaZonaUzPogresnuLozinku_Iznimka", testovi.PozoviDizalo_PozvanaPoslovnaZonaUzPogresnuLozinku_Iznimka);
                        RezultatTablica();
                        Console.ReadKey();
                        break;
                    case '7':
                        IzvrsiTest("7. PozoviDizalo_PozvanaPoslovnaZonaUzIspravnuLozinku_IspisIspravnePutanje", testovi.PozoviDizalo_PozvanaPoslovnaZonaUzIspravnuLozinku_IspisIspravnePutanje);
                        RezultatTablica();
                        Console.ReadKey();
                        break;
                    case '8':
                        IzvrsiTest("8. PozoviDizalo_NepotrebnoUpisanaLozinka_IspisIspravnePutanje", testovi.PozoviDizalo_NepotrebnoUpisanaLozinka_IspisIspravnePutanje);
                        RezultatTablica();
                        Console.ReadKey();
                        break;
                    case '9':
                        IzvrsiTest("9. PozoviDizalo_PozvanoDizaloUKvaru_IspisPorukeKvara", testovi.PozoviDizalo_PozvanoDizaloUKvaru_IspisPorukeKvara);
                        RezultatTablica();
                        Console.ReadKey();
                        break;
                    case 'A':
                    case 'a':
                        IzvrsiSveTestove();
                        RezultatTablica();
                        Console.ReadKey();
                        break;
                }
            }

            RezultatTablica();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        private static void IzvrsiSveTestove()
        {
            Console.WriteLine("\nPOKRETANJE SVIH TESTOVA...\n");
            IzvrsiTest("1. Konstruktor_InicijalniKatDizala_NaEkranuPisePrizemlje", testovi.Konstruktor_InicijalniKatDizala_NaEkranuPisePrizemlje);
            IzvrsiTest("2. PozoviDizalo_PozvanPetiKat_IspisIspravnePutanje", testovi.PozoviDizalo_PozvanPetiKat_IspisIspravnePutanje);
            IzvrsiTest("3. PozoviDizalo_PozvanTrenutniKat_IspisujeSamoTrenutniKat", testovi.PozoviDizalo_PozvanTrenutniKat_IspisujeSamoTrenutniKat);
            IzvrsiTest("4. PozoviDizalo_PozvanNepostojeciKat_Iznimka", testovi.PozoviDizalo_PozvanNepostojeciKat_Iznimka);
            IzvrsiTest("5. Poslovna (bez lozinkPozoviDizalo_PozvanaPoslovnaZonaBezLozinke_Iznimka", testovi.PozoviDizalo_PozvanaPoslovnaZonaBezLozinke_Iznimka);
            IzvrsiTest("6. PozoviDizalo_PozvanaPoslovnaZonaUzPogresnuLozinku_Iznimka", testovi.PozoviDizalo_PozvanaPoslovnaZonaUzPogresnuLozinku_Iznimka);
            IzvrsiTest("7. PozoviDizalo_PozvanaPoslovnaZonaUzIspravnuLozinku_IspisIspravnePutanje", testovi.PozoviDizalo_PozvanaPoslovnaZonaUzIspravnuLozinku_IspisIspravnePutanje);
            IzvrsiTest("8. PozoviDizalo_NepotrebnoUpisanaLozinka_IspisIspravnePutanje", testovi.PozoviDizalo_NepotrebnoUpisanaLozinka_IspisIspravnePutanje);
            IzvrsiTest("9. PozoviDizalo_PozvanoDizaloUKvaru_IspisPorukeKvara", testovi.PozoviDizalo_PozvanoDizaloUKvaru_IspisPorukeKvara);
            Console.WriteLine("\nSVI TESTOVI SU IZVRŠENI.");
        }

        private static void IzvrsiTest(string nazivTesta, Action testMetoda)
        {
            Console.WriteLine("IZVRŠAVANJE TESTA: " + nazivTesta);

            Console.Write("Učitavanje: 0% ");
            Thread.Sleep(200);
            Console.Write("\rUčitavanje: 25% ...");
            Thread.Sleep(200);
            Console.Write("\rUčitavanje: 50% ......");
            Thread.Sleep(200);
            Console.Write("\rUčitavanje: 75% ......... ");
            Thread.Sleep(200);
            Console.Write("\rUčitavanje: 100% ............\n");

            try
            {
                testMetoda();
            } catch (Exception ex)
            {
                Console.WriteLine($" [INFO] Iznimka {ex.GetType().Name} uhvaćena i ignorirana radi nastavka...");
            }
        }

        private static void IspisiRedak(string naziv, int covered, int coverable, int total, int branchCov, int branchTot)
        {
            int uncovered = coverable - covered;

            double lineCoveragePct = coverable > 0 ? (double)covered / coverable * 100.0 : 0.0;
            double branchCoveragePct = branchTot > 0 ? (double)branchCov / branchTot * 100.0 : 0.0;

            Console.Write($"| {naziv,-45} | {covered,7} | {uncovered,9} | {coverable,9} | {total,5} | ");

            CrtajGraf(lineCoveragePct, 13);

            Console.Write($" | {branchCov,7} | {branchTot,5} | ");

            if (branchTot > 0)
                CrtajGraf(branchCoveragePct, 15);
            else
                Console.Write($"{"n/a",15}");

            Console.WriteLine(" |");
        }

        private static void RezultatTablica()
        {
            string format = "| {0,-45} | {1,7} | {2,9} | {3,9} | {4,5} | {5,13} | {6,7} | {7,5} | {8,15} |";
            Console.WriteLine(new string('-', 135));
            Console.WriteLine(format, "Name", "Covered", "Uncovered", "Coverable", "Total", "Line Coverage", "Covered", "Total", "Branch Coverage");

            IspisiRedak("Dizalo",
                PokrivenostKoda.CoveredLinije,
                PokrivenostKoda.CoverableLinijeDizalo,
                PokrivenostKoda.TotalLinijeDizalo,
                PokrivenostKoda.BlokoviIDs.Count,
                PokrivenostKoda.TotalBlokovi);

            IspisiRedak("Dizalo.FloorAuthorizationMissingException",
                PokrivenostKoda.AuthExceptionLinijeIDs.Count,
                PokrivenostKoda.CoverableLinijeAuthException,
                PokrivenostKoda.TotalLinijeAuthException,
                0, 0);

            IspisiRedak("Dizalo.InvalidBuildingFloorException",
                PokrivenostKoda.InvalidExceptionLinijeIDs.Count,
                PokrivenostKoda.CoverableLinijeInvalidException,
                PokrivenostKoda.TotalLinijeInvalidException,
                0, 0);

            IspisiRedak("Dizalo.Kat",
                PokrivenostKoda.KatLinijeIDs.Count,
                PokrivenostKoda.CoverableLinijeKat,
                PokrivenostKoda.TotalLinijeKat,
                0, 0);

            IspisiRedak("Dizalo.KontrolaDizala",
                PokrivenostKoda.LinijeIDs.Count,
                PokrivenostKoda.CoverableLinijeKontrolaDizala,
                PokrivenostKoda.TotalLinijeKontrolaDizala,
                PokrivenostKoda.BlokoviIDs.Count,
                PokrivenostKoda.TotalBlokovi);

            Console.WriteLine(new string('-', 135));
        }

        private static void CrtajGraf(double postotak, int ukupnaSirinaCelije)
        {
            string tekstPostotka = $"{postotak:F1}%";

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(tekstPostotka + " ");

            int preostaloMjesto = ukupnaSirinaCelije - tekstPostotka.Length - 1;
            if (preostaloMjesto < 0) preostaloMjesto = 0;

            int brojZelenih = (int)(postotak / 100.0 * preostaloMjesto);
            int brojCrvenih = preostaloMjesto - brojZelenih;

            if (brojZelenih > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(new string('█', brojZelenih));
            }

            if (brojCrvenih > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(new string('▒', brojCrvenih));
            }

            Console.ResetColor();
        }
    }
}