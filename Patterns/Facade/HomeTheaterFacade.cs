namespace Patterns.Facade;

public class HomeTheaterFacade(DvdPlayer dvdPlayer, Projector projector, SoundSystem soundSystem) {
    public void StartMovie(string movie)
    {
        Console.WriteLine("Preparing to watch a movie...");
        projector.On();
        projector.SetWideScreenMode();
        soundSystem.On();
        soundSystem.SetVolume(10);
        dvdPlayer.On();
        dvdPlayer.Play(movie);
        Console.WriteLine("Movie started. Enjoy!");
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down the home theater...");
        dvdPlayer.Off();
        projector.Off();
        soundSystem.Off();
        Console.WriteLine("Home theater turned off.");
    }
}