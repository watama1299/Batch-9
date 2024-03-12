using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


[DataContract]
class Human {
    [DataMember]
    private string _name;
    [DataMember]
    private int _age;
    public string Address {get; set;}
    // try having object

    public Human(string name, int age) {
        _name = name;
        _age = age;
        Address = "default";
    }

    public string GetName() {
        return _name;
    }
    public int GetAge() {
        return _age;
    }
}

class Program {
    static void Main(string[] args) {
        var human = new Human("Adit", 24);
        DataContractJsonSerializer serializer = new(typeof(Human));
        using (FileStream fs = new("file.json", FileMode.Create)) {
            serializer.WriteObject(fs, human);
        }


        Human result;
        using (FileStream fs = new("file.json", FileMode.Open)) {
            result = (Human) serializer.ReadObject(fs);
        }
        Console.WriteLine(result.GetName());
        Console.WriteLine(result.GetAge());
    }
}