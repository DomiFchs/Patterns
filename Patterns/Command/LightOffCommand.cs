namespace Patterns.Command;

public class LightOffCommand(Light light) : ICommand{
    
    public void Execute() {
        light.Off();
    }
}