namespace Patterns.Adapter;

public class AdapterTest {

    public void Test() {
        var oldPowerSource = new OldPowerSource();

        ITarget adapter = new PowerAdapter(oldPowerSource);

        var device = new Device(adapter);
        device.Charge();
    }
}