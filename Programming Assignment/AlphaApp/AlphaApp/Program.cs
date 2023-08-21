/*

1. Display Personal Information, including:
    - Last Name
    - First Name
    - Student ID

    These details need to be surrounded by asterisks border

    a) Initialise the firstName, lastName and studentID variables
    b) Print a line of asterisks
    c) Print to Console lastName, firstName and studentID
    d) Print a line of asterisks

2. Prompt the user to enter the number of orders from interior and
   exterior murals
    - Note: The number needs to be between 0 and 30 (inclusive)
      otherwise, get the user to reenter a number

    a) initialise minOrder and maxOrder integer variables
    b) Prompt user to enter the number of orders for interior murals between 0 and 30
    c) Prompt user to enter the number of orders for exterior murals between 0 and 30
    d) check if the value is valid, if not prompt to reenter

3. Display the number of orders of both interior and exterior murals and
   calculate expected revenue (Interior = $500.00, Exterior = $750.00

    a) initialise expectedRevenue float variable, interiorMuralValue and exteriorMuralValue (all floats)
    b) calculate the revenue for each type of mural
    c) print the revenue values to the console
    

4. Display which mural is more popular (i.e. "Interior murals are becoming more attractive!")
    - If equal, "Both types are equally preferred!"

    a) Create if statement comparing the number of orders for the murals
    b) If the interior is greater than the exterior, print:
        “Interior murals are becoming popular!”
    c) If the exterior is greater than the interior, print:
        “Exterior murals are becoming more attractive!”
    d) If they are equal, print:
        “Both types are equally preferred!”

5. Prompt user to input information for interior mural orders with
    - Customer Name and Mural Code
        - L for Landscape
        - S for Seascape
        - A for Abstract
        - O for Others
    - if the code is not correct, prompt user to reenter the code
    - Display a count for the number of customers ordering each type of interior mural
    - Continuously prompt user for mural code until a stop value is entered

    a) Prompt the user to input:
        - "L" for a landscape mural
        - "S" for a seascape mural
        - "A" for an abstract mural
        - "O" for Others
    b) check if code is valid, otherwise prompt to user to input the correct value
    c) keep user in while loop, telling them to write "!" to exit the code
    d) print a count of the number of customers ordering each type of mural
 
 */

using System.Collections.Generic;
using System.Xml.Linq;

namespace AlphaApp;

