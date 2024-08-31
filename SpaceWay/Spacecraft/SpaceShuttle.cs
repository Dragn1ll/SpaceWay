using SpaceWay.Spacecraft.Deflector;
using SpaceWay.Spacecraft.Engine;

namespace SpaceWay.Spacecraft;

public class SpaceShuttle : SpaceCraft
{
    private IDeflector _deflector;
    private IEngine _engine;
    private int _bodyStrength;
    private int _fuel;

    public SpaceShuttle()
    {

    }

    public override bool TryFlySection()
    {
        throw new NotImplementedException();
    }
}
