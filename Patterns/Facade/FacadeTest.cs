namespace Patterns.Facade;

public class FacadeTest {
    public void Test() {
        var dvdPlayer = new DvdPlayer();
        var projector = new Projector();
        var soundSystem = new SoundSystem();

        var homeTheater = new HomeTheaterFacade(dvdPlayer, projector, soundSystem);

        homeTheater.StartMovie("Inception");
        Console.WriteLine();
        homeTheater.EndMovie();
    }
}