namespace GEOMETRY.Classes;

public class Calculator
{
    public void TriangleCalcule()
    {
        Console.Write("Please, enter the radius:");
        double radius=Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("\nIt is calculating now ...\n"); 
        double Result=Math.PI*radius*radius; 
 
        Console.WriteLine($"The circle of Triangle is {Result}\n"); 
        InformationR.Report();
    }

    public void RectangleCalculate()
    {
        Console.Write("Please enter the height: ");
        decimal height=Convert.ToDecimal(Console.ReadLine()!);

        Console.Write("Please enter the lenght: ");
        decimal lenght=Convert.ToDecimal(Console.ReadLine());

        decimal result=(height+lenght)*2;
        Console.WriteLine("\nIt is calculating now ...\n");

        Console.WriteLine($"The perimeter of Rectangle is {result}cm\n");
        InformationR.Report();
    }
}