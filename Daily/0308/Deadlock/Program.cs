class Program {
    static async Task Main() {
        Console.WriteLine("Program started");

        Task t1 = null;
        Task t2 = null;
        Task t3 = null;
        Task t4 = null;

        /**

            The only way to fix a deadlock is to fix it manually in code.
            If threads are waiting for each other to finish, then you
            need to let one finish then the other

        */

        Console.WriteLine("NO DEADLOCK");

        // Won't cause deadlock
        t3 = Task.Run(async () => {
            Console.WriteLine("Task 3 started");
            Console.WriteLine("Task 3 ended");
        });
        await t3;
        t4 = Task.Run(async () => {
            Console.WriteLine("Task 4 started");
            Console.WriteLine("Task 4 ended");
        });
        await t4;

        Console.WriteLine("DEADLOCK");

        // Will cause deadlock
        t1 = Task.Run(async () => {
            Console.WriteLine("Task 1 started");
            await t2;
            Console.WriteLine("Task 1 ended");
        });
        t2 = Task.Run(async () => {
            Console.WriteLine("Task 2 started");
            await t1;
            Console.WriteLine("Task 2 ended");
        });

        await Task.WhenAll(t1, t2);

        Console.WriteLine("Program ended");
    }
}