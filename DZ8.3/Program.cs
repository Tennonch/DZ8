using System;

class Square
{
    public int Side { get; set; }

    public int GetSquareArea()
    {
        return Side * Side;
    }
}

class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;
        Console.WriteLine(rect.GetRectangleArea()); 
        Console.ReadKey();
    }
}

//Тепер у нас два окремих класи: Square та Rectangle.
//Кожен з них має свої власні методи для обчислення площі,
//відповідно до їх властивостей.
//Таким чином, проблема з спадкуванням була виправлена.