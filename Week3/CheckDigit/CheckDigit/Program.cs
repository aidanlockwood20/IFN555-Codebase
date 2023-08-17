/*
 1. initialise the userInput, the number coming from the input, and a number containing the first three digits of the number
 1. Prompt User to enter a 4 digit code
 2. Check the length of the code and that all characters are numbers
 3. If the input is long enough and no letters are found, run step 5
 4. If input has letters or is not long enough, display error message
 5. Complete a modulus calculation on the first three digits
 */

namespace CheckDigit;

class Program
{
    static void Main(string[] args)
    {
        string userInputNumber;
        int userNumber;

        string userInputThreeDigit;
        int userThreeDigit;

        string userInputLastDigit;
        int userLastDigit;


        const int VALID_CHECK = 7;
        int modulusCalculation;


        Console.WriteLine("Enter a 4 digit code");

        userInputNumber = Console.ReadLine();
        userNumber = int.Parse(userInputNumber);

 

        if (userInputNumber.Length == 4)
        {
            userInputThreeDigit = userInputNumber.Substring(0, 3);
            userThreeDigit = int.Parse(userInputThreeDigit);

            userInputLastDigit = userInputNumber.Substring(3, 1);
            userLastDigit = int.Parse(userInputLastDigit);

            modulusCalculation = userThreeDigit % VALID_CHECK;

            Console.WriteLine("The result of the modulus calculation is {0}", modulusCalculation);

            if (userLastDigit == modulusCalculation)
            {
                Console.WriteLine("The number input is valid");
            }
            else
            {
                Console.WriteLine("Error: The number input is invalid");
            }
        }
    }
}

