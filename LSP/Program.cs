using System;

// Base class
class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

// Derived class
class Square : Rectangle
{
    public override int Width
    {
        get { return base.Width; }
        set { base.Width = base.Height = value; } // Violation of LSP
    }

    public override int Height
    {
        get { return base.Height; }
        set { base.Width = base.Height = value; } // Violation of LSP
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Square();
        rectangle.Width = 5;
        rectangle.Height = 4;

        Console.WriteLine($"Area: {rectangle.GetArea()}"); // Expected: 20, Actual: 25 (Violates LSP)
    }
}