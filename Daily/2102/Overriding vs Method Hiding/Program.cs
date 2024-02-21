public class Animal {
    public virtual void Sound() {
        Console.WriteLine("animal make sound");
    }
}

public class Cat : Animal {
    // override keyword to signify overriding methods
    public override void Sound() {
        Console.WriteLine("cat meows");
    }
}

public class Dog : Animal {
    // new keyword to signify method hiding
    public new void Sound() {
        Console.WriteLine("dog barks");
    }
}

public class Program {
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Animal cat = new Cat();
        Animal dogAnimal = new Dog();
        Dog dogDog = new Dog();

        animal.Sound();
        cat.Sound(); // Overriding
        dogAnimal.Sound(); // Method Hiding
        dogDog.Sound();
    }
}