class Program {
    static void Main(string[] args) {
        Task t1 = new Task(() => Console.WriteLine("t1"));
        t1.Start();
        t1.Wait();
        t1.

        Task.Run(() => Console.WriteLine("t2"));
    }
}