internal class Program
{
    private static void Main(string[] args)
    {
        var p1 = new Product("Laptop", 1000.0, 5);
        var p2 = new Product("PC", 200.0, 2);

        p1.Total(10, 5);

        Console.WriteLine(p1);
        Console.WriteLine(p2);

        Point p;

        p.y = 10;
        p.x = 5;

        Console.WriteLine(p);
        p = new Point();
        Console.WriteLine(p);
    }
}