/* 
Розробіть додаток для моделювання складу. Створіть структуру
Item, що представляє товар на складі і містить поля для назви, кількості,
ціни та категорії товару. Використовуйте перелічування Item Category
для зазначення категорії товару (наприклад, Electronics, Furniture,
Food). Створіть клас Warehouse, що керує масивом товарів. В класі
реалізуйте методи для додавання, видалення, оновлення та
відображення товарів на складі.
*/

using System;

enum ItemCategory
{
    Electronics,
    Furniture,
    Food
}

struct Item
{
    public string Name;
    public int CountOf;
    public double Price;
    public ItemCategory Category;


    public Item(string name, int countof, double price, ItemCategory category)
    {
        Name = name;
        CountOf = countof;
        Price = price;
        Category = category;
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}, Count: {CountOf}, Price: {Price}, Category: {Category} ");
    }
}

class Warehouse
{
    private Item[] items = new Item[100];
    private int count = 0;

    public void AddItem(Item item)
    {
        if (count < items.Length)
        {
            items[count] = item;
            count++;
        }
    }
    public void RemoveItem(string name)
    {
        for (int i = 0; i < count; i++)
        {
            if (items[i].Name == name)
            {
                for (int j = i; j < count; j++)
                {
                    items[j] = items[j + 1];
                }
                count--;
                return;
            }
        }
    }

    public void UpdateItem(string name, int countof, double price)
    {
        for (int i = 0; i < count; i++)
        {
            if (items[i].Name == name)
            {
                items[i].CountOf = countof;
                items[i].Price = price;
                return;
            }
        }
    }

    public void ShowAll()
    {
        for (int i = 0; i < count; i++)
        {
            items[i].Show();
        }
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Warehouse wh = new Warehouse();

            wh.AddItem(new Item("Laptop", 5, 15000, ItemCategory.Electronics));
            wh.AddItem(new Item("Table", 10, 8000, ItemCategory.Furniture));
            wh.AddItem(new Item("Apple", 50, 10, ItemCategory.Food));

            Console.WriteLine("====== Items: ========");
            wh.ShowAll();

            Console.WriteLine("\n===== Update Laptop ====");
            wh.UpdateItem("Laptop", 3, 12500);
            wh.ShowAll();

            Console.WriteLine("\n ===== Remove Table =======");
            wh.RemoveItem("Table");
            wh.ShowAll();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}