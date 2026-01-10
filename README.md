# Softverske metrike temeljene na teoriji grafova
## Opis problema

Testiranje programskog rješenja iznimno je važan proces u životnom ciklusu razvoja softvera kako bi se dobilo visokokvalitetno rješenje koje je u potpunosti funkcionalno. Dodano, važnost testiranja potvrđuje i činjenica kako sve relevantne metodologije razvoja, bez obzira na specifičnu strukturu, neizostavno uključuju testiranje kao kritičan korak. Sukladno tome, može se zaključiti kako testiranje jamči pouzdanost i stabilnost sustava uz uvjet pravilnog izvršavanja.

Kod kompleksnih aplikacija izazovno je pratiti koji su dijelovi koda uspješno testirani, koje je potrebno doraditi, a koji još uopće nisu obuhvaćeni testovima. Kako bi se izbjegla nepreglednost i smanjio rizik od neotkrivenih pogrešaka, koriste se alati i ekstenzije za mjerenje pokrivenost koda (eng. code coverage) testovima. Naime, pokrivenost koda je jedna od metrika koja se koristi kako bi se vizualno i kvanitifikacijski prikazao postotak koda koji je obuhvaćen tijekom procesa testiranja. S druge strane, iako se opisana pokrivenost prikazuje kroz postotke i oboje linije koda i grafova, matematička pozadina pokrivenosti koda temelji se na teoriji grafova te će ista biti opisana i implementirana u sklopu ovog rada.

## Prikupljeni podaci

Za potrebe ovog rada izrađeno je vlastito programsko rješenje pod nazivom „Dizalo“, napisano u programskom jeziku C#. Projekt je izrađen na temelju zadatka s kolegija Razvoj programskih proizvoda, a simulira rad lifta u zgradi te uključuje funkcionalnosti poput pozivanja dizala, kretanja između katova, provjere valjanosti odredišta i rukovanja mogućim pogreškama (npr. poziv na nepostojeći kat ili unos pogrešne lozinke). Struktura koda pritom sadrži brojne odluke, grane i blokove koji omogućuju jasno mapiranje logike programa na graf toka kontrole te ga čini prikladnim za analizu pokrivenosti koda.
