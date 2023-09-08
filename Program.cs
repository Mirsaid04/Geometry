﻿using Microsoft.VisualBasic;

namespace GEOMETRY 
{ 
    class Program 
    { 
        static void Main() 
        { 
            try
            {
                string yesOrno=(""); 
            do{
                ShowMenu();
             int choosedNumber=int.Parse(Console.ReadLine()!);
            switch(choosedNumber)
            {
                case 1 : 
                    Console.Write("Please, enter the radius:");
                    double radius=Convert.ToDouble(Console.ReadLine()); 

                    Console.WriteLine("\nIt is calculating now ...\n"); 
                    double Result=Math.PI*radius*radius; 
 
                    Console.WriteLine($"The circle of Triangle is {Result}\n"); 
                    Report();
                    break;
            
                    case 2:
                    Console.Write("Please enter the height: ");
                    decimal height=Convert.ToDecimal(Console.ReadLine()!);

                    Console.Write("Please enter the lenght: ");
                    decimal lenght=Convert.ToDecimal(Console.ReadLine());

                    decimal result=(height+lenght)*2;
                    Console.WriteLine("\nIt is calculating now ...\n");

                    Console.WriteLine($"The perimeter of Rectangle is {result}cm\n");
                    Report();
                    break;

                default :
                    Console.WriteLine("Sorry,You entered invalid input, try again later");
                    Report();
                    break;
            }

            LastReport();
            yesOrno=Console.ReadLine()!; 
            }while(yesOrno=="y");
            }
            catch(FormatException FormatException)
            {
                Console.WriteLine("Opps,We could not convert your input value.");
                Console.WriteLine("Look like the value you provided is not integer.");
            }
            catch(OverflowException OverflowException)
            {
                Console.WriteLine("Value you provided was either too large or too small. ");
            }
            catch(Exception exception)
            {
                Console.WriteLine("Opps,something went wrong , contact support");
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("\nHello, Welcome to my project which can calculate the circle of Area and also Perimeter too");
            Console.WriteLine("Do you want to know the circle of Tringle or primeter of Rectangle?");
            Console.WriteLine("1.Triangle\n2.Rectangle");
        }

        public static void LastReport()
        {
            Console.Write("Do you want to continue [y/n]: "); 
        }

        public static void Report()
        {
            Console.WriteLine("---Thank you---\n");
        }
        
        
    } 
}