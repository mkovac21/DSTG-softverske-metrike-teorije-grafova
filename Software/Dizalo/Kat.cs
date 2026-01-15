using System.Diagnostics.CodeAnalysis;

namespace Dizalo
{
    public class Kat
    {
        public int Pozicija { get; set; }
        public string Naziv { get; set; }
        public string Lozinka { get; set; }

        [ExcludeFromCodeCoverage]
        public Kat()
        {
            PokrivenostKoda.KatLinijeIDs.Add(7);
            PokrivenostKoda.KatLinijeIDs.Add(8);
            PokrivenostKoda.KatLinijeIDs.Add(9);
        }
    }
}
