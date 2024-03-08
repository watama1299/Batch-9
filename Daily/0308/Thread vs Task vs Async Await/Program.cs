using System.Diagnostics;

class Program {
    static async Task Main(string[] args) {
        Stopwatch stopwatch = new();
        
        stopwatch.Start();
        ThreadExecution();
        stopwatch.Stop();
        long threadTime = stopwatch.ElapsedMilliseconds;
        

        stopwatch.Reset();
        stopwatch.Start();
        TaskExecution();
        stopwatch.Stop();
        long taskTime = stopwatch.ElapsedMilliseconds;

        stopwatch.Reset();
        stopwatch.Start();
        await AsyncAwaitExecution();
        stopwatch.Stop();
        long asyncTaskTime = stopwatch.ElapsedMilliseconds;

        Console.WriteLine($"Thread : {threadTime}ms");
        Console.WriteLine($"Task : {taskTime}ms");
        Console.WriteLine($"Async-Await Task : {asyncTaskTime}ms");
    }

    static void ThreadExecution() {
        Thread[] threads = new Thread[100];
        for (int i = 0; i < threads.Length; i++) {
            threads[i] = new Thread(() => Execution());
            threads[i].Start();
        }
        foreach (var i in threads) {
            i.Join();
        }
    }

    static void TaskExecution() {
        Task[] tasks = new Task[100];
        for (int i = 0; i < tasks.Length; i++) {
            tasks[i] = new Task(() => Execution());
            tasks[i].Start();
        }
        Task.WaitAll(tasks);
    }

    static async Task AsyncAwaitExecution() {
        Task[] asyncTasks = new Task[100];
        for (int i = 0; i < asyncTasks.Length; i++) {
            asyncTasks[i] = new Task(() => Execution());
            asyncTasks[i].Start();
        }
        await Task.WhenAll(asyncTasks);
    }

    static void Execution() {
        int iteration = 1000;
        for (int i = 0; i < iteration; i++) {
            
        }
    }
}