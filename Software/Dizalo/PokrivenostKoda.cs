using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizalo
{
    [ExcludeFromCodeCoverage]
    public static class PokrivenostKoda
    {
        // Skupovi ID-eva linija i blokova
        public static HashSet<int> LinijeIDs { get; set; } = new HashSet<int>();
        public static HashSet<int> AuthExceptionLinijeIDs { get; set; } = new HashSet<int>();
        public static HashSet<int> InvalidExceptionLinijeIDs { get; set; } = new HashSet<int>();
        public static HashSet<int> KatLinijeIDs { get; set; } = new HashSet<int>();
        public static HashSet<int> BlokoviIDs { get; set; } = new HashSet<int>();
        public static int CoveredLinije { get; set; } = 87 - (LinijeIDs.Count + AuthExceptionLinijeIDs.Count + InvalidExceptionLinijeIDs.Count + KatLinijeIDs.Count);
        public static int UncoveredLinije { get; set; } = CoverableLinijeDizalo - CoveredLinije;
        public static int TotalLinijeDizalo { get; set; } = TotalLinijeKontrolaDizala + TotalLinijeKat + TotalLinijeAuthException + TotalLinijeInvalidException;

        // Konstante
        public static int CoverableLinijeDizalo { get; set; } = 87;
        public static int CoverableLinijeAuthException { get; set; } = 3;
        public static int CoverableLinijeInvalidException { get; set; } = 3;
        public static int CoverableLinijeKat { get; set; } = 3;
        public static int CoverableLinijeKontrolaDizala { get; set; } = 78;
        
        public static int TotalLinijeKontrolaDizala { get; set; } = 128;
        public static int TotalLinijeKat { get; set; } = 19;
        public static int TotalLinijeInvalidException { get; set; } = 128;
        public static int TotalLinijeAuthException { get; set; } = 128;
        
        public static int TotalBlokovi { get; set; } = 22;

        // Funkcije
        public static void Resetiraj()
        {
            LinijeIDs.Clear();
            AuthExceptionLinijeIDs.Clear();
            InvalidExceptionLinijeIDs.Clear();
            KatLinijeIDs.Clear();
            BlokoviIDs.Clear();
        }
    }
}