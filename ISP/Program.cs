// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

interface IBadWorker
{
    void Work();
    void TakeBreak();
    void ClockIn();
    void ClockOut();
}


interface IGoodWorker
{
    void Work();
}

interface IBreakable
{
    void TakeBreak();
}

interface ITimeTrackable
{
    void ClockIn();
    void ClockOut();
}
