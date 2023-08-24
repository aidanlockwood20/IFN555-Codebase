// Aidan Lockwood (n10515402 Exam Response
/*
 SPEED LIMIT APP:
    1.Initialise Double Speed Limit = 60 
    2. Initialise constant base fine rate $(80) double
    3. Initialise constant per km $(15) over double
    4. Initialise user input string and double parser
    5. Prompt User to input travelling speed
    6. Check if the speed limit is less than equal to Speed Limit
    7. If true, display "You are travelling right."
    8. If false, calculate and display the fine
    9. Prompt user to enter 5 speed values
    10. Initialise double calculation variable for the speeds
    11. Prompt user to input 5 different values
    12. Initialise double calculation variable for the speeds
    13. Catch the response and parse it to a double
    14. get the modulus of halfing the value (testing whether it is an even number)
    15. if the modulus is 0, it is an even number. Add it to the sumSpeeds variable for the end of the program
    16. display the sum of the speeds
 */

namespace Exam;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("#####################################################################################\n");
        Console.WriteLine("Task 1:");
        Console.WriteLine("#######\n");
        Console.WriteLine("This is Overspeed Fine Calculation Application. Written by Aidan Lockwood (n10515402)\n");
        Console.WriteLine("#####################################################################################");

        // Initialise Double Speed Limit = 60 
        // in km/h
        const double SPEED_LIMIT = 60;

        // Initialise double constant base fine rate $80
        // in $
        const double FINE_BASE_RATE = 80;

        // Initialise double constant per km $(15) over 
        // in $
        const double FINE_PER_KM = 15;

        // initialise user input variables (the initial input string and the parser variable
        string userInputSpeedLimit;
        double userSpeedLimit;

        Console.WriteLine("Task 2:");
        Console.WriteLine("######\n");
        Console.WriteLine("Please enter your travelling speed");

        // Prompt User to input travelling speed and parse the result to a double
        userInputSpeedLimit = Console.ReadLine();
        userSpeedLimit = double.Parse(userInputSpeedLimit);

        // Check if the speed limit is less than equal to Speed Limit
        if (userSpeedLimit <= SPEED_LIMIT)
        {
            Console.WriteLine("\nTask 3");
            Console.WriteLine("#########################");

            // If true, display "You are travelling right."
            Console.WriteLine("You are travelling right.");
        }
        else
        {
            // If false, calculate and display the fine
            double calculateOverspeedFine = FINE_BASE_RATE + (userSpeedLimit - SPEED_LIMIT) * FINE_PER_KM;

            Console.WriteLine("\nTask 3 & 4");
            Console.WriteLine("#########################");
            Console.WriteLine("You are travelling over the speed limit. You must pay a fine of {0}", calculateOverspeedFine.ToString("C"));
        }

        Console.WriteLine("\n\nTask 5");
        Console.WriteLine("##########\n\n");

        // Prompt user to enter 5 speed values 
        Console.WriteLine("Enter 5 travelling speeds");
        Console.WriteLine("Write Speed Value 1");

        // Initialise double calculation variable for the speeds
        double sumSpeeds = 0;

        // Prompt user to input 5 different values
        for (int x = 0; x < 5; ++x)
        {
            if (x > 0)
            {
                Console.WriteLine("\nWrite Speed Value {0}", x + 1);
            }

            // Catch the response and parse it to a double
            userInputSpeedLimit = Console.ReadLine();
            userSpeedLimit = double.Parse(userInputSpeedLimit);

            // get the modulus of halfing the value (testing whether it is an even number)
            double userInputSpeedLimitModulus = userSpeedLimit % 2;

            // if the modulus is 0, it is an even number. Add it to the sumSpeeds variable for the end of the program
            if (userInputSpeedLimitModulus == 0)
            {
                sumSpeeds += userSpeedLimit;
            }

        }

        // display the sum of the speeds
        Console.WriteLine("The sum of all even speeds is {0}", sumSpeeds);

        
    }
}

