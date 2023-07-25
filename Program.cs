namespace GEOMETRY 
{ 
    class Program 
    { 
        static void Main() 
        { 
                Console.WriteLine("\nHello, Welcome to my project which can calculate the circle of Area and also Perimeter too");
                Console.WriteLine("Do you want to know the circle of Tringle or primeter of Rectangle?");
                Console.WriteLine("1.Triangle\n2.Rectangle");

            int choosedNumber=int.Parse(Console.ReadLine()!);

            if(choosedNumber==1)
            {
                Console.Write("Please, enter the radius:");
                double radius=Convert.ToDouble(Console.ReadLine()); 

                Console.WriteLine("\nIt is calculating now ...\n"); 
                double Result=Math.PI*radius*radius; 
 
                Console.WriteLine($"The circle of Triangle is {Result}\n"); 
                Console.WriteLine("/\\ <---Thank you---> /\\\n");
            }
            else if(choosedNumber==2)
            {
                Console.Write("Please enter the breadth: ");
                decimal breadth=Convert.ToDecimal(Console.ReadLine()!);

                Console.Write("Please enter the lenght: ");
                decimal lenght=Convert.ToDecimal(Console.ReadLine());

                decimal result=(breadth+lenght)*2;
                Console.WriteLine("\nIt is calculating now ...\n");

                Console.WriteLine($"The perimeter of Rectangle is {result}cm\n");
                Console.WriteLine("/\\ <---Thank you---> /\\\n");
            }
            else 
            {
                System.Console.WriteLine("Sorry,You entered invalid input, try again later");
                Console.WriteLine("\n/\\ <---Thank you---> /\\\n");
            }
        } 
    } 
}