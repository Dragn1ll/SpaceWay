﻿namespace SpaceWay.Spacecraft.Deflector;
public class Deflector(int deflectorClass) : IDeflector
{
    public int Strength { get; private set; } = deflectorClass switch
    {
        1 => 2,
        2 => 10,
        3 => 40,
        _ => throw new NotImplementedException()
    };

    public IPhotonicDeflector PhotonicDeflector { get; set; }

    public bool ReflectObstacle()
    {
        throw new NotImplementedException();
    }
}
