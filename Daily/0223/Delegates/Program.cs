public delegate void DelegateNoParam();
public delegate void DelegateParam(string str);
public delegate int DelegateReturn();

class Program {
    static void Main(string[] args)
    {
        Laptop laptop = new();
        Lamp lamp = new();
        AirCond airCond = new();

        DelegateNoParam on = laptop.PushOnButton;
        on += lamp.SwitchOn;
        on += airCond.AcRemoteOn;

        DelegateParam off = laptop.PushOffButton;
        off += lamp.SwitchOff;
        off += airCond.AcRemoteOff;

        DelegateReturn num = laptop.Number;
        num += lamp.Number;
        num += airCond.Number;

        on();
        off("off");
        Console.WriteLine(num());
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