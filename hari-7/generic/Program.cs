/*
public class ToyBox<T> {
    private T toy;
    public void AddToy(T newToy) {
        toy = newToy;
    }

    public T GetToy() {
        return toy;
    }
}

class Program {
    static void Main(string[] args) {
        ToyBox<string> dollBox = new ToyBox<string>();
        dollBox.AddToy("Barbie");
        Console.WriteLine("Mainan dalam dollBox: " + dollBox.GetToy());

        ToyBox<string> carBox = new ToyBox<string>();
        carBox.AddToy("Hot Wheels");
        Console.WriteLine("Mainan carBox: " + carBox.GetToy());

        ToyBox<int> totalToy = new ToyBox<int>();
        totalToy.AddToy(5);
        Console.WriteLine("Jumlah mainan" + totalToy.GetToy());

        ToyBox<bool> anyToy = new ToyBox<bool>();
        anyToy.AddToy(false);
        Console.WriteLine("any toy?" + anyToy.GetToy());
    }
}
*/

public class Inventory<T> {
    private T _item;
    public void AddItem(T newItem) {
        _item = newItem;
    }
    public T GetItem() {
        return _item;
    }
}

class Program {
    static void Main(string[] args) {
        Inventory<string> pedang = new Inventory<string>();
        pedang.AddItems("Katana");
        Console.WriteLine("Item dalam pedang:" + Pedang.GetItem());


    }
}