class Program
{
    static void Main(string[] args)
    {
        // Initialise the firstName, lastName and studentID variables
        string lastName = "Lockwood";
        string firstName = "Aidan";
        string studentID = "n10515402";

        // Display Personal Information, including:
        // - Last Name
        // - First Name
        // - Student ID

        Console.WriteLine("****************************");
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Student ID: {0}", studentID);
        Console.WriteLine("****************************");

        // initialise minOrder and maxOrder float variables
        const float MIN_ORDER = 0;
        const float MAX_ORDER = 30;

        // Prompt user to enter the number of orders for interior murals between 0 and 30
        Console.WriteLine("Enter the number of interior murals you would like to purchase (between 0 and 30)");
        string numInteriorMuralsString = Console.ReadLine();
        float numInteriorMurals = float.Parse(numInteriorMuralsString);

        while (!(numInteriorMurals < MAX_ORDER && numInteriorMurals > MIN_ORDER))
        {
            Console.WriteLine("Please Reenter a valid number of murals");
            Console.WriteLine("Enter the number of interior murals you would like to purchase (between 0 and 30)");
            numInteriorMuralsString = Console.ReadLine();
            numInteriorMurals = float.Parse(numInteriorMuralsString);
        }

        // Prompt user to enter the number of orders for exterior murals between 0 and 30
        Console.WriteLine("Enter the number of exterior murals you would like to purchase (between 0 and 30)");
        string numExteriorMuralsString = Console.ReadLine();
        float numExteriorMurals = float.Parse(numExteriorMuralsString);

        while (!(numExteriorMurals < MAX_ORDER && numExteriorMurals > MIN_ORDER))
        {
            Console.WriteLine("Please Reenter a valid number of murals");
            Console.WriteLine("Enter the number of exterior murals you would like to purchase (between 0 and 30)");
            numExteriorMuralsString = Console.ReadLine();
            numExteriorMurals = float.Parse(numExteriorMuralsString);
        }

        // initialise expectedRevenue float variable, interiorMuralValue and exteriorMuralValue (all floats)
        const double interiorMuralValue = 500.00;
        const double exteriorMuralValue = 750.00;
        double expectedInteriorMuralRevenue;
        double expectedExteriorMuralRevenue;
        double expectedTotalRevenue;

        // calculate the revenue for each type of mural
        expectedInteriorMuralRevenue = numInteriorMurals * interiorMuralValue;
        expectedExteriorMuralRevenue = numInteriorMurals * exteriorMuralValue;
        expectedTotalRevenue = expectedInteriorMuralRevenue + expectedExteriorMuralRevenue;

        // display the number of mural orders for each type
        Console.WriteLine("Number of Interior Mural Orders: {0}", numInteriorMurals);
        Console.WriteLine("Number of Exterior Mural Orders: {0}", numExteriorMurals);

        // print the revenue values to the console
        Console.WriteLine("Expected Revenue from Interior Murals: ${0}", expectedInteriorMuralRevenue);
        Console.WriteLine("Expected Revenue from Exterior Murals: ${0}", expectedExteriorMuralRevenue);
        Console.WriteLine("Expected Total Revenue from all Murals: ${0}", expectedTotalRevenue);

       if (numInteriorMurals > numExteriorMurals)
       {
            Console.WriteLine("Interior murals are becoming popular!");
       }
       if (numExteriorMurals > numInteriorMurals)
       {
            Console.WriteLine("Exterior murals are becoming more attractive!");
       }
       if (numInteriorMurals == numExteriorMurals)
       {
            Console.WriteLine("Both types are equally preferred!");
       }

        string[] muralTypes = new string[4] { "L for Landscape", "S for Seascape", "A for Abstract", "O for Others" };

        int landscapeMuralCount = 0;
        int seascapeMuralCount = 0;
        int abstractMuralCount = 0;
        int otherMuralCount = 0;

        for (int x = 1; x <= numInteriorMurals; ++x)
        {
            // Prompt user to input information for interior mural orders with
            // customer name 
            Console.Write("Enter Customer Name {0}: ", x);
            string customerName = Console.ReadLine();

            // interior mural type
            Console.WriteLine("Mural Options Include");
            for (int y = 0; y < muralTypes.Length; ++y)
            {
                Console.WriteLine("\t{0}", muralTypes[y]);
            }

            bool invalidCode = true;

            while (invalidCode)
            {
                Console.Write("Enter the mural code {0} (L, S, A, O):", x);
                string muralCode = Console.ReadLine();

            
                // check if code is valid, otherwise prompt to user to input the correct value
                switch (muralCode)
                {
                    case "L":
                        ++landscapeMuralCount;
                        invalidCode = false;
                        break;
                    case "S":
                        ++seascapeMuralCount;
                        invalidCode = false;
                        break;
                    case "A":
                        ++abstractMuralCount;
                        invalidCode = false;
                        break;
                    case "O":
                        ++otherMuralCount;
                        invalidCode = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Code. Please Reenter a Valid Code");
                        break;
                }
            }
        }

        // print a count of the number of customers ordering each type of mural
        Console.WriteLine("\n\nNumber of Customers Ordering Landscape Murals: {0}", landscapeMuralCount);
        Console.WriteLine("Number of Customers Ordering Seascape Murals: {0}", seascapeMuralCount);
        Console.WriteLine("Number of Customers Ordering Abstract Murals: {0}", abstractMuralCount);
        Console.WriteLine("Number of Customers Ordering Others Murals: {0}", otherMuralCount);

    }
}

