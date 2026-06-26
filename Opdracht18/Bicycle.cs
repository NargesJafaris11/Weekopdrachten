namespace Weekopdrachten.Opdracht18;

public enum LockType
{
    RingLock,
    ChainLock,
    NoLock
}

public enum Color
{
    Black,
    Blue,
    Red,
    White,
    Green
}

public enum BicycleType
{
    Standard,
    Electric
}

public class Bicycle
{
    private double _rangeKm;

    public LockType Lock { get; set; }
    public int FrameHeight { get; set; }
    public Color Color { get; set; }
    public BicycleType Type { get; set; }
    public bool IsLocked { get; private set; }

    public double RangeKm
    {
        get { return _rangeKm; }
        set { _rangeKm = value; }
    }

    public double RangeMiles
    {
        get { return _rangeKm * 0.621371192; }
        set { _rangeKm = value / 0.621371192; }
    }

    public Bicycle(LockType lockType, int frameHeight, Color color, BicycleType type, double rangeKm)
    {
        Lock = lockType;
        FrameHeight = frameHeight;
        Color = color;
        Type = type;
        RangeKm = rangeKm;
    }

    public void LockBike()
    {
        IsLocked = true;
    }

    public void UnlockBike()
    {
        IsLocked = false;
    }

    public string Print()
    {
        return $"Slot: {Lock}\n" +
               $"Framehoogte: {FrameHeight}\n" +
               $"Kleur: {Color}\n" +
               $"Type: {Type}\n" +
               $"Range km: {RangeKm}\n" +
               $"Range miles: {RangeMiles:F2}\n" +
               $"Op slot: {IsLocked}\n";
    }
}