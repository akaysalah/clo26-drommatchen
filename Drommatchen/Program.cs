Console.OutputEncoding = System.Text.Encoding.UTF8;

Spelare spelare1 = new Spelare("Alexader Isak", 9, "Forward", 3);
Spelare spelare2 = new Spelare("Virgil Van Dijk", 4, "Back", 1);

Match match = new Match("Brentford FC", "Liverpool FC", "2026-09-20");
match.Presentera(); 
match.AnnounceraMålskytt(spelare1);
match.AnnounceraMålskytt(spelare2);