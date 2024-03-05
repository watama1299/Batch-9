class Program {
    static void Main(string[] args) {
        InstanceCreator();
        GC.Collect();
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }
    static void InstanceCreator() {
        Child c = new();
    }
}

/**
    When objects are instances that have inheritance,
    the child is deconstructed first, then goes up the
    base class all the way to ultimate base class
*/

abstract class GrandParent {
    ~GrandParent() {
        Console.WriteLine("Grandparent about to be destroyed");
    }
}

class Parent : GrandParent {
    ~Parent() {
        Console.WriteLine("Parent about to be destroyed");
    }
}

class Child : Parent {
    ~Child() {
        Console.WriteLine("Child about to be destroyed");
    }
}