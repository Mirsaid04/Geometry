namespace GEOMETRY 
{ 
    class Program 
    { 
        static void Main() 
        { 
            Console.WriteLine("\nHello, Welcome to my project which can calculate the circle of Area and also Perimeter too");
            Console.WriteLine("Do you want to know the circle of Tringle or primeter of Rectangle?");
            System.Console.WriteLine("1.Triangle\n2.Rectangle");

            int choosedNumber=int.Parse(Console.ReadLine()!);

            if(choosedNumber==1)
            {
            Console.Write("Please, enter the radius:");
            double radius=Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("\nIt is calculating now ...\n"); 
            double Result=Math.PI*radius*radius; 
 
            Console.WriteLine($"The circle of Triangle is {Result}\n"); 
            System.Console.WriteLine("/\\ <---Thank you---> /\\\n");
            }
            else if(choosedNumber==2)
            {
                System.Console.Write("Please enter the breadth: ");
                decimal breadth=Convert.ToDecimal(Console.ReadLine()!);

                System.Console.Write("Please enter the lenght: ");
                decimal lenght=Convert.ToDecimal(Console.ReadLine());

                decimal result=(breadth+lenght)*2;

                System.Console.WriteLine("\nIt is calculating now ...\n");

                System.Console.WriteLine($"The perimeter of Rectangle is {result}\n");
                System.Console.WriteLine("/\\ <---Thank you---> /\\\n");

            }





 
        } 
    } 
}