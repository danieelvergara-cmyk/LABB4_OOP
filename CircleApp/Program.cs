class Program
{
    static void Main()
    {
        Circle circle5 = new Circle(5);
        Circle circle6 = new Circle(6);

        Console.WriteLine($"Arean av cirkeln med radie 5 är {circle5.GetArea():F2}");
        Console.WriteLine($"Arean av cirkeln med radie 6 är {circle6.GetArea():F2}");
    }
}
