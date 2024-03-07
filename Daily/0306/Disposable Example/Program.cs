class FileManager {
    public void Write(string path, string message) {
        StreamWriter stream = new(path);
        try {
            stream.WriteLine(message);
        } finally {
            stream.Dispose();
        }
    }

    /**
        EXAMPLE OF USING DISPOSE

        Rule of thumb when accessing file is CRUD
        Create, Read, Update, Delete

        After every access, the resource should be released immediately
    */

    public string Read(string path) {
        string result;

        // Keyword "using" simplifies try/catch/finally block with
        // addition of automatic Dispose
        // Will rethrow exception so method using this will need to
        // recatch the exception
        using (StreamReader stream = new(path)) {
            result = stream.ReadLine();
        }
        return result;
    }
}