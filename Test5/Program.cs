internal class Program
{
    private static void Main(string[] args)
    {
        Printer printer = new Printer();
        printer.Print("Test base printer");

        ColorPrinter colorPrinter = new ColorPrinter();
        colorPrinter.Print("Test color printer");
    }
}
class Printer
{
    protected virtual ConsoleColor TextColor { get; set; } = ConsoleColor.White;
    public void Print(string value)
    {
        Console.ForegroundColor = TextColor;
        Console.WriteLine(value);
    }
}

class ColorPrinter : Printer
{
    protected override ConsoleColor TextColor { get { return ConsoleColor.Green; } }
}