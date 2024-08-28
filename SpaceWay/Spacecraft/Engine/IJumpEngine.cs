namespace SpaceWay.Spacecraft.Engine;

public interface IJumpEngine
{
    bool Jump(ref int fuel, int distance);
}
