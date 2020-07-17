using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace progex01
{
    class Program
    {   //Author:Jorge Sanchez
        static void Main(string[] args)
    {   try
        {
            //Part 1 Area and Circumference of a Circle
            double goodNum, circum, area;
            Console.WriteLine("\nPart 1, \nCircumference and Area of a Circle.");
            Console.WriteLine("\nEnter an integer for the radius: ");
            goodNum = Double.Parse(Console.ReadLine());
            circum = (double)(2 * Math.PI * goodNum);
            area = (double)Math.PI * Math.Pow(goodNum, 2);
            Console.WriteLine($"\nThe circumference is {circum}");
            Console.WriteLine($"\nThe area is {area}");
            //part 2 Hemisphere              
            double topHalf, volume, radius;
            Console.WriteLine("\nPart 2, \nVolume of a Hemisphere.");
            Console.WriteLine("\nEnter an integer for the radius: ");
            radius = Double.Parse(Console.ReadLine());
            ////The following statement multiplies 2, Pi, and the radius cubed.
            topHalf = (2 * Math.PI * Math.Pow(radius, 3));
            volume = topHalf / 3;
            Console.WriteLine($"\nThe volume is {(double)volume} meters cubed");
            //Part 3 Area of a triangle given the length of the sides
            double firstSide, secondSide, thirdSide, half, insideSqrRoot;
            Console.WriteLine("\nPart 3, \nArea of a Triangle (Heron's formula).");
            Console.WriteLine("\nProvide the length of the first side.");
            firstSide = double.Parse(Console.ReadLine());
            Console.WriteLine("\nProvide the length of the second side.");
            secondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("\nProvide the length of the third side.");
            thirdSide = double.Parse(Console.ReadLine());
            half = (firstSide + secondSide + thirdSide) / 2;
            insideSqrRoot = half * ((half - firstSide) * (half - secondSide) * (half - thirdSide));
            Console.WriteLine($"\nThe area is {Math.Sqrt(insideSqrRoot)}");
            // Part 4 Solving a Quadratic Equation
            double quad1, quad2, quad3, denominator;
            double positiveNum, negativeNum;
            Console.WriteLine("\nPart 4, \nSolving a Quadratic equation.");
            Console.WriteLine("\nProvide a coefficient for the variable a.");
            quad1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nProvide a coefficient for the variable b.");
            quad2 = double.Parse(Console.ReadLine());
            //Making b a negative
            quad2 = quad2 * -1;
            Console.WriteLine("\nProvide a coefficient for the variable c.");
            quad3 = double.Parse(Console.ReadLine());
            denominator = 2 * quad1;
            positiveNum = quad2 + Math.Sqrt((Math.Pow(quad2, 2) - 4 * quad1 * quad3));
            negativeNum = quad2 - Math.Sqrt((Math.Pow(quad2, 2) - 4 * quad1 * quad3));
            Console.WriteLine($"\nThe positive solution is {(double)positiveNum / denominator}");
            Console.WriteLine($"\nThe negative solution is {(double)negativeNum / denominator}");
            }
        catch (FormatException fEx)
            {
            Console.WriteLine("Invalid input. Enter a number. {0}", fEx.Message);
            }
        catch (DivideByZeroException dBZ)
            {
            Console.WriteLine("Attempted divide by zero. {0}", dBZ.Message);
            }
        finally
            {
            Console.WriteLine("The program is complete.");
            }
        }
    }   
}  


