class Program {
    static void Main(string[] args)
    {
        Console.WriteLine(Calculator.Add(1,2));
        Console.WriteLine(Calculator.Add(1,2,3,4,5));
    }
}

static class Calculator {
    public static int Add(params int[] numbers) {
        int result = 0;
        foreach(int i in numbers) {
            result += i;
        }
        return result;
    }
}