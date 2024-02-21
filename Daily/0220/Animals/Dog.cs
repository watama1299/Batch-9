namespace Animals;

public class Dog : Animal {
    public string name;

    public Dog(string colour, string gender, string name) : base(colour, gender) {
        this.name = name;
        Console.WriteLine("Dog class created");
    }
    
    public void Bark() {
        Console.WriteLine("bark");
    }
}