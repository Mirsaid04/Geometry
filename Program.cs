using GEOMETRY.Classes;
using Microsoft.VisualBasic;
using Information = Microsoft.VisualBasic.Information;

namespace GEOMETRY
{
    class Program
    {
        static void Main()
        {
            string yesOrno = ("");
            Calculator calculte = new Calculator();
            InformationR informationR = new InformationR();
            do
            {
                informationR.ShowMenu();
                int choosedNumber = int.Parse(Console.ReadLine()!);
                switch (choosedNumber)
                {
                    case 1:
                        calculte.TriangleCalcule();
                        break;

                    case 2:
                        calculte.RectangleCalculate();
                        break;

                    default:
                        informationR.DefaultReport();
                        break;
                } 
                informationR.LastReport();
                yesOrno = Console.ReadLine()!;
            } while (yesOrno == "y");
        }
    }
}