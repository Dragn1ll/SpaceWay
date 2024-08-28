namespace SpaceWay.Spacecraft.Engine;

public class EngineC : IEngine
{
    private int _speed = 1;
    private int _fuelConsumption = 1;

    public bool Fly(ref int fuel, int distance)
    {
        throw new NotImplementedException();
    }

    public bool StartEngine(ref int fuel)
    {
        throw new NotImplementedException();
    }
}
