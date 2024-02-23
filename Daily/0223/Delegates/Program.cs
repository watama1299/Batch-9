using System.Reflection;

public delegate void DelegateNoParam();
public delegate void DelegateParam(string str);
public delegate int DelegateReturn();

class Program {
    static void Main(string[] args)
    {
        Laptop laptop = new();
        Lamp lamp = new();
        AirCond airCond = new();

        // Adding parameterless methods to the delegate with no parameters
        DelegateNoParam on = laptop.PushOnButton;
        on += lamp.SwitchOn;
        on += airCond.AcRemoteOn;

        // Adding 1-parameter methods to the delegate with 1 parameter
        DelegateParam off = laptop.PushOffButton;
        off += lamp.SwitchOff;
        off += airCond.AcRemoteOff;

        // Adding methods with int return to the delegate with int return
        DelegateReturn num = laptop.Number;
        num += lamp.Number;
        num += airCond.Number;

        // Calling delegates to run methods
        on();
        off("off");
        // Will only print return value of the final method in the delegate
        Console.WriteLine(num());


        // To get all return values of method, need to get the invocation list
        // Loop thru invocation list, and run the methods
        // Store return values somewhere
        Delegate[] delegates = num.GetInvocationList();
        int[] delNums = new int[delegates.Length];
        for(int i = 0; i < delegates.Length; i++) {
            DelegateReturn temp = (DelegateReturn) delegates[i];
            delNums[i] = temp();
            Console.WriteLine($"{temp.Target}.{temp.Method.Name} returns {delNums[i]}");
        }
    }
}

class Laptop {
    public void PushOnButton() {
        Console.WriteLine("Laptop turned on");
    }
    public void PushOffButton(string s) {
        Console.WriteLine($"Laptop turned {s}");
    }
    public int Number() {return 1;}
}

class Lamp {
    public void SwitchOn() {
        Console.WriteLine("Light turned on");
    }
    public void SwitchOff(string s) {
        Console.WriteLine($"Light turned {s}");
    }
    public int Number() {return 2;}
}

class AirCond {
    public void AcRemoteOn() {
        Console.WriteLine("A/C turned on");
    }
    public void AcRemoteOff(string s) {
        Console.WriteLine($"A/C turned {s}");
    }
    public int Number() {return 3;}
}