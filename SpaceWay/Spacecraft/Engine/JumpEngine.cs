namespace SpaceWay.Spacecraft.Engine;

public class JumpEngine(JumpEngineClass jumpEngineClass) : IJumpEngine
{
    private Func<int, double> _fuelConsumption = jumpEngineClass switch
    {
        JumpEngineClass.Alpha => n => n,
        JumpEngineClass.Omega => n => n * Math.Log(n),
        JumpEngineClass.Gamma => n => n * n,
        _ => throw new NotImplementedException()
    };

    public bool Jump(ref int fuel, int distance)
    {
        throw new NotImplementedException();
    }
}
