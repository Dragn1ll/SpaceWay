namespace SpaceWay.Spacecraft.Deflector;
public class PhotonicDeflector : IPhotonicDeflector
{
    public int ChargesNumber { get; private set; }

    public PhotonicDeflector()
    {
        ChargesNumber = 3;
    }

    public bool ReflectFlash()
    {
        throw new NotImplementedException();
    }
}
