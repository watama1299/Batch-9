using Animals;

class Program {
    static void Main(string[] args)
    {
        Cat cat = new("yellow", "male", "cinamon");
		Console.WriteLine(cat.name);
		cat.Walk();
		cat.Breathe();
		cat.Meow();
    }
}