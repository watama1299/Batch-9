class Program {
    static void Main(string[] args)
    {
        Food beefRendang = new(3);
        Food ayamPop = new(1);

        Food lauk = beefRendang + ayamPop;
        Console.WriteLine(lauk.Amount);
        Food moreBeefRendang = beefRendang + 2;
        Console.WriteLine(moreBeefRendang.Amount);
        Food lessBeefRendang = beefRendang - 2;
        Console.WriteLine(lessBeefRendang.Amount);
    }
}

class Food {
    public int Amount {get; private set;}
    public Food(int amount) {
        Amount = amount;
    }

    public static Food operator +(Food a, Food b) {
        return new Food(a.Amount + b.Amount);
    }

    public static Food operator +(Food a, int b) {
        return new Food(a.Amount + b);
    }

    public static Food operator -(Food a, int b) {
        return new Food(a.Amount - b);
    }
}