using System.Text.Json;
using System.Xml.Serialization;

public class HumanJson {
    public string Name {get; set;}
    public int Age {get; set;}
    public HumanJson(string name, int age) {
        Name = name;
        Age = age;
    }
}

public class HumanXML {
    public string Name {get; set;}
    public int Age;
    public HumanXML() {}
    public HumanXML(string name, int age) {
        Name = name;
        Age = age;
    }

}

public class Program {
    static void Main(string[] args) {
        var hj1 = new HumanJson("Kinara", 25);
		var hj2 = new HumanJson("Dion", 22);
		var hj3 = new HumanJson("Gracia", 22);
		var humans = new List<HumanJson> { hj1, hj2, hj3 };

		string json = JsonSerializer.Serialize(humans);
		using (StreamWriter sw = new("file.json")) {
			sw.Write(json);
		}

        string resultJSON;
        using (StreamReader sr = new("file.json")) {
            resultJSON = sr.ReadToEnd();
        }
        HumanJson[] humanJsons = JsonSerializer.Deserialize<HumanJson[]>(resultJSON);
        foreach (var hj in humanJsons) {
            Console.WriteLine(hj.Name);
            Console.WriteLine(hj.Age);
        }



        var hx1 = new HumanXML("Adit", 24);
        var hx2 = new HumanXML("Rafif", 25);
        var hx3 = new HumanXML("Yudha", 25);
        var hxs = new List<HumanXML> {hx1, hx2, hx3};
        var xml = new XmlSerializer(typeof(List<HumanXML>));
        using (StreamWriter sw = new StreamWriter("file.xml")) {
            xml.Serialize(sw, hxs);
        }
        HumanXML[] humanXMLs;
        using (StreamReader sr = new("file.xml")) {
            humanXMLs = (HumanXML[]) xml.Deserialize(sr);
        }
        foreach (var hx in humanXMLs) {
			Console.WriteLine(hx.Name);
			Console.WriteLine(hx.Age);
        }
    }
}