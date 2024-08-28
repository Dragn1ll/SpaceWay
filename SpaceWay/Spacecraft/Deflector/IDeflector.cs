namespace SpaceWay.Spacecraft.Deflector;
public interface IDeflector
{
    IPhotonicDeflector PhotonicDeflector { get; }
    bool ReflectObstacle();
}
