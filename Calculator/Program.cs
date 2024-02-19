class Program {
    static void Main(string[] args)
    {
        Calculator c = new Calculator();
        int add = c.Addition(1,2);
        int sub = c.Subtraction(2,1);
        int mult = c.Multiplication(2,3);
        int div = c.Division(4,2);

        Console.WriteLine($"add: {add}, sub: {sub}, mult: {mult}, div: {div}");
    }
}

class Calculator {
    public int Addition(int a, int b) {
        return a + b;
    }
    public int Subtraction(int a, int b) {
        return a - b;
    }
    public int Multiplication(int a, int b) {
        return a * b;
    }
    public int Division(int a, int b) {
        return a / b;
    }
}