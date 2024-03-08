class Program {
    /**
        Semaphore slim allows for multiple Threads to acquire same lock
    */

    static SemaphoreSlim semaphore = new(3);

    static async Task Main(string[] args) {
        Task[] tasks = new Task[10];
        for (int i = 0; i < tasks.Length; i++) {
            int index = i;
            tasks[i] = Task.Run(() => DoWork(index));
        }
        await Task.WhenAll(tasks);
    }
    static async Task DoWork(int index) {
        Console.WriteLine($"Task {index} started");

        await semaphore.WaitAsync();
        await Task.Delay(100);
        Console.WriteLine($"Task {index} processing...");
        await Task.Delay(100);
        semaphore.Release();

        Console.WriteLine($"Task {index} ended");
    }
}