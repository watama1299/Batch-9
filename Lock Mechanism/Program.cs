class Program {
    public static object obj = new object();
    static int Counter = 0;

    static async Task Main(string[] args) {
        Console.WriteLine("Program started");

        Task t1 = Task.Run(() => Incrementer());
        Task t2 = Task.Run(() => Incrementer());
        await Task.WhenAll(t1, t2);

        Console.WriteLine("Program ended");
    }
    static async Task Incrementer() {
        for (int i = 0; i < 100; i++) {
            lock(obj) {
                Counter++;
                Console.WriteLine(Counter);
            }
            await Task.Delay(100);
        }
    }
}