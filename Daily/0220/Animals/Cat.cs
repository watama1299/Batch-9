namespace Animals;

public class Cat : Animal {
    public string name;

    public Cat(string colour, string gender, string name) : base(colour, gender) {
        this.name = name;
        Console.WriteLine("Cat class created");
    }
    
    public void Meow() {
        Console.WriteLine("meow");
    }
}