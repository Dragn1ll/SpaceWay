using SpaceWay.Spacecraft.Deflector;
using SpaceWay.Spacecraft.Engine;

namespace SpaceWay.Spacecraft;

public abstract class SpaceCraft
{
    private IDeflector _deflector;
    private IEngine _engine;
    private int _bodyStrength;
    private int _fuel;
}
