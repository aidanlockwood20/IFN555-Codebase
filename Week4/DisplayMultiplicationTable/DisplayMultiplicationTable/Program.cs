/*
 1. Initialise the user Input string variable
 2. Initialise the user Input integer variable
 3. Initialise the count variable for the for loop
 4. Initialise the product variable that will display the multiplied result + the string representation
 5. Prompt user to input a value that will display the multiplication table for that number up to 10
 6. Enter for-loop
 7. Prompt user to input an integer
 8. Parse user input to integer
 9. Multiply the value by the counter variable
 9. Display the equation with the product
 */

namespace DisplayMultiplicationTable;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        int userIntInput;
        int loopCounter;
        const int LOOP_COUNTER_LIMIT = 10;
        int productResult;
        string productResultString;

        Console.WriteLine("This program will display the multiplication table up to 10 for the given number");
        Console.WriteLine("Enter an integer.");

        userInput = Console.ReadLine();
        userIntInput = int.Parse(userInput);

        for (loopCounter = 1; loopCounter <= LOOP_COUNTER_LIMIT; ++loopCounter)
        {

            productResult = userIntInput * loopCounter;
            productResultString = productResult.ToString();


            Console.WriteLine("{0} x {1} = {2}", loopCounter, userInput, productResultString);
        }
    }
}

