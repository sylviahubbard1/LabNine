using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LabNineCircle
{
    class CircleApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Circle Tester");
            string repeat = "";
            do {
                string inputdata = "";
                double radiousOfCircle=0;
                bool check = false;
                do
                {
                    Console.Write("Enter Radious: ");
                    inputdata = Console.ReadLine();
                    check = Validator.radiousIsValid(inputdata, out radiousOfCircle);
                    if (check == false)
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                    //Console.WriteLine("x is: " + radiousOfCircle + "  input string is" + inputdata +"" + check);
                } while (!check);


                Circle circleRadiousCircumference = new Circle(radiousOfCircle);
                Console.Write($"Circumference: { circleRadiousCircumference.getFormattedCircumference()}");
                Console.WriteLine();
                Console.WriteLine($"Area: {circleRadiousCircumference.getArea()}");

                Circle.getObjectCount();
                Console.WriteLine("Do you want to continue? (y/n)");
                repeat = Console.ReadLine().Trim().ToLower();
            } while (repeat == "y");

            Console.WriteLine($"Goodbye. You created { Circle.getObjectCount()} Circle object(s)");
            Console.ReadLine();
        }

    }
}
