/*
 1. Prompt user to enter an uppercase letter and that an ! will exit the program
 2. Initialise user input string
 3. Initialise user input convert to character string
 3. Start while loop, checking that the user input is not !
 4. Run a check on the letter to see if it is uppercase or not
 5. If the check returns valid, display OK
 6. If the check returns false, display an error message
 */

namespace EnterUpperLetters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an uppercase letter. An ! will close the program");

        string userInput = "";

        char userCharInput;

        while (userInput != "!")
        {
            userInput = Console.ReadLine();
            userCharInput = char.Parse(userInput);

            if (char.IsUpper(userCharInput)){
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Error: Character input is not uppercase");
            }
        }
    }
}

