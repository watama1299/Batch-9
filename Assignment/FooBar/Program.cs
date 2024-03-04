using FooBar;
class Program {
    static void Main(string[] args)
    {
        var list = new SortedDictionary<int, string>
        {
            { 3, "foo" },
            { 5, "bar" },
            { 7, "fizz" },
            { 11, "buzz" }
        };


        bool exit = false;
        FooBarRunning(list);
        while (!exit) {
            Console.Write("Again? Y/N > ");
            var userInput = Console.ReadLine();
            userInput?.ToLower();
            switch (userInput) {
                case "n":
                case "no":
                    exit = true;
                    break;
                case "y":
                case "yes":
                    FooBarRunning(list);
                    break;
                default:
                    break;
            }
        }
    }

    static void FooBarRunning(SortedDictionary<int, string> list) {
        FooBar.FooBar fb = new(list);

        // Variable to hold user inputted number
        int num;
        Console.Write("Please input number > ");

        // User input validation
        bool correct = int.TryParse(Console.ReadLine(), out num);
        while (!correct || num < 0) {
            if (!correct) Console.WriteLine("Number not detected.");
            Console.Write("Please input a number greater than or equal to 0 > ");
            correct = int.TryParse(Console.ReadLine(), out num);
        }

        Console.WriteLine(fb.GetListAsString());
        string[] temp = fb.FromZeroResultArray(num);
        for (int i = 0; i < num + 1; i++) {
            Console.WriteLine($"{i}: {temp[i]}");
        }
    }
}