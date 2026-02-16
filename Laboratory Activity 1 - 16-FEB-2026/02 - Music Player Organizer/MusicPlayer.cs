using System;

class Song
{
    public string title;
    public string artist;
    public double duration;

    public Song() : this("Unknown", "Unknown", 0.0) { }

    public Song(string title, string artist) : this(title, artist, 0.0) { }

    public Song(string title, string artist, double duration)
    {
        this.title = string.IsNullOrWhiteSpace(title) ? "Unknown" : title;
        this.artist = string.IsNullOrWhiteSpace(artist) ? "Unknown" : artist;
        this.duration = duration;
    }

    public void DisplaySong()
    {
        Console.WriteLine($"{title,-20} {artist,-15} {duration,6:F2}");
    }
}

class MusicPlayerOrg
{
    static void Main()
    {
        Console.Write("Songs to add: ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count < 0)
        {
            count = 0;
        }

        Song[] playlist = new Song[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nSong #{i + 1}");

            Console.Write("Title: ");
            string t = Console.ReadLine();

            Console.Write("Artist: ");
            string a = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            if (!double.TryParse(Console.ReadLine(), out double d))
            {
                d = 0.0;
            }

            playlist[i] = new Song(t, a, d);
        }

        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine($"{"Title",-20} {"Artist",-15} {"Time",6}");
        Console.WriteLine("----------------------------------------------");

        double totalDuration = 0;

        foreach (var song in playlist)
        {
            song.DisplaySong();
            totalDuration += song.duration;
        }

        double averageDuration = count > 0 ? totalDuration / count : 0;

        Console.WriteLine();
        Console.WriteLine($"Total Duration:   {totalDuration,6:F2} mins");
        Console.WriteLine($"Average Duration: {averageDuration,6:F2} mins");


        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}