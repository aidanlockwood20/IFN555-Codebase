/*
 1. Initialise the user Input String Variable and the Int variable (that will get parsed)
 2. Initialise the summing variable
 3. Prompt the user to enter as many numbers as they want, and that 999 will abort the program and return the summed variable
 4. Create while loop, with userInput != "999"
 5. Prompt user to enter a number
 6. Parse the string to integer
 7. Add to summed variable
 8. When the userInput is 999, exit while loop and display the final result
 */

namespace SumInts;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        int userIntInput;
        int totalSum = 0;

        Console.WriteLine("Enter the as many numbers as you want. Entering 999 will exit the code and add the numbers input");

        while (userInput != "999")
        {
            userInput = Console.ReadLine();
            userIntInput = int.Parse(userInput);

            if (userIntInput != 999)
            {
                totalSum += userIntInput;
            }    

            Console.WriteLine("Enter another number");
        }

        Console.WriteLine("The final value is {0}", totalSum);
    }
}

