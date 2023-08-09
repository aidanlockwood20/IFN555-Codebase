/*
 1. User enters a number high school GPA (float value) and a test score (int value)
 2. Check for the following:
    a) GPA is higher tham 3 and admission test score greater than 60
    b) GPA is higher than 3 and admission test score greater than 80
 3. If EITHER of these statements are correct, display Accept
 4. ELSE display Reject
 */

namespace Admission;

class Program
{
    static void Main(string[] args)
    {
        string GPAValueInput;
        float GPAValue;

        string admissionTestScoreInput;
        int admissionTestScore;


        Console.WriteLine("Please enter a GPA:");

        GPAValueInput = Console.ReadLine();
        GPAValue = float.Parse(GPAValueInput);

        Console.WriteLine("Please enter an admission test score:");

        admissionTestScoreInput = Console.ReadLine();
        admissionTestScore = int.Parse(admissionTestScoreInput);

        if (((GPAValue > 3) && (admissionTestScore >= 60)) || ((GPAValue < 3) && (admissionTestScore >= 80)))
        {
            Console.WriteLine("Accept");
        }
        else
        {
            Console.WriteLine("Reject");
        }

    }
}

