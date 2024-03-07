class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Print();
            Thread.Sleep(1000);
            TaskDelay();
        }
    }

    static void Print()
    {
        int a = 10;
        int b = 100;
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        Console.WriteLine($"a + b: {a + b}");
    }

    static async void TaskDelay()
    {
        Console.WriteLine("Task delay");
        await Task.Delay(1000);
    }
}