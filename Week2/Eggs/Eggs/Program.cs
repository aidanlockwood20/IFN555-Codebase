/*
 * Steps in code: 
 * 1. Declare four constant variables to represent four chickens
 * 2. Declare a variable from summing the numbers together 
 * 3. Declare a variable for the total in dozens 
 * 4. Declare a variable for any remainders from the calculation
 * 5. Display the total by the overall total sum AND by dozens
 */

namespace Eggs;

class NumOfEggsInMonth
{
    public static void Main(string[] args)
    {
        // Declare four constant variables to represent four chickens
        const int chicken1 = 20;
        const int chicken2 = 20;
        const int chicken3 = 20;
        const int chicken4 = 67;

        // Declare a variable from summing the numbers together 
        int totalNumEggsInMonth = chicken1 + chicken2 + chicken3 + chicken4;

        // Declare a variable for the total in dozens
        int dozenNumEggsInMonth = totalNumEggsInMonth / 12;

        int remainderNumEggsInMonth = totalNumEggsInMonth % 12;

        Console.WriteLine("During the month, the four chickens produced a total of {0} eggs, which is {1} dozen and {2} eggs", totalNumEggsInMonth, dozenNumEggsInMonth, remainderNumEggsInMonth);
    }
}