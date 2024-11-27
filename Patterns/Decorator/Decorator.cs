namespace Patterns.Decorator;

public class Decorator(IComponent component) : IComponent {

    public void Operate() {
        Console.WriteLine("Extended");
        component.Operate();
    }
}