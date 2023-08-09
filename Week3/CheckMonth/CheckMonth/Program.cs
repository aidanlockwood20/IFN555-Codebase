/*
 1. Prompt user to input a birth month
 2. Check the value is between 1 and 12
 3. If the value is not within the range, display error message
 4. If the value is within the range, state the value is a valid month
 */

namespace CheckMonth;

class Program
{
    static void Main(string[] args)
    {

        string birthMonthString;
        int birthMonth;
        bool invalidMonth = true;

        while (invalidMonth)
        {
            Console.WriteLine("Please enter your birth month");
            birthMonthString = Console.ReadLine();

            birthMonth = int.Parse(birthMonthString);

            if ((birthMonth > 1) && (birthMonth < 12))
            {
                Console.WriteLine("{0} is a valid month");
                invalidMonth = false;
            }
            else
            {
                Console.WriteLine("Error: the input is an invalid month");
            }
        }
    }
}

