using System.Text;

class Program {
    static void Main(string[] args) {
        /**
            WILL RETURN EXCEPTION IF FILE IS ALREADY CREATED
        */
        using (FileStream fs = new("test.txt", FileMode.CreateNew, FileAccess.Write)) {
            string text = "FileMode.CreateNew";
            byte[] bytes = new byte[text.Length];
            bytes = Encoding.UTF8.GetBytes(text);
            fs.Write(bytes, 0, bytes.Length);
        }
        Console.ReadLine();



        /**
            WILL CREATE IF NOT FOUND, WILL OVERWRITE IF FOUND
        */
        using (FileStream fs1 = new("test.txt", FileMode.Create, FileAccess.Write)) {
            string text = "FileMode.Create";
            byte[] bytes = new byte[text.Length];
            bytes = Encoding.UTF8.GetBytes(text);
            fs1.Write(bytes, 0, bytes.Length);
        }
        Console.ReadLine();



        /**
            WILL CREATE IF NOT FOUND, WILL OPEN IF FOUND
            OPEN PUTS POINTER IN THE BEGINNING
            SO IF ADD DATA THEN WILL OVERWRITE
        */
        using (FileStream fs2 = new("test.txt", FileMode.OpenOrCreate, FileAccess.Write)) {
            string text = "FileMode.OpenOrCreate";
            byte[] bytes = new byte[text.Length];
            bytes = Encoding.UTF8.GetBytes(text);
            fs2.Write(bytes, 0, bytes.Length);
        }
        Console.ReadLine();



        /**
            WILL OPEN FILE AND ADD TO END OF FILE
        */
        using (FileStream fs3 = new("test.txt", FileMode.Append, FileAccess.Write)) {
            string text = ",FileMode.Append";
            byte[] bytes = new byte[text.Length];
            bytes = Encoding.UTF8.GetBytes(text);
            fs3.Write(bytes, 0, bytes.Length);
        }
        Console.ReadLine();



        /**
            WILL RETURN EXCEPTION COZ CREATE NEEDS WRITE ACCESS
        */
        // using (FileStream fs4 = new("test.txt", FileMode.Create, FileAccess.Read)) {
        //     string text = "FileMode.Create but FileAccess.Read";
        //     byte[] bytes = new byte[text.Length];
        //     bytes = Encoding.UTF8.GetBytes(text);
        //     fs4.Write(bytes, 0, bytes.Length);
        // }
        Console.WriteLine("Close file before going onwards...");
        Console.ReadLine();



        /**
            WILL LOCK ALL OTHERS FROM ACCESSING FILE UNTIL LET GO BY FILESTREAM
        */
        using (FileStream fs5 = new("test.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None)) {
            string text = "FileMode.OpenOrCreate";
            byte[] bytes = new byte[text.Length];
            bytes = Encoding.UTF8.GetBytes(text);
            fs5.Write(bytes, 0, bytes.Length);
            Console.WriteLine("File being accessed at the moment...");
            Console.ReadLine();
        }
        Console.ReadLine();
    }
}