using System.Text;

class Program {
    static void Main(string[] args) {
        using (FileStream fs = new("test.txt", FileMode.OpenOrCreate, FileAccess.Write)) {
            string text = "NEW FILE CREATED";
            byte[] bytes = new byte[text.Length];
            bytes = Encoding.UTF8.GetBytes(text);
            fs.Write(bytes, 0, bytes.Length);
        }
        Console.ReadLine();


        
        string result;
        using (FileStream fs = new("test.txt", FileMode.Open)) {
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, (int) fs.Length);
            result = Encoding.UTF8.GetString(bytes);
        }
        Console.WriteLine(result);
    }
}