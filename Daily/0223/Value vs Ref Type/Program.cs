class Program {
    static void Main(string[] args)
    {
        // Value type
        // Method creates a copy of the value then modifies the copy
        // Variable a itself is not modified; original not modified, just copied
        // If not assigned, then not saved
        int a = 2;
        IncrementerInt(a);
        Console.WriteLine("value type, normal: " + a);

        // Reference type
        // Variable c located in stack stores the heap address
        // Modifies the reference 
        Car c = new(2);
        IncrementerCar(c);
        Console.WriteLine("reference type, normal: " + c.price);



        // Value type
        // Using keyword ref allows modification of variable value
        int a1 = 2;
        IncrementerIntRef(ref a1);
        Console.WriteLine("value type, ref keyword: " + a1);
        
        // Value type
        // Using keyword out ignores the input variable value
        // Assigns variable value according to method
        int a2 = 2;
        IncrementerIntOut(out a2);
        Console.WriteLine("value type, out keyword: " + a2);

        // Value type
        // Using keyword in explicitly tells to keep input variable as readonly
        // Behaviour similar to w/o the keyword
        // Helps with optimisation, lesser memory consumption
        int a3 = 2;
        int b3 = IncrementerIntIn(in a3);
        Console.WriteLine("value type, in keyword, input parameter: " + a3);
        Console.WriteLine("value type, in keyword, method output: : " + b3);
    }



    static void IncrementerInt(int i) {
        i++;
    }

    static void IncrementerIntRef(ref int i) {
        i++;
    }

    /**

    Coz input variable value is ignored, method needs to initialise value
    Then method can modify value and save it to the input variable name
    CANNOT ACCESS ORIGINAL VALUE OF INPUT PARAMETER
    INPUT PARAMETER MUST BE ASSIGNED A VALUE BY END OF METHOD
    
    */
    static void IncrementerIntOut(out int i) {
        i = 0;
        i++;
    }

    // Same behaviour as IncrementerInt, but more efficient
    static int IncrementerIntIn(in int i) {
        int result = i + 1;
        return result;
    }



    static void IncrementerCar(Car a) {
        a.price++;
    }
}

class Car {
    public int price;
    public Car(int price) {
        this.price = price;
    }
}
