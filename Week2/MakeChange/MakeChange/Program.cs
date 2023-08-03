/*
 * Steps to code:
 * 1. Declare a twenties, tens, fives and ones variables 
 * 2. Accept user input for a number to be converted (into the above divisions)
 * 3. Calculate number of twenties needed
 * 4. Calculate number of tens needed
 * 5. Calculate number of fives needed
 * 6. Calculate number of ones needed by summing the values and subtracting it from the initial value
 * 7. Display the total number of each value 
 */


namespace MakeChange;

class CalculateChange
{
    public static void Main(string[] args)
    {
        // Declare a twenties, tens, fives and ones variables 
        int numOfTwenties;
        int numOfTens;
        int numOfFives;
        int numOfOnes;

        // Accept user input for a number to be converted
        Console.WriteLine("What is the total value (in $) you would like to convert to change?");
        string totalValueUserInput = Console.ReadLine();
        int totalValue = int.Parse(totalValueUserInput);

        // Calculate number of twenties needed
        int calculateNumOfTwenties = totalValue / 20;
        totalValue -= (calculateNumOfTwenties * 20);

        // Calculate number of tens needed
        int calculateNumOfTens = totalValue / 10;
        totalValue -= (calculateNumOfTens * 10);


        // Calculate number of fives needed
        int calculateNumOfFives = totalValue / 5;
        totalValue -= (calculateNumOfFives * 5);

        // Calculate number of ones needed by summing the values and subtracting it from the initial value
        int calculateNumOfOnes = totalValue;

        // Display the total number of each value
        Console.WriteLine("The initial value input was ${0}", totalValue);
        Console.WriteLine("The change for this is {0} twenties, {1} tens, {2} fives and {3} ones", calculateNumOfTwenties, calculateNumOfTens, calculateNumOfFives, calculateNumOfOnes);
    }
}