namespace Patterns.Facade;

public class SoundSystem {
    public void On() => Console.WriteLine("Sound System is On.");
    public void SetVolume(int level) => Console.WriteLine($"Sound System volume set to {level}.");
    public void Off() => Console.WriteLine("Sound System is Off.");
}