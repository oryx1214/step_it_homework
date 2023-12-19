// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        SpotifyFacade spotifyFacade = new SpotifyFacade();

        spotifyFacade.PlayMusic("Anver", "14082004", "song title");
        spotifyFacade.PauseMusic();
        spotifyFacade.StopMusic("Anver");
    }
}