using System;
using System.Collections.Generic;
using System.Linq;

namespace Dizalo
{
    public class InvalidBuildingFloorException : ApplicationException
    {
        public InvalidBuildingFloorException(string message)
            : base(message)
        { PokrivenostKoda.InvalidExceptionLinijeIDs.Add(10); PokrivenostKoda.InvalidExceptionLinijeIDs.Add(11); PokrivenostKoda.InvalidExceptionLinijeIDs.Add(12);

        }
    }

    public class FloorAuthorizationMissingException : ApplicationException
    {
        public FloorAuthorizationMissingException(string message)
            : base(message)
        { PokrivenostKoda.AuthExceptionLinijeIDs.Add(19); PokrivenostKoda.AuthExceptionLinijeIDs.Add(20); PokrivenostKoda.AuthExceptionLinijeIDs.Add(21);

        }
    }

    public class KontrolaDizala
    {
        private List<Kat> Katovi { get; set; }
        public Kat TrenutniKat { get; set; }
        private Kat OdredisniKat { get; set; }
        public string EkranskiPrikaz { get; set; }
        public bool UKvaru { get; set; } = false;

        public KontrolaDizala()
        {
            PokrivenostKoda.LinijeIDs.Add(27); PokrivenostKoda.LinijeIDs.Add(28); PokrivenostKoda.LinijeIDs.Add(29); PokrivenostKoda.LinijeIDs.Add(30); PokrivenostKoda.LinijeIDs.Add(31); PokrivenostKoda.LinijeIDs.Add(33); PokrivenostKoda.LinijeIDs.Add(34); PokrivenostKoda.LinijeIDs.Add(35); Katovi = new List<Kat>();
            PokrivenostKoda.LinijeIDs.Add(36); Katovi.Add(new Kat { Pozicija = -1, Naziv = "Podrum" });
            PokrivenostKoda.LinijeIDs.Add(37); Katovi.Add(new Kat { Pozicija = 0, Naziv = "Prizemlje" });
            PokrivenostKoda.LinijeIDs.Add(38); Katovi.Add(new Kat { Pozicija = 1, Naziv = "Poslovna zona 1", Lozinka = "abcde" }); 
            PokrivenostKoda.LinijeIDs.Add(39); Katovi.Add(new Kat { Pozicija = 2, Naziv = "Poslovna zona 2", Lozinka = "12345" });
            PokrivenostKoda.LinijeIDs.Add(40); Katovi.Add(new Kat { Pozicija = 3, Naziv = "Treći kat" });
            PokrivenostKoda.LinijeIDs.Add(41); Katovi.Add(new Kat { Pozicija = 4, Naziv = "Četvrti kat" });
            PokrivenostKoda.LinijeIDs.Add(42); Katovi.Add(new Kat { Pozicija = 5, Naziv = "Peti kat" });

            PokrivenostKoda.LinijeIDs.Add(44); Resetiraj();

            PokrivenostKoda.LinijeIDs.Add(46); PokrivenostKoda.LinijeIDs.Add(47); PozoviDizalo(0);
        }

        public void Resetiraj()
        {
            PokrivenostKoda.LinijeIDs.Add(50); PokrivenostKoda.LinijeIDs.Add(51); TrenutniKat = Katovi.FirstOrDefault(k => k.Naziv == "Prizemlje");
            PokrivenostKoda.LinijeIDs.Add(52); PokrivenostKoda.LinijeIDs.Add(53); OdredisniKat = null;
        }

        public void PozoviDizalo(int kat)
        {
            PokrivenostKoda.LinijeIDs.Add(56); PokrivenostKoda.LinijeIDs.Add(57); PokrivenostKoda.LinijeIDs.Add(58); PozoviDizalo(kat, null);
        }

