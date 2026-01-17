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
        // Konstante
        public static int CoverableLinijeDizalo { get; set; } = 89;
        public static int CoverableLinijeAuthException { get; set; } = 3;
        public static int CoverableLinijeInvalidException { get; set; } = 3;
        public static int CoverableLinijeKat { get; set; } = 3;
        public static int CoverableLinijeKontrolaDizala { get; set; } = 80;
        public static int TotalLinijeKontrolaDizala { get; set; } = 129;
        public static int TotalLinijeKat { get; set; } = 19;
        public static int TotalLinijeInvalidException { get; set; } = 129;
        public static int TotalLinijeAuthException { get; set; } = 129;
        public static int TotalBlokovi { get; set; } = 22;

        // Skupovi ID-eva linija i blokova
        public static HashSet<int> LinijeIDs { get; set; } = new HashSet<int>();
        public static HashSet<int> AuthExceptionLinijeIDs { get; set; } = new HashSet<int>();
        public static HashSet<int> InvalidExceptionLinijeIDs { get; set; } = new HashSet<int>();
        public static HashSet<int> KatLinijeIDs { get; set; } = new HashSet<int>();
        public static HashSet<int> BlokoviIDs { get; set; } = new HashSet<int>();
        public static int CoveredLinije => LinijeIDs.Count + AuthExceptionLinijeIDs.Count + InvalidExceptionLinijeIDs.Count + KatLinijeIDs.Count;
        public static int UncoveredLinije => CoverableLinijeDizalo - CoveredLinije;
        public static int TotalLinijeDizalo => TotalLinijeKontrolaDizala + TotalLinijeKat + TotalLinijeAuthException + TotalLinijeInvalidException;

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