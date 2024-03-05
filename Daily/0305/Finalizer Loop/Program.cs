using System.Diagnostics;

class Program {
    static void Main(string[] args) {
        int iteration = 1_000_000;
        Stopwatch sw = new();
        sw.Start();
        for(int i = 0; i < iteration; i++) {
            InstanceCreator();
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);

        /**
            Program takes longer to run with finalizer.
            Coz objects/instances not immediately deleted.
            Waits for next GC cycle to delete coz objects
            need to be moved to G1 first.
        */
    }
    static void InstanceCreator() {
        Human h = new();
    }
}

class Human {
    // ~Human() {Console.WriteLine("Human about to be destroyed");}
}