public class Program {
    static void Main(string[] args)
    {
        // Implicit upcasting: int 4 byte -> float 4 byte
        // from integral type to float type
        int a = 2;
        float b = a;
        Console.WriteLine(b);

        // Explicit downcasting: float 4 byte -> int 4 byte
        // from float type to integral type
        float c = 3.1f;
        int d = (int) c;
        Console.WriteLine(d);

        // Implicit upcasting: int 4 byte -> double 8 byte
        // from integral type to float type
        int e = 2;
        double f = e;
        Console.WriteLine(f);

        // Explicit downcasting: double 8 byte -> int 4 byte
        // from float type to integral type
        double g = 3.1d;
        int h = (int) g;
        Console.WriteLine(h);

        // Implicit upcasting: int 4 byte -> long 8 byte
        // from integral type to integral type
        int i = 2;
        long j = i;
        Console.WriteLine(j);

        // Explicit downcasting: long 8 byte -> int 4 byte
        // from integral type to integral type
        long k = 3;
        int l = (int) k;
        Console.WriteLine(l);
    }
}