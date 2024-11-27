namespace Patterns.Command;

public class CommandTest {


    public void Test() {
        var light = new Light();

        ICommand onCommand = new LightOnCommand(light);
        ICommand offCommand = new LightOffCommand(light);
        
        onCommand.Execute();
        offCommand.Execute();
    }
}