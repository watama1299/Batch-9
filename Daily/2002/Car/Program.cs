using Vehicle;

class Program {
    static void Main(string[] args)
    {
        Engine engine = new(8, 400, 500, "i4");
		Tire tire = new("toyo", 17);
		Car car = new Car(engine, tire, "toyota", "white", 5);
        Console.WriteLine($"{car.engine}, {car.tire.tireBrand}, {car.brand}, {car.colour}, {car.capacity}");
        Tire tire2 = new("yokohama", 17);
		car.tire = tire2;
        Console.WriteLine($"{car.engine}, {car.tire.tireBrand}, {car.brand}, {car.colour}, {car.capacity}");
    }
}