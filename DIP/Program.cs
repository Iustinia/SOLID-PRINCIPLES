// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
interface IEngine
{
    void Start();
}

class GasolineEngine : IEngine
{
    public void Start()
    {
       
    }
}

class ElectricEngine : IEngine
{
    public void Start()
    {
       
    }
}

class Car
{
    private readonly IEngine _engine;
    //private readonly ElectricEngine badEngine = new ElectricEngine();

    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
    }
}