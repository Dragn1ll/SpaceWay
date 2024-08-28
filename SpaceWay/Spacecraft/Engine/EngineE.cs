namespace SpaceWay.Spacecraft.Engine;

public class EngineE : IEngine
{
    private int _fuelConsumption = 1;
    private const int _increaseSize = 10;

    public bool Fly(ref int fuel, int distance)
    {
        throw new NotImplementedException();
    }

    public bool StartEngine(ref int fuel)
    {
        throw new NotImplementedException();
    }
}
