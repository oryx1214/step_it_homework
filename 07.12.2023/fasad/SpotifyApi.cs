using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpotifyApi
{
    public void Play(string song)
    {
        Console.WriteLine($"Playing song on spotify: {song}");
    }
    public void Pause()
    {
        Console.WriteLine("Pausing spotify playback");
    }
    public void Connect(string username, string password)
    {
        Console.WriteLine($"Connecting to spotify with user: {username}");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from spotify");
    }
}