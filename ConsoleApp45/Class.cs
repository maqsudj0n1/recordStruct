class Laptop1
{
    public int Ram { get; init; }
    public int Memory { get; init; }
    public string Cpu { get; init; }
    public string Model { get; init; }
    public Color Color { get; init; }

    public Laptop1(int ram, int memory, string cpu, string model, Color color)
    {
        Ram = ram;
        Memory = memory;
        Cpu = cpu;
        Model = model;
        Color = color;
       
    }
    public void On()
    {
        Console.WriteLine("Welcome");
    }

    public void Off()
    {
        Console.WriteLine("Shut down");
    }
    public void Restart()
    {
        Console.WriteLine("Restarting");
    }



}
