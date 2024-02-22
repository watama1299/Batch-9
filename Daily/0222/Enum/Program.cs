public enum VehicleType {
    // Numerical value can be any integral numeric types ie. int, long, byte
    Car = 4,
    Truck = 6,
    Motorcycle = 2
}

// Enums can be used for type checking
// Safer than using string
class Vehicle {
    private VehicleType Type {get; set;}
    public Vehicle() {}

    public void CheckType() {
        if (Type == VehicleType.Motorcycle) {
            Console.WriteLine(VehicleType.Motorcycle);
        }
        if (Type == VehicleType.Car) {
            Console.WriteLine(VehicleType.Car);
        }
        if (Type == VehicleType.Truck) {
            Console.WriteLine(VehicleType.Truck);
        }
    }

    public bool ChangeVehicle(VehicleType vehicleType) {
        if (Type == vehicleType) return false;

        Type = vehicleType;
        return true;
    }
}

public class Program {
    static void Main(string[] args)
    {
        var values = Enum.GetValues(typeof(VehicleType));
        foreach (var i in values) {
        // Getting the numerical value of the enums by CASTING
            int num = (int) i;
            Console.WriteLine($"{i} = {num}");
        }

        // Getting the enums from numerical value by CASTING
        int wheels = 2;
        VehicleType vt = (VehicleType) wheels;
        Console.WriteLine(vt);
    }
}