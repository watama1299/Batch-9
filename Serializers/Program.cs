using System.Text.Json;
using System.Xml.Serialization;

public class Human {
    public string Name {get; set;}
    public int age;

    public Human() {}
    public Human(string name, int age) {
        Name = name;
        this.age = age;
    }
}

class Program {
    static void Main(string[] args) {
        Human human = new Human("Kinara", 25);
		Human human2 = new Human("Dion", 22);
		Human human3 = new Human("Gracia", 22);
		List<Human> humans = new List<Human> { human, human2, human3 };

		string json = JsonSerializer.Serialize(humans);
		using(StreamWriter sw = new("file.json")) 
		{
			sw.Write(json);
		}

        var xml = new XmlSerializer(typeof(List<Human>));
    }
}