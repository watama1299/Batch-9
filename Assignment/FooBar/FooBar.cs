namespace FooBar;

public class FooBar
{
    public static string ResultString(int num) {
        // Logic
        string output = "0";
        for (int i = 1; i < num + 1; i++) {
            output += ", ";
            if (i % 3 != 0 && i % 5 != 0) {
                output += i.ToString();
            }
            if (i % 3 == 0) {
                output += "foo";
            }
            if (i % 5 == 0) {
                output += "bar";
            }
        }

        // Print result to console
        return output;
    }

    public static string[] ResultArray(int num) {
        return ResultString(num).Split(", ");
    }
}
