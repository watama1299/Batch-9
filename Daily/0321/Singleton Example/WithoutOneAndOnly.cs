class Program {
    static void Main(string[] args)
    {
        var obj1 = new WithoutOneAndOnly();
        var obj2 = new WithoutOneAndOnly();

        Console.WriteLine(obj1 == obj2);

        var obj3 = OneAndOnly.GetOneAndOnly();
        var obj4 = OneAndOnly.GetOneAndOnly();

        Console.WriteLine(obj3 == obj4);
    }
}

class WithoutOneAndOnly
{
    public WithoutOneAndOnly() {}

    public void DoSameThing() {
        Console.WriteLine("Do nothing");
    }
}

class OneAndOnly
{
    // Public static instance
    // Eager instantion => starts as null, only instantiated when first called
    private static OneAndOnly? oneAndOnlyInstance;
    public static readonly object obj = new();


    // Private constructor
    private OneAndOnly() {}

    // Public instance getter
    // Only way to access the instance
    public static OneAndOnly GetOneAndOnly() {
        if (oneAndOnlyInstance is null) {
            oneAndOnlyInstance = new();
        }

        return oneAndOnlyInstance;
    }

    // Thread safe version using locks
    public static OneAndOnly GetOneAndOnlySafe() {
        if (oneAndOnlyInstance is null) {
            lock (obj) {
                if (oneAndOnlyInstance is null) {
                    oneAndOnlyInstance = new();
                }
            }
        }

        return oneAndOnlyInstance;
    }

    public void DoSomething() {
        Console.WriteLine("Do nothing");
    }
}