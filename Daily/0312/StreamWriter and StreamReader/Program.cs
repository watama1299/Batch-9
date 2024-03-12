class Program {
    static async Task Main(string[] args) {
        using (FileStream fs = new("test.txt", FileMode.Create)) {
            using (StreamWriter sw = new(fs)) {
                sw.WriteLine("Hello world!");
            }
        }
        string? result;
        using (FileStream fs = new("test.txt", FileMode.Open)) {
            using (StreamReader sr = new(fs)) {
                result = sr.ReadLine();
            }
        }
        Console.WriteLine(result);
        Console.WriteLine();



        using (StreamWriter sw = new("test.txt")) {
            sw.WriteLine("Overwrite old file");
        }
        using (StreamReader sr = new("test.txt")) {
            result = sr.ReadToEnd();
        }
        Console.WriteLine(result);
        Console.WriteLine();



        using (StreamWriter sw = new("test.txt", true)) {
            sw.WriteLine("Add new string in new line");
        }
        using (StreamReader sr = new("test.txt")) {
            result = sr.ReadToEnd();
        }
        Console.WriteLine(result);
        Console.WriteLine();



        using (StreamWriter sw = new("test.txt", true)) {
            await sw.WriteLineAsync("Me first!");
            await sw.WriteLineAsync("No! Me first!");
        }
        using (StreamReader sr = new("test.txt")) {
            result = sr.ReadToEnd();
        }
        Console.WriteLine(result);
        Console.WriteLine();



        /**
            IF NEED TO READ AND WRITE, USE 2 SEPARATE BLOCKS
            WHEN STREAMWRITE EXITS OUT OF USING, IT DISPOSE ITSELF AND FILESTREAM
            SO STREAMREADER CANNOT READ FILESTREAM
        */
        using (FileStream fs = new("test.txt", FileMode.Create)) {
            using (StreamWriter sw = new(fs)) {
                sw.WriteLine("Hello world!");
            }
            using (StreamReader sr = new(fs)) {
                result = sr.ReadToEnd();
            }
        }
        Console.WriteLine(result);
    }
}