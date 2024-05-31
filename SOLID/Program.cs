// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
interface IShape
{
    double Area();
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }
}

class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}