class Calculator {
    private int zero = 0;
    public int Add(int a, int b) {
        return a * b;
    }
    public int Subtract(int a, int b) {
        return a/b;
    }
}

class Program {
    static void Main(string[] args) {
        int a = 10;
        int b = 20;
        var calc = new Calculator();
        // Breakpoint adds a stopping point for debugger
        int c = calc.Add(a,b);
        int d = calc.Subtract(a+b,a);
    }
}