class Human {
    private static int count;
    private int _balance;

    public Human(int money) {
        _balance = money;
    }

    // Static variable accessed by Static method
    // OK
    public static int GetCountStatic() {
        return count;
    }

    // Static variable accessed by Non-static method
    // OK
    public int GetCount() {
        return count;
    }

    // Non-static variable accessed by Static method
    // NOT OK
    // public static int GetBalanceStatic() {
    //     return _balance;
    // }

    // Non-static variable accessed by Non-static method
    // OK
    public int GetBalance() {
        return _balance;
    }
}