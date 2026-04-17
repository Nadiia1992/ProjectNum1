using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

enum ItemCategory
{
    Electronics, 
    Furniture,
    Food
}

struct Item
{
    public string Name;
    public int Count;
    public double Price;
    public ItemCategory Category;


    public Item(string name, int count, double price, ItemCategory category)
    {
        Name = name;
        count = count;
        Price = price;
        Category = category;
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}, Count: {Count}, Price: {Price}, Category: {Category} ");
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

    public void UpdateItem(string name, int count, double price)
    {
        for (int i = 0; i < count; i++)
        {
            if (items[i].Name == name)
            {
                items[i].Count = count;
                items[i].Price = price;
                return;
            }
        }
    }
    public void 
}