using System;

class Rectangle
{
    private double x1, y1;
    private double x2, y2;

    
    public Rectangle()
    {
        x1 = 0;
        y1 = 0;
        x2 = 1;
        y2 = 1;
    }

    
    public Rectangle(double x1, double y1, double x2, double y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    
    public Rectangle(Rectangle rect)
    {
        x1 = rect.x1;
        y1 = rect.y1;
        x2 = rect.x2;
        y2 = rect.y2;
    }

    
    public double Area()
    {
        return (x2 - x1) * (y2 - y1);
    }

    
    public double Perimeter()
    {
        return 2 * ((x2 - x1) + (y2 - y1));
    }

    
    public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
    {
        return new Rectangle(rect1.x1 + rect2.x1, rect1.y1 + rect2.y1, rect1.x2 + rect2.x2, rect1.y2 + rect2.y2);
    }

    
    public static Rectangle operator *(Rectangle rect1, Rectangle rect2)
    {
        return new Rectangle(rect1.x1 * rect2.x1, rect1.y1 * rect2.y1, rect1.x2 * rect2.x2, rect1.y2 * rect2.y2);
    }

    
    public void Display()
    {
        Console.WriteLine($"Rectangle: [({x1}, {y1}), ({x2}, {y2})], Area: {Area()}, Perimeter: {Perimeter()}");
    }
}

class Program
{
    static void Main()
    {
        Rectangle Q1 = new Rectangle(2, 3, 5, 7);
        Rectangle Q2 = new Rectangle(1, 1, 4, 4);

        
        Rectangle Q3 = Q2 + Q1;
        Rectangle Q4 = Q3 * Q2;

        
        Q1.Display();
        Q2.Display();
        Q3.Display();
        Q4.Display();
    }
}