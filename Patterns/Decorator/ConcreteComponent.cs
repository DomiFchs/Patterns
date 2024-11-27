namespace Patterns.Decorator;

public class ConcreteComponent : IComponent{
    public void Operate() {
        Console.WriteLine("Basic Component");
    }
}