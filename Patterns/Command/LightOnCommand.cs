namespace Patterns.Command;

public class LightOnCommand(Light light) : ICommand{
    
    public void Execute() {
        light.On();
    }
}