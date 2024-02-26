using System.Collections;

class Program {
    static void Main(string[] args)
    {
        // Array
        char[] name = new char[4];
        char[] name1 = {'a', 'd', 'i', 't'};
        char[] name2 = ['a', 'd', 'i', 't'];


        // ArrayList - like array but dynamic and not type safety
        ArrayList stuff = new();
        stuff.Add(1);
        stuff.Add("two");
        stuff.Add(true);


        // List<T> - equivalent to ArrayList in java.
        // Like ArrayList but type safe
        List<int> nums = new();
        nums.Add(4);
        nums.Add('c');
        

        // HashSet<T> - like List but stores only unique values
        // Acts like an actual set using set theory ie. UnionWith, IntersectWith, ExceptWith
        HashSet<char> chars = new();
        chars.Add('a');
        chars.Add('d');
        chars.Add('a'); // Ignores the duplicate, doesn't update index

        HashSet<char> chars1 = new();
        chars1.Add('b');
        chars1.Add('d');

        chars.UnionWith(chars1);
        foreach (char c in chars) {
            Console.WriteLine($"{c} ");
        }
        chars.IntersectWith(chars1);
        foreach (char c in chars) {
            Console.WriteLine($"{c} ");
        }
        chars.ExceptWith(chars1);
        foreach (char c in chars) {
            Console.WriteLine($"{c} ");
        }


        // LinkedList<T> - like list but stores values in front and behind it
        LinkedList<int> ints = new();
        ints.AddFirst(1);
        ints.AddLast(2);
        ints.AddLast(3);
        ints.AddFirst(4);
        foreach (int i in ints) {
            Console.Write($"{i} ");
        }


        // Dictionary - equivalent to HashMap in java
        Dictionary<int, string> dict = new();
        dict.Add(3, "foo");
        dict.Add(5, "bar");
        dict.Add(2, "fizz");
        Console.WriteLine(dict[2]);
        foreach (KeyValuePair<int, string> kv in dict) {
            Console.WriteLine($"{kv.Key}: {kv.Value}");
        }


        // SortedDictionary - Dictionary but ordered
        SortedDictionary<int, string> dict2 = new(dict);
        foreach (var kv in dict2) {
            Console.WriteLine($"{kv.Key}: {kv.Value}");
        }


        // SortedList - NOT A LIST. Dictionary but ordered
        // Different implementation than SortedDictionary
        SortedList<int, string> sList = new(dict);


        // Stack - push, pop, peek
        Stack<int> sInt = new();
        sInt.Push(2);
        sInt.Push(3);
        sInt.Pop();
        sInt.Peek();


        // Queue - enqueue, dequeue, peek
        Queue<int> qInt = new();
        qInt.Enqueue(2);
        qInt.Enqueue(3);
        qInt.Dequeue();
        qInt.Peek();
    }
}