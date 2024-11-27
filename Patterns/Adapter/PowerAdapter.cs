namespace Patterns.Adapter;

public class PowerAdapter(OldPowerSource oldPowerSource) : ITarget{
    public string GetPower() {
        return oldPowerSource.ProvidePower() + "-> Adapted to 220V";
    }
}