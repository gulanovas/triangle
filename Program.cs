/*
 * In this project I have created some basic triangle calculations
 * During this project I learned about what is interface and that you can use same interface in multiple files
 * Moreover, I have learned very basics about how C# inputs, strings, loops and if statmets works
 * Also, I have learned how to convert from one variable type to another
 * As well, I have learned how Math function works in C# and how to do simple unit testing
 * Last but not least, I have learned what "using System" does and how it helps to write less code
 */

/* using System
   Just want to show that I understand why we need import System 
   we do not need to write System in front of methods Console, Convert, Math and etc... if System interface is imported
 */
using NUnit.Framework;
using TriangleCalculation;
class Program
{
    static void Main(string[] args)
    {

        const double delta = 0.1;
        double coordinations;

        //x1
        System.Console.WriteLine("Enter coordinate x of dot A:");
        string x1 = System.Console.ReadLine();
        
        //Check if empty
        while (string.IsNullOrEmpty(x1))
        {
            System.Console.WriteLine("x1 can't be empty! Input double or integer once more");
            x1 = System.Console.ReadLine();
        }

        //check if number
        bool parse_x1 = double.TryParse(x1, out coordinations);

        if (parse_x1)
        {
            System.Console.WriteLine($"Coordinations is: {coordinations}");
        }
        else
        {
            System.Console.WriteLine("This is not a number!");
            x1 = System.Console.ReadLine();
        }

        //y1
        System.Console.WriteLine("Enter coordinate y of dot A:");
        string y1 = System.Console.ReadLine();

        //Check if empty
        while (string.IsNullOrEmpty(y1))
        {
            System.Console.WriteLine("y1 can't be empty! Input double or integer once more");
            y1 = System.Console.ReadLine();
        }

        //Check if number
        bool parse_y1 = double.TryParse(y1, out coordinations);

        if (parse_y1)
        {
            System.Console.WriteLine($"Coordinations is: {coordinations}");
        }
        else
        {
            System.Console.WriteLine("This is not a number!");
            y1 = System.Console.ReadLine();
        }

        //x2
        System.Console.WriteLine("Enter coordinate x of dot B:");
        string x2 = System.Console.ReadLine();

        //Check if empty
        while (string.IsNullOrEmpty(x2))
        {
            System.Console.WriteLine("x2 can't be empty! Input double or integer once more");
            x2 = System.Console.ReadLine();
        }

        //Check if number
        bool parse_x2 = double.TryParse(x2, out coordinations);

        if (parse_x2)
        {
            System.Console.WriteLine($"Coordinations is: {coordinations}");
        }
        else
        {
            System.Console.WriteLine("This is not a number!");
            x2 = System.Console.ReadLine();

        }

        //y2
        System.Console.WriteLine("Enter coordinate y of dot B:");
        string y2 = System.Console.ReadLine();

        //Check if empty
        while (string.IsNullOrEmpty(y2))
        {
            System.Console.WriteLine("y2 can't be empty! Input double or integer once more");
            y2 = System.Console.ReadLine();
        }

        //Check if number
        bool parse_y2 = double.TryParse(y2, out coordinations);

        if (parse_y2)
        {
            System.Console.WriteLine($"Coordinations is: {coordinations}");

        }
        else
        {
            System.Console.WriteLine("This is not a number!");

        }

        //x3
        System.Console.WriteLine("Enter coordinate x of dot C:");
        string x3 = System.Console.ReadLine();

        //Check if empty
        while (string.IsNullOrEmpty(x3))
        {
            System.Console.WriteLine("x3 can't be empty! Input double or integer once more");
            x3 = System.Console.ReadLine();
        }

        //Check if number
        bool parse_x3 = double.TryParse(x3, out coordinations);

        if (parse_x3)
        {
            System.Console.WriteLine($"Coordinations is: {coordinations}");

        }
        else
        {
            System.Console.WriteLine("This is not a number!");

        }

        //y3
        System.Console.WriteLine("Enter coordinate y of dot C:");
        string y3 = System.Console.ReadLine();

        //Check if empty
        while (string.IsNullOrEmpty(y3))
        {
            System.Console.WriteLine("y3 can't be empty! Input double or integer once more");
            y3 = System.Console.ReadLine();
        }

        //Check if number
        bool parse_y3 = double.TryParse(y3, out coordinations);

        if (parse_y3)
        {
            System.Console.WriteLine($"Coordinations is: {coordinations}");

        }
        else
        {
            System.Console.WriteLine("This is not a number!");

        }


        Triangle A = new Triangle((System.Convert.ToDouble(x1), System.Convert.ToDouble(y1)));
        Triangle B = new Triangle((System.Convert.ToDouble(x2), System.Convert.ToDouble(y2)));
        Triangle C = new Triangle((System.Convert.ToDouble(x3), System.Convert.ToDouble(y3)));

        var distance_A_B = System.Math.Sqrt((System.Math.Pow(A.x - B.x, 2)) + (System.Math.Pow(A.y - B.y, 2)));

        var distance_B_C = System.Math.Sqrt((System.Math.Pow(B.x - C.x, 2)) + (System.Math.Pow(B.y - C.y, 2)));

        var distance_A_C = System.Math.Sqrt((System.Math.Pow(A.x - C.x, 2)) + (System.Math.Pow(A.y - C.y, 2)));

        var perimeter = distance_A_B + distance_B_C + distance_A_C;

        System.Console.WriteLine("");

        System.Console.WriteLine($"Length of AB is: {distance_A_B}");
        System.Console.WriteLine($"Length of BC is: {distance_B_C}");
        System.Console.WriteLine($"Length of AC is: {distance_A_C}");

        System.Console.WriteLine("");

        if (distance_A_B == distance_B_C && distance_B_C == distance_A_C)
        {
            System.Console.WriteLine("Equilateral");
        }
        else
        {
            System.Console.WriteLine("NOT Equilateral");

        }
        if (distance_A_B == distance_B_C || distance_B_C == distance_A_C || distance_A_B == distance_A_C)
        {
            System.Console.WriteLine("Isosceles");

        }
        else
        {
            System.Console.WriteLine("NOT Isosceles");

        }
        if (System.Math.Pow(distance_A_B, 2) + System.Math.Pow(distance_B_C, 2) == System.Math.Pow(distance_A_C, 2)
            ||
            System.Math.Pow(distance_B_C, 2) - (System.Math.Pow(distance_A_C, 2) + System.Math.Pow(distance_A_B, 2)) <= delta
            ||
            System.Math.Pow(distance_A_C, 2) + System.Math.Pow(distance_A_B, 2) == (System.Math.Pow(distance_B_C, 2)))
        {
            System.Console.WriteLine("Right");

        }
        else
        {
            System.Console.WriteLine("NOT Right");

        }

        System.Console.WriteLine("");

        System.Console.WriteLine($"Perimeter: {perimeter}");

        System.Console.WriteLine("");

        System.Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");

        for (int num = 0; num <= System.Math.Floor(perimeter); num++)
        {
            if (num % 2 == 0)
            {
                System.Console.WriteLine(num);
            }
        }

        Assert.AreEqual(System.Math.Pow(distance_A_C, 2) + System.Math.Pow(distance_A_B, 2), System.Math.Pow(distance_B_C, 2)); //gives: Expected: 32.0d But was: 32.000000000000007d

    }


 
};


//!!! I HAVE DONE SOME BASIC USER INPUT VALIDATIONS, HOWEVER WHEN USING STRING OR CHART FIRST AND AFTER TRYING TO LEAVE FIELD EMPTY
//!!! IT GIVES EMPTY COORDINATIONS VALUE AND EVEN IF PROGRAM IS NOT CRASHING CALCULATIONS WILL NOT EXECUTE

//!!! I WOULD LIKE TO GET SOME ADDITIONAL MATERIALS HOW TO PROPERLY HANDLE ERRORS WITH C# AS GOOGLE GAVE EXAMPLES BUT FOR ME MOST
//!!! ARE NOT WORKING