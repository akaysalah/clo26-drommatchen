public class Match
{
    // Privata fält
    private string _hemmalag;
    private string _bortalag;
    private string _datum;

    // Properties — publik get, privat set
    public string Hemmalag
    {
        get { return _hemmalag; }
        private set { _hemmalag = value; }
    }

    public string Bortalag
    {
        get { return _bortalag; }
        private set { _bortalag = value; }
    }

    public string Datum
    {
        get { return _datum; }
        private set { _datum = value; }
    }

    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :) <- ja, genom auto-properties men jag det tog den långa vägen istället för att lära mig. I framtiden använder jag nog auto-properties istället.

    // Konstruktor
    public Match(string hemmalag, string bortalag, string datum)
    {
        _hemmalag = hemmalag;
        _bortalag = bortalag;
        _datum = datum;
    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        Console.WriteLine($"{Hemmalag} vs {Bortalag} — {Datum}");
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
    {
        Console.WriteLine($"GOLAZOOOOO! #{spelare.Nummer} {spelare.Namn} ({spelare.Position})");
    }
}
