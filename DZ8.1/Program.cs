class Item
{
    
}

class Order
{
    private List<Item> itemList;

    public IReadOnlyList<Item> GetItems() {/*...*/}
    public int GetItemCount() {/*...*/}
    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
    public void CalculateTotalSum() {/*...*/}
}

class OrderPrinter
{
    public void PrintOrder(Order order) {/*...*/}
    public void ShowOrder(Order order) {/*...*/}
}

class OrderPersistence
{
    public void Load(Order order) {/*...*/}
    public void Save(Order order) {/*...*/}
    public void Update(Order order) {/*...*/}
    public void Delete(Order order) {/*...*/}
}

//Така реструктуризація розділить функціональність класу Order на більш маленькі класи,
//кожен з яких відповідає лише за певний аспект роботи з замовленням.