/*
 1. Prompt the user to enter a series of daily high temperatures between -20 and 130 Fahrenheit and that ! will exit the program
 2. Initialise the low temp range variable
 3. Initialise the high temp range variable
 4. Initialise the user Input string variable
 5. Initialise the user Input integer variable
 6. Initialise counter variable for dividing and averaging
 7. Enter while loop, checking for the ! to exit the program
 8. Retrieve user input
 9. Parse the user input string to integer
 10. Check that it is within the ranges specified
 11. If the value is invalid, display an error message
 12. If the value is valid, add to the total
 13. Add to the counter variable 
 14. Once the ! is pressed, divide the total by the counter variable and display the result

 */

namespace DailyTemps;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a series of daily high temperature values between -20 and 130 Fahrenheit.");
        Console.WriteLine("Typing a ! will exit the program and return the average temperature");

        const int LOW_TEMP = -20;
        const int HIGH_TEMP = 130;
        string userInput = "";
        int userIntInput;
        int loopCounter = 0;
        int totalValue = 0;
        int sumValue = 0;

        while (userInput != "!")
        {
            Console.WriteLine("Enter a value");

            userInput = Console.ReadLine();

            if (userInput != "!")
            {
                userIntInput = int.Parse(userInput);

                if ((userIntInput < HIGH_TEMP && userIntInput > LOW_TEMP) && userInput != "!")
                {
                    sumValue += userIntInput;
                    ++loopCounter;
                }
                else
                {
                    Console.WriteLine("Error: Invalid Temperature Provided");
                }

            }    
        }

        totalValue = sumValue / loopCounter;

        Console.WriteLine("The daily average high temperature is {0}", totalValue);

    }
}

