# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:** Drömmatchen
**Grupp:**  Akram
**Datum:**  20/09/2026
**GitHub:**  https://github.com/akaysalah/clo26-drommatchen

---

## Gruppmedlemmar

| Akram| Lämnade in
|------|-----------|
| [Akram] | Zip + RAPPORT.md + REFLEKTION.md |

---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.




### Klasserna

> Jag utvecklade classen Spelare som beskriver en spelare med ett visst namn, nummer och position (sedan även hur många mål den har gjort). sedan gjorde jag samma sak på Match.cs.
Fälten är private så att ingen ska kunna ändra de utifrån. public get gjorde att man kan läsa infon och private set gjorde så att bara klassen kan ändra infon. Konstruktorn fyllde sedan i all info när new Spelare skapas.

### Metoderna

> Metoden Presentera() skriver ut matchdetaljerna Hemmalag, bortalag och datum.
AnnounceraMålskytt(Spelare) skriver ut GOLAZOO och spelarens namn, nummer & position.
Metoden ÄrMatchHjälte() är en bool som kollar om någon spelar har gjort minst ett mål.  

### Main()

> I main() skapar jag två spelare med new Spelare och sedan en match med new Match.


### Git

> Jag gjorde commits efter varje steg.

### Kodkvalitet

> Följde repots namnsättning och tog bort kommentarer och behöll de som behövs för enkel navigering och förklaring.

---

## VG — Motivering

> ÄrMatchHjälte är en bool eftersom metoden bara ska avgöra något, inte visa det. Den som anropar bestämmer själv vad som ska hända med svaret, och metoden kan återanvändas.

### Vad vi lade till

> Jag la till _mål, propetryn Mål och en ny konstruktor-parameter i ÄrMatchHjälte.

### Varför vi löste det såhär

> ÄrMatchHjälte returnerar en bool vilket kändes som det självklaraste eftersom MatchHjälte endast kan vara sant eller falskt ifall en spelare har gjort minst ett mål. Metoden returnerar sant/falskt istället för att skriva ut så att Main själv kan bestämma vad den gör med svaret.

---

## Git-logg

Klistra in utskriften från `git log --oneline` här:

```
[klistra in här]
```
