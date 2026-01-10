using Dizalo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testovi
{
    [TestClass]
    public class KontrolaDizalaTests
    {
        public KontrolaDizala kontrola;
        [TestMethod]
        public void Konstruktor_InicijalniKatDizala_NaEkranuPisePrizemlje()
        {
            kontrola = new KontrolaDizala();

            Assert.IsTrue(kontrola.EkranskiPrikaz == "Prizemlje");
        }

        [TestMethod]
        public void PozoviDizalo_PozvanPetiKat_IspisIspravnePutanje()
        {
            kontrola = new KontrolaDizala();

            kontrola.PozoviDizalo(5);

            Assert.AreEqual(kontrola.EkranskiPrikaz, "Prizemlje->Poslovna zona 1->Poslovna zona 2->Treći kat->Četvrti kat->Peti kat");
        }

        [TestMethod]
        public void PozoviDizalo_PozvanTrenutniKat_IspisujeSamoTrenutniKat()
        {
            kontrola = new KontrolaDizala();
            kontrola.PozoviDizalo(3);

            kontrola.PozoviDizalo(3);

            Assert.IsTrue(kontrola.EkranskiPrikaz == "Treći kat");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBuildingFloorException))]
        public void PozoviDizalo_PozvanNepostojeciKat_Iznimka()
        {
            kontrola = new KontrolaDizala();

            kontrola.PozoviDizalo(6);
        }

        [TestMethod]
        [ExpectedException(typeof(FloorAuthorizationMissingException))]
        public void PozoviDizalo_PozvanaPoslovnaZonaBezLozinke_Iznimka()
        {
            kontrola = new KontrolaDizala();

            kontrola.PozoviDizalo(1);
        }

        [TestMethod]
        [ExpectedException(typeof(FloorAuthorizationMissingException))]
        public void PozoviDizalo_PozvanaPoslovnaZonaUzPogresnuLozinku_Iznimka()
        {
            kontrola = new KontrolaDizala();

            kontrola.PozoviDizalo(2, "pogrešna");
        }

        [TestMethod]
        public void PozoviDizalo_PozvanaPoslovnaZonaUzIspravnuLozinku_IspisIspravnePutanje()
        {
            kontrola = new KontrolaDizala();
            kontrola.PozoviDizalo(4);

            kontrola.PozoviDizalo(2, "12345");

            Assert.IsTrue(kontrola.EkranskiPrikaz == "Četvrti kat->Treći kat->Poslovna zona 2");
        }

        [TestMethod]
        public void PozoviDizalo_NepotrebnoUpisanaLozinka_IspisIspravnePutanje()
        {
            kontrola = new KontrolaDizala();
            kontrola.PozoviDizalo(3);

            kontrola.PozoviDizalo(4, "nepotrebna lozinka");

            Assert.IsTrue(kontrola.EkranskiPrikaz == "Treći kat->Četvrti kat");
        }

        [TestMethod]
        public void PozoviDizalo_PozvanoDizaloUKvaru_IspisPorukeKvara()
        {
            kontrola = new KontrolaDizala();
            kontrola.UKvaru = true;

            kontrola.PozoviDizalo(3);

            Assert.IsTrue(kontrola.EkranskiPrikaz == "Dizalo je trenutno u kvaru!");
        }
    }
}
