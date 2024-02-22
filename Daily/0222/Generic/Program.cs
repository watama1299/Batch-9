using System.Numerics;

// Interface with property with only get
interface IItem {
    int Price {get;} // If set not specified when implemented, then becomes readonly
}

abstract class Item : IItem {
    private string itemName;
    private string type;
    // Interface implemented fulfilling public getter but specifying private setter
    public int Price{get; private set;}
}



// Making separate class for handling multiple data to avoid tuples
class Data<T, T2> {
    private T data;
    private T2 data2;
    public Data(T data, T2 data2) {
        this.data = data;
        this.data2 = data2;
    }
}



class ShoppingList<T, T2>
    // Multiple constraints possible
    // T is inheritance constraint
    // T2 is interface constraint
    where T : Item
    where T2 : INumber<T2> {
    private Data<T, T2>[] myArray;
    private int index = 0;

    public ShoppingList(int count) {
        myArray = new Data<T, T2>[count];
    }

    public bool AddItem(T t, T2 t2) {
        if (index == myArray.Length - 1) return false;

        myArray[index] = new Data<T, T2>(t, t2);
        return true;
    }

    public Data<T, T2> GetItem() {
        return myArray[index-1];
    }
}



class Program {
    static void Main(string[] args)
    {
        var list = new ShoppingList<Item, int>(20);
    }
}