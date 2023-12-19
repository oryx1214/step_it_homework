using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpotifyFacade
{
    private SpotifyApi api;

    public SpotifyFacade()
    {
        api = new SpotifyApi();
    }

    public void PlayMusic(string username, string password, string song)
    {
        Console.WriteLine("initializing spotify play");
        api.Connect(username, password);
        api.Play(song);
    }

    public void PauseMusic()
    {
        Console.WriteLine("pausing spotify play");
        api.Pause();
    }

    public void StopMusic(string username)
    {
        Console.WriteLine($"stopping spotify play for user: {username}");
        api.Disconnect();
    }
}

