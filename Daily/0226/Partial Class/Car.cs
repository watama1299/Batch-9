namespace Car;

public partial class Car {
    public string Brand {get; private set;}
    public int Year {get; private set;}

    public Car(string brand, int year) {
        Brand = brand;
        Year = year;
    }
}