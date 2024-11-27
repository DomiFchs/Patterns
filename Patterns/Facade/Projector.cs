namespace Patterns.Facade;

public class Projector {
    public void On() => Console.WriteLine("Projector is On.");
    public void SetWideScreenMode() => Console.WriteLine("Projector in widescreen mode.");
    public void Off() => Console.WriteLine("Projector is Off.");
}