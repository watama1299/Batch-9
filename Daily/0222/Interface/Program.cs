public interface IDevice {
    void TurnOn();
    void TurnOff();
    void Restart();
}
public interface IWireless {
    void Connect();
	void Disconnect();
}
public interface IBluetooth {
	void Connect();
	void Disconnect();
}
public interface ICalling {
    void SendCall();
    void ReceiveCall();
}



// Grouping multiple interfaces into 1 interface
public interface IPhone : IDevice, IWireless, IBluetooth, ICalling;
public interface ILaptop : IDevice, IWireless;



public class Smartphone : IPhone {
    public void TurnOn() {}
    public void TurnOff() {}
    public void Restart() {}
    
    
    void IWireless.Connect() {Console.WriteLine("Smartphone IWireless Connect");}
    void IWireless.Disconnect() {Console.WriteLine("Smartphone IWireless Disconnect");}
    void IBluetooth.Connect() {Console.WriteLine("Smartphone IBluetooth Connect");}
    void IBluetooth.Disconnect() {Console.WriteLine("Smartphone IBluetooth Disconnect");}
    
    
    public void SendCall() {}
    public void ReceiveCall() {}
}

public class Laptop : ILaptop {
    public void TurnOn() {}
    public void TurnOff() {}
    public void Restart() {}
    public void Connect() {}
    public void Disconnect() {}
}



class MyDevices {
    // All objects implementing IDevice interface can be put inside array (ie. both Smartphone & Laptop)
    private IDevice[] devices;
    public void AddDevice(IDevice device) {
        
    }
}

class Program {
    static void Main(string[] args)
    {
        Smartphone sp = new();
        IWireless wireless = sp;
        wireless.Connect(); // Calls IWireless.Connect()

        IBluetooth bt = sp;
        bt.Connect(); // Calls IBluetooth.Connect()
    }
}