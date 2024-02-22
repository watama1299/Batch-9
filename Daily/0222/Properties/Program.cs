class Car
{
    // Public Property => Public & stricter getter setter

    // Private Property => Private getter setter
    // Can create public method to set value of Property


    // Default Property implementation
    public string Colour { get; private set; }

    // Customised Property implementation
    // Requires separate variable if wanna modify input b4 storing value
    private int _age = -1;
    public int Age
    {
        get
        {
            return _age;
        }
        private set
        {
            // value => default input variable name
            _age = 2024 - value;
        }
    }

    public Car(string colour, int year)
    {
        Colour = colour;
        Age = year;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new("yellow", 1990);
        Console.WriteLine(car1.Age);
        Car car2 = new("white", 1980);
        Console.WriteLine(car2.Age);
    }
}