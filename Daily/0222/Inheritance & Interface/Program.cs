public interface IEngine {
    void EngineOn();
    void EngineOff();
}

public interface ILandSpeed {
    void LandSpeed();
}

public abstract class Vehicle : IEngine {
    public void EngineOn() {
        Console.WriteLine("Engine On");
    }
    public void EngineOff() {
        Console.WriteLine("Engine Off");
    }
    public abstract void RelativeSpeed();
}

// Class can have inheritance and interface at same time
// ONLY ONE inheritance but MANY interface possible
public class Car : Vehicle, ILandSpeed {
    public void LandSpeed() {
        Console.WriteLine("Land speed x km/h");
    }
    public override void RelativeSpeed()
    {
        Console.WriteLine("Relative speed is x km/h");
    }
}