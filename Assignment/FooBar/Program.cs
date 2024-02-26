using FooBar;
class Program {
    static void Main(string[] args)
    {
        bool exit = false;
        FooBarRunning();
        while (!exit) {
            Console.Write("Again? Y/N > ");
            string e = Console.ReadLine().ToLower();
            switch (e) {
                case "n":
                case "no":
                    exit = true;
                    break;
                case "y":
                case "yes":
                    FooBarRunning();
                    break;
                default:
                    break;
            }
        }
    }

    static void FooBarRunning() {
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

        string[] temp = FooBar.FooBar.ResultArray(num);
        for (int i = 0; i < num + 1; i++) {
            Console.WriteLine($"{i}: {temp[i]}");
        }
        Console.WriteLine(FooBar.FooBar.ResultString(num));
    }
}