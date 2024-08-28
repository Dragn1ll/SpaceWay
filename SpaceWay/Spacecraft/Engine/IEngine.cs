namespace SpaceWay.Spacecraft.Engine;

public interface IEngine
{
    bool Fly(ref int fuel, int distance);
    bool StartEngine(ref int fuel);
}
