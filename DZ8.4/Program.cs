using System;

interface IPriceable
{
    void SetPrice(double price);
}

interface IDiscountable
{
    void ApplyDiscount(string discount);
}

interface IPromotional
{
    void ApplyPromocode(string promocode);
}

class Book : IPriceable, IDiscountable
{
    private double price;

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyDiscount(string discount)
    {
        // Реалізація знижок для книги
        Console.WriteLine($"Знижка {discount} застосована до книги.");
    }

}

class Outerwear : IPriceable, IDiscountable, IPromotional
{
    private double price;
    private string color;
    private byte size;

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Знижка {discount} застосована до верхнього одягу.");
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine($"Промокод {promocode} застосовано до верхнього одягу.");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book();
        myBook.SetPrice(20);
        myBook.ApplyDiscount("10%");

        Outerwear jacket = new Outerwear();
        jacket.SetPrice(100);
        jacket.ApplyDiscount("20%");
        jacket.ApplyPromocode("MEGASALE");
    }
}
