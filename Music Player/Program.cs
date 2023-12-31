﻿
using System.Diagnostics;

Console.WriteLine("Music Player".PadLeft(30));
Console.WriteLine("next - n");
Console.WriteLine("previous - p");
Console.WriteLine("pause - pause");
Console.WriteLine("play - play");

MusicPlayer player = new MusicPlayer();
player.tracks.Add(new Track("ona", "Otabek Muhkamov"));
player.tracks.Add(new Track("dada", "Mirjalol Alimov"));
player.tracks.Add(new Track("fazo", "Bekzod Haqqiyev"));
player.tracks.Add(new Track("vatan", "Ozdbek Nazarbekov"));
player.momentTracks = player.tracks[0];
while (true)
{
    Console.WriteLine();
    Console.Write("Choose Command: ");
    var choose = Console.ReadLine();
    

    switch (choose)
    {
        case "n":
            player.Next();
            Console.WriteLine("ortga-> 0");
            var chooseB = char.Parse(Console.ReadLine());
            if (chooseB == '0')
            {
                Console.Clear();
                player.Menu();
            }
            break;

        case "p":
            player.Previous();
            Console.WriteLine("ortga-> 0");
            var chooseC = char.Parse(Console.ReadLine());
            if (chooseC == '0')
            {
                Console.Clear();
                player.Menu();
            }
            break;

        case "pause":

            player.Pause();
            Console.WriteLine("ortga-> 0");
            var chooseD = char.Parse(Console.ReadLine());
            if (chooseD == '0')
            {
                Console.Clear();
                player.Menu();
            }
            break;

        case "play":
            Console.WriteLine("ortga-> 0");
            var chooseS = char.Parse(Console.ReadLine());
            if (chooseS == '0')
            {
                Console.Clear();
                player.Menu();
            }
            break;
    }
}


public class Track
{
    public Track(string name, string auther)
    {
        Name = name;
        Auther = auther;
    }


    public string Name { get; set; }
    public string Auther { get; set; }

}

public class MusicPlayer
{
    public List<Track> tracks = new List<Track>();

    public Track momentTracks;

    public void Next()
    {
        if (momentTracks == tracks[tracks.Count - 1])
            momentTracks = tracks[0];
        else
        {
            for (var i = 0; i < tracks.Count; i++)
            {
                if (tracks[i] == momentTracks)
                {
                    momentTracks = tracks[i+1];
                    break;
                }
            }
        }
        Play();
    }
    public void Previous() 
    {
        if (momentTracks == tracks[0])
            momentTracks = tracks[tracks.Count -1];
        else
        {
            for (var i = tracks.Count - 1 ; i > 0; i--)
            {
                if (tracks[i] == momentTracks)
                {
                    momentTracks = tracks[i - 1];
                    break;
                }
            }
        }
        Play();
    }
    public void Pause()
    {
        Console.WriteLine($"Play - {momentTracks.Name}");
    }
    public void Play()
    {
        Console.WriteLine($"Play - {momentTracks.Name}");
    }

    public void Menu()
    {
        Console.WriteLine("Music Player".PadLeft(30));
        Console.WriteLine("next - n");
        Console.WriteLine("previous - p");
        Console.WriteLine("pause - pause");
        Console.WriteLine("play - play");
    }

}
