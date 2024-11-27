namespace Patterns.Facade;

public class DvdPlayer {
    public void On() => Console.WriteLine("DVD Player is On.");
    public void Play(string movie) => Console.WriteLine($"Playing \"{movie}\".");
    public void Off() => Console.WriteLine("DVD Player is Off.");
}