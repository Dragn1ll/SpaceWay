namespace SpaceWay.Spacecraft.Deflector;
public interface IDeflector
{
    int Strength { get; }
    IPhotonicDeflector PhotonicDeflector { get; }
    bool ReflectObstacle();
}
