class Program {
    static void Main(string[] args)
    {
        Employee empA = new Employee("dion", 69);
        Employee empB = new Employee();
        Employee empC = new Employee("dion", 69, "dion@fmlx.com");
    }
}

class Employee {
    public string name;
    public int id;
    public string email;

    public Employee() {
        name = "default";
        id = -1;
        email = "default@gmail.com";
        Console.WriteLine($"{name}, {id}, {email}");
    }
    public Employee(string nameIn, int idIn, string emailIn) {
        name = nameIn;
        id = idIn;
        email = emailIn;
        Console.WriteLine($"{name}, {id}, {email}");
    }
    public Employee(string nameIn, int idIn) {
        name = nameIn;
        id = idIn;
        Console.WriteLine($"{name}, {id}");
    }
}