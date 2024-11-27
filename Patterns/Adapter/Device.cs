namespace Patterns.Adapter;

public class Device(ITarget powerSource) {

    public void Charge() {
        Console.WriteLine("Device is charing: " + powerSource.GetPower());
    }
}