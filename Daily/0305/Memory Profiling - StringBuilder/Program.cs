using System.Diagnostics;
using System.Text;

class Program {
    static void Main(string[] args)
    {
        StringBuilder s = new();
        int loop = 1_000_000_000;

        Stopwatch sw = new();
        sw.Start();
        for (int i = 0; i < loop; i++) {
            s.Append('a');
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}