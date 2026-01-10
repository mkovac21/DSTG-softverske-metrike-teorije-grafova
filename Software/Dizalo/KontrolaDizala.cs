using System;
using System.Collections.Generic;
using System.Linq;

namespace Dizalo
{
    public class InvalidBuildingFloorException : ApplicationException
    {
        public InvalidBuildingFloorException(string message)
            : base(message)
        {

        }
    }

    public class FloorAuthorizationMissingException : ApplicationException
    {
        public FloorAuthorizationMissingException(string message)
            : base(message)
        {

        }
    }

    public class KontrolaDizala
    {
        public static HashSet<int> LinijeIDs { get; set; } = new HashSet<int>();
        public static HashSet<int> BlokoviIDs { get; set; } = new HashSet<int>();
        public int brojacLinija { get; set; } = 0;
        public int brojacBlok { get; set; } = 0;
        private List<Kat> Katovi { get; set; }
        public Kat TrenutniKat { get; set; }
        private Kat OdredisniKat { get; set; }
        public string EkranskiPrikaz { get; set; }
        public bool UKvaru { get; set; } = false;

        public KontrolaDizala()
        {
            LinijeIDs.Add(27); LinijeIDs.Add(28); LinijeIDs.Add(29); LinijeIDs.Add(30); LinijeIDs.Add(31); LinijeIDs.Add(32); LinijeIDs.Add(33); LinijeIDs.Add(34); LinijeIDs.Add(35); LinijeIDs.Add(37); LinijeIDs.Add(38); LinijeIDs.Add(39); Katovi = new List<Kat>();
            LinijeIDs.Add(40); Katovi.Add(new Kat { Pozicija = -1, Naziv = "Podrum" });
            LinijeIDs.Add(41); Katovi.Add(new Kat { Pozicija = 0, Naziv = "Prizemlje" });
            LinijeIDs.Add(42); Katovi.Add(new Kat { Pozicija = 1, Naziv = "Poslovna zona 1", Lozinka = "abcde" }); 
            LinijeIDs.Add(43); Katovi.Add(new Kat { Pozicija = 2, Naziv = "Poslovna zona 2", Lozinka = "12345" });
            LinijeIDs.Add(44); Katovi.Add(new Kat { Pozicija = 3, Naziv = "Treći kat" });
            LinijeIDs.Add(45); Katovi.Add(new Kat { Pozicija = 4, Naziv = "Četvrti kat" });
            LinijeIDs.Add(46); Katovi.Add(new Kat { Pozicija = 5, Naziv = "Peti kat" });

            LinijeIDs.Add(48); Resetiraj();

            LinijeIDs.Add(50); LinijeIDs.Add(51); PozoviDizalo(0); brojacLinija = LinijeIDs.Count;
        }

        public void Resetiraj()
        {
            LinijeIDs.Add(54); LinijeIDs.Add(55); TrenutniKat = Katovi.FirstOrDefault(k => k.Naziv == "Prizemlje");
            LinijeIDs.Add(56); LinijeIDs.Add(57); OdredisniKat = null;
        }

        public void PozoviDizalo(int kat)
        {
            LinijeIDs.Add(60); LinijeIDs.Add(61); LinijeIDs.Add(62); PozoviDizalo(kat, null);
        }

        public void PozoviDizalo(int kat, string lozinka)
        {
            LinijeIDs.Add(65); if (UKvaru)
            {
                BlokoviIDs.Add(64); LinijeIDs.Add(65); LinijeIDs.Add(66); LinijeIDs.Add(68); LinijeIDs.Add(69); EkranskiPrikaz = "Dizalo je trenutno u kvaru!"; brojacLinija = LinijeIDs.Count; brojacBlok = BlokoviIDs.Count;
                return;
            }

            BlokoviIDs.Add(72); LinijeIDs.Add(72); List<Kat> putanja = new List<Kat>();
            LinijeIDs.Add(73); EkranskiPrikaz = "";

            LinijeIDs.Add(75); OdredisniKat = Katovi.FirstOrDefault(k => k.Pozicija == kat);
            LinijeIDs.Add(76); LinijeIDs.Add(77); if (OdredisniKat != null)
            {
                BlokoviIDs.Add(76); LinijeIDs.Add(78); if (OdredisniKat.Lozinka != null && OdredisniKat.Lozinka != lozinka)
                {
                    BlokoviIDs.Add(80); LinijeIDs.Add(80); throw new FloorAuthorizationMissingException("Za odabrani kat morate unijeti ispravnu lozinku!");
                }

                LinijeIDs.Add(83); LinijeIDs.Add(84); if (OdredisniKat.Pozicija == TrenutniKat.Pozicija)
                {
                    BlokoviIDs.Add(83); LinijeIDs.Add(85); LinijeIDs.Add(86); putanja.Add(TrenutniKat);
                }
                else if (OdredisniKat.Pozicija > TrenutniKat.Pozicija)
                {
                    BlokoviIDs.Add(87); BlokoviIDs.Add(89); LinijeIDs.Add(87); LinijeIDs.Add(89); for (int i = TrenutniKat.Pozicija; i <= OdredisniKat.Pozicija; i++)
                    {
                        LinijeIDs.Add(91); putanja.Add(Katovi.FirstOrDefault(k => k.Pozicija == i));
                    }
                    LinijeIDs.Add(93); TrenutniKat = OdredisniKat;
                    LinijeIDs.Add(94); OdredisniKat = null;
                }
                else
                {
                    BlokoviIDs.Add(96); BlokoviIDs.Add(98); LinijeIDs.Add(96); LinijeIDs.Add(98); for (int i = TrenutniKat.Pozicija; i >= OdredisniKat.Pozicija; i--)
                    {
                        LinijeIDs.Add(100); putanja.Add(Katovi.FirstOrDefault(k => k.Pozicija == i));
                    }
                    LinijeIDs.Add(102); TrenutniKat = OdredisniKat;
                    LinijeIDs.Add(103); OdredisniKat = null;
                }

                LinijeIDs.Add(106); LinijeIDs.Add(107); EkranskiPrikaz = IspisiPutanju(putanja); brojacLinija = LinijeIDs.Count; brojacBlok = BlokoviIDs.Count;
            }
            else
            {
                BlokoviIDs.Add(108); LinijeIDs.Add(108); LinijeIDs.Add(110); LinijeIDs.Add(10); LinijeIDs.Add(11); LinijeIDs.Add(13); brojacLinija = LinijeIDs.Count; brojacBlok = BlokoviIDs.Count; throw new InvalidBuildingFloorException("Uneseni kat ne postoji!");
            }
        LinijeIDs.Add(112); }

        private string IspisiPutanju(List<Kat> lista)
        {
            BlokoviIDs.Add(115); LinijeIDs.Add(115); LinijeIDs.Add(116); string ispis = "";
            BlokoviIDs.Add(117); LinijeIDs.Add(118); LinijeIDs.Add(117); foreach (Kat k in lista)
            {
                BlokoviIDs.Add(119); LinijeIDs.Add(119); if (k != lista[lista.Count - 1])
                {
                    LinijeIDs.Add(121); ispis += k.Naziv + "->";
                }
                else
                {
                    BlokoviIDs.Add(125); LinijeIDs.Add(124); LinijeIDs.Add(125); LinijeIDs.Add(126); ispis += k.Naziv;
                }
            LinijeIDs.Add(127); }

            LinijeIDs.Add(129); LinijeIDs.Add(130); brojacLinija = LinijeIDs.Count; brojacBlok = BlokoviIDs.Count; return ispis;
        }
    }
}
