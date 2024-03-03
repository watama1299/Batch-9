namespace FooBar;

public static class FooBar
{
    public static string SingleNumberResult(int num, SortedDictionary<int, string> replacementList) {
        string output = "";
        // Logic
        foreach (var div in replacementList) {
            if (num % div.Key == 0) {
                output += div.Value;
            }
        }

        if (output == "") output = num.ToString();
        return output;
    }

    public static string FromZeroResultString(int endNum, SortedDictionary<int, string> replacementList) {
        string output = "0";

        for (int i = 1; i < endNum + 1; i++) {
            output += ", ";
            output += SingleNumberResult(i, replacementList);
        }

        // Print result to console
        return output;
    }

    public static string[] FromZeroResultArray(int endNum, SortedDictionary<int, string> replacementList) {
        return FromZeroResultString(endNum, replacementList).Split(", ");
    }
}
