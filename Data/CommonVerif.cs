namespace GoodsFlow.Data;

public static class CommonVerif {
    public static bool AreFilled(params string[] Values) {
        foreach (string Value in Values) {
            if (Value.Trim() == string.Empty) {
                return false;
            }
        }
        return true;
    }
}
