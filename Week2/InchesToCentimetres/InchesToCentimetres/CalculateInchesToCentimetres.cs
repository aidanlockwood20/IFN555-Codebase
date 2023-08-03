/*variables:
 * centimetres in an inch (constant)
 * ourMeasurement (double)
 * 
 * Steps in code: 
 * 1. Declare constant variable - CENTIMETRES_IN_INCH
 * 2. Declare our measurement variable (ourMeasurement)
 * 3. Convert ourMeasurement to Centimetres
 * 4. Display measurements to the console
 */

namespace InchesToCentimetres;

public class CalculateInchesToCentimetres
{
    public static void Main(string[] args)
    {
        // Declare constant variable - CENTIMETRES_IN_INCH
        const double CENTIMETRES_IN_INCH = 2.54;

        // Declare our measurement variable (ourMeasurement)
        double inchesValue = 3.0;

        // Convert ourMeasurement to Centimetres
        double numOfCentimetresInInches = CENTIMETRES_IN_INCH * inchesValue;

        // Display measurements to the console
        Console.WriteLine("In {0} inches, there are {1} centimetres", inchesValue, numOfCentimetresInInches);
    }
}