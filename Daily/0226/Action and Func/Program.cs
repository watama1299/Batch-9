using System.Reflection.Metadata.Ecma335;

enum State {
    On = 1,
    Off = 0
}

class Program {
    static event Action? On;
    static event Action<string>? Off;
    static event Func<int>? Num;
    static event Func<int, bool>? Age;
    static void Main(string[] args)
    {
        /**

            Action is the built-in delegate object w/ void return
            Action <- for void return and no param
            Action<T1, T2, ..., Tn> where T1 to Tn are types for param

            Func is built-in delegate object w/ return type
            Func<T1, T2, ..., Tn> where T1 to Tn-1 are types for param and Tn is return type

            for variable naming, both can be replaced with var for ease

        */

        Laptop laptop = new();
        Lamp lamp = new();
        AirCond airCond = new();

        // Adding parameterless methods to the Action with no parameters
        On += laptop.PushOnButton;
        On += lamp.SwitchOn;
        On += airCond.AcRemoteOn;

        // Adding 1-parameter methods to the Action with 1 parameter
        Off += laptop.PushOffButton;
        Off += lamp.SwitchOff;
        Off += airCond.AcRemoteOff;

        // Adding methods with int return to the Func with int return
        Num += laptop.GetSerialNumber;
        Num += lamp.GetSerialNumber;
        Num += airCond.GetSerialNumber;

        // Adding methods to the Func with bool return and 
        Age += laptop.OldOrNew;
        Age += lamp.OldOrNew;
        Age += airCond.OldOrNew;



        // Calling delegates to run methods
        On.Invoke();
        Off("off");

        Delegate[] numDelegates = Num.GetInvocationList();
        int[] numDels = new int[numDelegates.Length];
        for (int i = 0; i < numDelegates.Length; i++) {
            var dels = (Func<int>) numDelegates[i];
            numDels[i] = dels();
            Console.WriteLine($"{dels.Target}.{dels.Method.Name} returns {numDels[i]}");
        }


        var ageDelegates = Age.GetInvocationList();
        var ageDels = new bool [ageDelegates.Length];
        int value = 1999;
        for (int i = 0; i < ageDelegates.Length; i++) {
            var dels = (Func<int, bool>) ageDelegates[i];
            ageDels[i] = dels(value);
            value++;
            Console.WriteLine($"{dels.Target}.{dels.Method.Name} returns {ageDels[i]}");
        }
    }
}

class Laptop {
    private string? _state;
    public void PushOnButton() {
        _state = State.On.ToString();
        Console.WriteLine($"Laptop: {_state}");
    }
    public void PushOffButton(string s) {
        _state = State.Off.ToString();
        Console.WriteLine($"Laptop: {_state}");
    }
    public int GetSerialNumber() {return 123;}

    public bool OldOrNew(int year) {
        if (year > 2000) return true;
        return false;
    }
}

class Lamp {
    private string? _state;
    public void SwitchOn() {
        _state = State.On.ToString();
        Console.WriteLine($"Light: {_state}");
    }
    public void SwitchOff(string s) {
        _state = State.Off.ToString();
        Console.WriteLine($"Light: {_state}");
    }
    public int GetSerialNumber() {return 456;}

    public bool OldOrNew(int year) {
        if (year > 2000) return true;
        return false;
    }
}

class AirCond {
    private string? _state;
    public void AcRemoteOn() {
        _state = State.On.ToString();
        Console.WriteLine($"A/C: {_state}");
    }
    public void AcRemoteOff(string s) {
        _state = State.Off.ToString();
        Console.WriteLine($"A/C: {_state}");
    }
    public int GetSerialNumber() {return 789;}

    public bool OldOrNew(int year) {
        if (year > 2000) return true;
        return false;
    }
}