namespace Animals;

public class Animal {
    public string colour;
    public string gender;

    public Animal(string colour, string gender) {
        this.colour = colour;
        this.gender = gender;
        Console.WriteLine("Animal class created");
    }

    public void Walk() {
        Console.WriteLine("Walk");
    }
    public void Breathe() {
        Console.WriteLine("Breathe");
    }
}