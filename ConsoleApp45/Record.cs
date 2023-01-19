record Laptop
{
    public readonly int Ram;
    public readonly int Memory;
    public readonly string Cpu;
    public readonly string Model;
    public readonly Color Color;

    public Laptop(int ram, int memory, string cpu, string model, Color color)
    {
        Ram= ram;   
        Memory= memory;
        Cpu= cpu;
        Model= model;
        Color= color;
        
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
