/*
 1. Prompt user to enter 5 integers
 2. Initialise loop counter variable
 3. Initialise limit variable
 4. Initialise summing variable
 5. Initialise user input string variable and the parsing int variable
 6. Create for-loop
 7. Prompt user to enter the first digit
 8. Parse the string to integer
 9. Add to summing variable
 10. Add to loop counter by 1
 11. Once out of for loop, display the sum

 */

namespace SumFiveInts;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter 5 digits: ");

        int x;
        const int LOOP_LIMIT = 5;
        int totalSum = 0;
        string userInput;
        int userIntInput;

        for (x = 1; x <= LOOP_LIMIT; ++x)
        {
            Console.WriteLine("Please enter digit number {0}:", x);

            userInput = Console.ReadLine();
            userIntInput = int.Parse(userInput);

            totalSum += userIntInput;
        }
        Console.WriteLine("The sum of the five numbers was {0}", totalSum);
    }
}

