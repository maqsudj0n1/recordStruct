class Program
{
    static void Main(string[] args)
    {
        Laptop laptop = new Laptop(8, 500, "Core i5", "Acer", Color.silver);
        Console.WriteLine(laptop);
        laptop.On();
        Laptop1 laptop1 = new Laptop1(16, 1000, "Core i7", "Hp", Color.gold);
        laptop1.Off();
        Laptop2 laptop2 = new Laptop2(4, 250, "Ryzen 5", "Dell", Color.black);
        laptop2.Restart();

    }
}