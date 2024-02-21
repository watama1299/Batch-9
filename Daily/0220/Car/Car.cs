namespace Vehicle;

public class Car
{
    public Engine engine;
    public Tire tire;

    public string brand;
    public string colour;
    public int capacity;

    public Car(
        Engine engine,
        Tire tire,
        string brand,
        string colour,
        int capacity
        ) {
            this.engine = engine;
            this.tire = tire;
            this.brand = brand;
            this.colour = colour;
            this.capacity = capacity;
        }
}
