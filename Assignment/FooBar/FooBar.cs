namespace FooBar;

public class FooBar
{
    private SortedDictionary<int, string> _conditionList;

    public FooBar(SortedDictionary<int, string> conditionList) {
        _conditionList = conditionList;
    }


    public SortedDictionary<int, string> GetList() {
        return _conditionList;
    }

    public string GetListAsString() {
        string list = "";
        foreach (var kv in _conditionList) {
            list += $"[{kv.Key}: {kv.Value}] ";
        }
        return list;
    }

    public bool AddNewToList(int number, string word) {
        if (_conditionList.ContainsKey(number)) return false;
        _conditionList.Add(number, word);
        return true;
    }

    public bool RemoveFromList(int number) {
        if (!_conditionList.ContainsKey(number)) return false;
        _conditionList.Remove(number);
        return true;
    }

    public bool ReplaceStringFromList(int number, string newString) {
        if (!RemoveFromList(number)) return false;
        AddNewToList(number, newString);      
        return true;
    }

    public string SingleNumberResult(int num) {
        string output = "";
        // Logic
        foreach (var div in _conditionList) {
            if (num % div.Key == 0) {
                output += div.Value;
            }
        }

        if (output == "") output = num.ToString();
        return output;
    }

    public string FromZeroResultString(int endNum) {
        string output = "0";

        for (int i = 1; i < endNum + 1; i++) {
            output += ", ";
            output += SingleNumberResult(i);
        }

        // Print result to console
        return output;
    }

    public string[] FromZeroResultArray(int endNum) {
        return FromZeroResultString(endNum).Split(", ");
    }
}
