/*
 * Steps to code: 
 * 1. Declare constants subtractFromFahrenheit and multiplyForCelsius
 * 2. Ask for Fahrenheit value from the user
 * 3. Convert the value to a floating point number
 * 4. Calculate the Celsius Result
 * 5. Display the result in both Fahrenheit (initial value) and Celsius 
 */

namespace FahrenheitToCelsius;

class Program
{
    static void Main(string[] args)
    {
        // Declare constants subtractFromFahrenheit and multiplyForCelsius
        const double subtractFromFahrenheit = 32;

        // Ask for Fahrenheit value from the user
        Console.WriteLine("What is the temperature (in Fahrenheit) that you wish to convert to Celsius?");
        string fahrenheitValueUserInput = Console.ReadLine();

        // Convert the value to a floating point number
        double fahrenheitValue = double.Parse(fahrenheitValueUserInput);

        Console.WriteLine("");
        // Calculate the Celsius Result
        double calculateCelsiusValue = ((fahrenheitValue - subtractFromFahrenheit) * 5) / 9;

        // NOTE: Math returns a double type value 
        calculateCelsiusValue = Math.Round(calculateCelsiusValue, 1);

        // Display the result in both Fahrenheit (initial value) and Celsius
        Console.WriteLine("A Temperature of {0} Fahrenheit equates to {1} Celsius", fahrenheitValue, calculateCelsiusValue);
    }
}

