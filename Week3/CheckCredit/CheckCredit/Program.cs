/*
 1. Prompt user to enter an item's purchase price
 2. Convert the input to an integer
 3. Check for if it is greater than $8,000 (or less than 0)
 4. If it is true, Display Approved
 5. If false, Show error message and try again
*/

namespace CheckCredit;

class Program
{
    static void Main(string[] args)
    {
        string userInputPurchasePrice;
        double purchasePrice;
        const double CREDIT_LIMIT = 8000;

        Console.WriteLine("Enter an item's purchase price ($)");

        userInputPurchasePrice = Console.ReadLine();

        purchasePrice = double.Parse(userInputPurchasePrice);

        if (purchasePrice < CREDIT_LIMIT)
        {
            if (purchasePrice < 0)
            {
                Console.WriteLine("Error: Cannot have negative value for price");
                return;
            }

            Console.WriteLine("APPROVED");
        }
        if ((purchasePrice > CREDIT_LIMIT))
        {
            Console.WriteLine("Error: The purchase price for the item is over the credit limit");
        }
    }
}

