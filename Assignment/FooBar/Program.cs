class Program {
    static void Main(string[] args)
    {
        FooBar();
    }

    static void FooBar() {
        // Variable to hold user inputted number
        int num;
        Console.Write("Please input number > ");

        // User input validation
        bool correct = int.TryParse((string) Console.ReadLine(), out num);
        while (!correct) {
            Console.Write("Number not detected. Please input a number > ");
            correct = int.TryParse(Console.ReadLine(), out num);
        }

        FooBarManual(num);
    }

    static void FooBarManual(int num) {
        // Logic
        string output = "0";
        for (int i = 1; i < num + 1; i++) {
            output += ", ";
            if (i % 3 != 0 && i % 5 != 0) {
                output += i.ToString();
            }
            if (i % 3 == 0) {
                output += "foo";
            }
            if (i % 5 == 0) {
                output += "bar";
            }
        }

        // Print result to console
        Console.WriteLine(output);
    }
}