class Program {
    static void Main(string[] args)
    {
        InstanceCreator();
        GC.Collect();
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }
    static void InstanceCreator() {
        Human h = new();
    }
}

/**
    Objects that are instance of classes that have finalizers
    cannot be deleted by GC before it is put to G1. After it's
    put in G1, when the object is swept by the GC, the
    content of the finalizer will be executed then
    the object is deleted.
*/

class Human {
    public Human() {
        Console.WriteLine("Human created");
    }

    ~Human() {
        Console.WriteLine("Human about to be destroyed");
    }
}