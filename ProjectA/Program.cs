// See https://aka.ms/new-console-template for more information
class Program {
    static void Main() {
        Cat catA = new Cat();
        catA.name = "A";
        catA.colour = "amber";
        catA.age = 1;
        catA.isAlive = true;

        Console.WriteLine(catA.name + ", " + catA.colour + ", " + catA.age + ", " + catA.isAlive);
        catA.Walk();

        Cat catB = new Cat();
        catB.name = "B";
        catB.colour = "burgundy";
        catB.age = 2;
        catB.isAlive = false;

        Console.WriteLine(catB.name + ", " + catB.colour + ", " + catB.age + ", " + catB.isAlive);
        catB.Jump();
    }
}

class Cat {
    public string name;
    public string colour;
    public int age;
    public bool isAlive;


    public void Walk() {
        Console.WriteLine(name + " walks");
    }
    public void Jump() {
        Console.WriteLine(name + " jumps");
    }
}
