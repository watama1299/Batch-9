using System.Diagnostics;

class Program {
    static void Main(string[] args)
    {
        string s = "";
        int loop = 100000;

        Stopwatch sw = new();
        sw.Start();
        for (int i = 0; i < loop; i++) {
            s += "a";
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}