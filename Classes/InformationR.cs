namespace GEOMETRY.Classes;

public class InformationR
{
    public void ShowMenu()
    {
        Console.WriteLine("\nHello, Welcome to my project which can calculate the circle of Area and also Perimeter too");
        Console.WriteLine("Do you want to know the circle of Tringle or primeter of Rectangle?");
        Console.WriteLine("1.Triangle\n2.Rectangle");
    }
    public void LastReport()
    {
        Console.Write("Do you want to continue [y/n]: "); 
    }
    public static void Report()
    {
        Console.WriteLine("---Thank you---\n");
    }

    public void DefaultReport()
    {
        Console.WriteLine("Sorry,You entered invalid input, try again later");
    }
}