        public void PozoviDizalo(int kat, string lozinka)
        {
            PokrivenostKoda.LinijeIDs.Add(61); PokrivenostKoda.LinijeIDs.Add(62); if (UKvaru)
            {
                PokrivenostKoda.BlokoviIDs.Add(62); PokrivenostKoda.LinijeIDs.Add(63); PokrivenostKoda.LinijeIDs.Add(64); EkranskiPrikaz = "Dizalo je trenutno u kvaru!";
                PokrivenostKoda.LinijeIDs.Add(65); return;
            }

            PokrivenostKoda.BlokoviIDs.Add(-62); PokrivenostKoda.LinijeIDs.Add(68); List<Kat> putanja = new List<Kat>();
            PokrivenostKoda.LinijeIDs.Add(69); EkranskiPrikaz = "";

            PokrivenostKoda.LinijeIDs.Add(71); OdredisniKat = Katovi.FirstOrDefault(k => k.Pozicija == kat);
            PokrivenostKoda. LinijeIDs.Add(72); if (OdredisniKat != null)
            {
                PokrivenostKoda.BlokoviIDs.Add(72); PokrivenostKoda.LinijeIDs.Add(73); PokrivenostKoda.LinijeIDs.Add(74); if (OdredisniKat.Lozinka != null && OdredisniKat.Lozinka != lozinka)
                {
                    PokrivenostKoda.BlokoviIDs.Add(75); PokrivenostKoda.LinijeIDs.Add(75); PokrivenostKoda.LinijeIDs.Add(76); throw new FloorAuthorizationMissingException("Za odabrani kat morate unijeti ispravnu lozinku!");
                }

                PokrivenostKoda.BlokoviIDs.Add(-75); PokrivenostKoda.BlokoviIDs.Add(76); PokrivenostKoda.BlokoviIDs.Add(-76); PokrivenostKoda.LinijeIDs.Add(79); if (OdredisniKat.Pozicija == TrenutniKat.Pozicija)
                {
                    PokrivenostKoda.BlokoviIDs.Add(80); PokrivenostKoda.LinijeIDs.Add(80); PokrivenostKoda.LinijeIDs.Add(81); PokrivenostKoda.LinijeIDs.Add(82); putanja.Add(TrenutniKat);
                }
                else if (OdredisniKat.Pozicija > TrenutniKat.Pozicija)
                {
                    PokrivenostKoda.BlokoviIDs.Add(83); PokrivenostKoda.BlokoviIDs.Add(85); PokrivenostKoda.LinijeIDs.Add(83); PokrivenostKoda.LinijeIDs.Add(84); PokrivenostKoda.LinijeIDs.Add(85); for (int i = TrenutniKat.Pozicija; i <= OdredisniKat.Pozicija; i++)
                    {
                        PokrivenostKoda.LinijeIDs.Add(86); PokrivenostKoda.LinijeIDs.Add(87); PokrivenostKoda.LinijeIDs.Add(88); putanja.Add(Katovi.FirstOrDefault(k => k.Pozicija == i));
                    }
                    PokrivenostKoda.BlokoviIDs.Add(-85); PokrivenostKoda.LinijeIDs.Add(89); TrenutniKat = OdredisniKat;
                    PokrivenostKoda.LinijeIDs.Add(90); PokrivenostKoda.LinijeIDs.Add(91); OdredisniKat = null;
                }
                else
                {
                    PokrivenostKoda.BlokoviIDs.Add(-80); PokrivenostKoda.BlokoviIDs.Add(-83); PokrivenostKoda.LinijeIDs.Add(93); PokrivenostKoda.LinijeIDs.Add(94); for (int i = TrenutniKat.Pozicija; i >= OdredisniKat.Pozicija; i--)
                    {
                    PokrivenostKoda.LinijeIDs.Add(95); PokrivenostKoda.LinijeIDs.Add(96); PokrivenostKoda.LinijeIDs.Add(97); putanja.Add(Katovi.FirstOrDefault(k => k.Pozicija == i));
                    }
                    PokrivenostKoda.LinijeIDs.Add(98); TrenutniKat = OdredisniKat;
                    PokrivenostKoda.LinijeIDs.Add(99); PokrivenostKoda.LinijeIDs.Add(100); OdredisniKat = null;
                }

                PokrivenostKoda.LinijeIDs.Add(102); PokrivenostKoda.LinijeIDs.Add(103); EkranskiPrikaz = IspisiPutanju(putanja);
            }
            else
            {
                PokrivenostKoda.BlokoviIDs.Add(-72); PokrivenostKoda.LinijeIDs.Add(105); PokrivenostKoda.LinijeIDs.Add(106); throw new InvalidBuildingFloorException("Uneseni kat ne postoji!");
            }
        PokrivenostKoda.LinijeIDs.Add(108); }

        private string IspisiPutanju(List<Kat> lista)
        {
            PokrivenostKoda.LinijeIDs.Add(111); PokrivenostKoda.LinijeIDs.Add(112); string ispis = "";
            PokrivenostKoda.LinijeIDs.Add(113); PokrivenostKoda.BlokoviIDs.Add(113); foreach (Kat k in lista)
            {
                PokrivenostKoda.LinijeIDs.Add(114); PokrivenostKoda.LinijeIDs.Add(115); if (k != lista[lista.Count - 1])
                {
                    PokrivenostKoda.BlokoviIDs.Add(115); PokrivenostKoda.LinijeIDs.Add(116); PokrivenostKoda.LinijeIDs.Add(117); PokrivenostKoda.LinijeIDs.Add(118); ispis += k.Naziv + "->";
                }
                else
                {
                    PokrivenostKoda.BlokoviIDs.Add(-115); PokrivenostKoda.LinijeIDs.Add(120); PokrivenostKoda.LinijeIDs.Add(121); PokrivenostKoda.LinijeIDs.Add(122); ispis += k.Naziv;
                }
                PokrivenostKoda.LinijeIDs.Add(123); }

            PokrivenostKoda.BlokoviIDs.Add(-113); PokrivenostKoda.LinijeIDs.Add(125); PokrivenostKoda.LinijeIDs.Add(126); return ispis;
        }
    }
}
