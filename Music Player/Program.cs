
using System.Diagnostics;

Console.WriteLine("Music Player".PadLeft(30));
Console.WriteLine("next - n");
Console.WriteLine("previous - p");
Console.WriteLine("pause - pause");
Console.WriteLine("play - play");

MusicPlayer player = new MusicPlayer();
player.tracks.Add(new Track("ona","Otabek Muhkamov"));
player.tracks.Add(new Track("dada", "Mirjalol Alimov"));
player.tracks.Add(new Track("fazo", "Bekzod Haqqiyev"));
player.tracks.Add(new Track("vatan", "Ozdbek Nazarbekov"));
while (true)
{
    Console.WriteLine();
    Console.Write("Choose Command: ");
    var choose = Console.ReadLine();

    switch (choose)
    {
        case "n":
            //Console.WriteLine(player.momentTracks);
            int idx = 0;
            while (idx < player.tracks.Count)
            {
                player.Next();
                idx++;
            }
                Console.WriteLine(player.momentTracks);
                Console.WriteLine("ortga-> 0");
                var chooseB = char.Parse(Console.ReadLine());
                if (chooseB == '0')
                {
                    Console.Clear();
                    player.Menu();
                }
                
            
            break;
  
        case "p":
            Console.WriteLine("ortga-> 0");
            var chooseC = char.Parse(Console.ReadLine());
            if (chooseC == '0')
            {
                Console.Clear();
                player.Menu();
            }
            break;

        case "pause":
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
    public Track(string name, string  auther)
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

    public string momentTracks = "";
    
    public void Next()
    {
        int index = 3;
        if (index == tracks.Count - 1)
        {
            momentTracks = tracks[0].Name;
            index = 0;
        }
        else
            momentTracks = tracks[++index].Name;
        
    }
    public void Previous() { }
    public void Pause() { }
    public void Play() { }

    public void Menu() 
    {
        Console.WriteLine("Music Player".PadLeft(30));
        Console.WriteLine("next - n");
        Console.WriteLine("previous - p");
        Console.WriteLine("pause - pause");
        Console.WriteLine("play - play");
    }

}
