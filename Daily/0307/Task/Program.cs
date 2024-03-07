class Program {
    static async Task Main(string[] args) {
        // Normal task
        Task t1 = new Task(() => Console.WriteLine("t1"));
        t1.Start();



        // Starting task without having to create a new Task
        Task t2 = Task.Run(() => Console.WriteLine("t2"));



        // Task with return value
        Task<string> t3 = new Task<string>(GiveString);
        t3.Start();



        // Exception handling for task
        // 
        Task t4 = new Task(() => ExceptionMaker());
        try {
            t4.Start();
        } catch (AggregateException e) {
            Console.WriteLine(e);
        }



        // Task equivalent of Thread.Join is Wait
        // If there's a lot of Tasks, you can put everything in a Task[]
        // Then pass the array to WaitAll
        // WhenAll better - await async
        Task[] tasks = {t1, t2, t3};
        Task.WaitAll(tasks);



        // Task properties to check Task status
        Console.WriteLine(t1.IsCompletedSuccessfully);
        Console.WriteLine(t2.IsCompleted);
        Console.WriteLine(t3.IsFaulted);
        Console.WriteLine(t4.IsFaulted);
    }

    static string GiveString() {
        Console.WriteLine("string");
        return "string";
    }

    static void ExceptionMaker() {
        throw new Exception();
    }
}