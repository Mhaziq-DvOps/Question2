using System;

class Program
{
    static void Main()
    {
        // Ask user for height in centimeters and weight in kilograms
        Console.Write("Enter your height in centimeters (e.g., 175): ");
        float heightInCm = float.Parse(Console.ReadLine());

        Console.Write("Enter your weight in kilograms (e.g., 70): ");
        float weight = float.Parse(Console.ReadLine());

        // Convert height from centimeters to meters
        float heightInMeters = heightInCm / 100;

        // Calculate BMI
        float bmi = weight / (heightInMeters * heightInMeters);

        // Display BMI value
        Console.WriteLine($"Your BMI is: {bmi:F2}");

        // Determine the BMI category by first converting the BMI to a category
        int category = (bmi < 18.5) ? 1 :
            //if bmi is less than 18.5, if true, then it will show that it is in 1 condition,
            
                       (bmi < 24.9) ? 2 :
           // if bmi is less than 24.9, but the value is more than 18.5, if it true, then is will go to condition 2
                       (bmi < 30) ? 3 : 4;
        //if the choice is less than 30, but more than 24.9, it is considered as choice 3
        //if not sattified with choice 3, it will check in condition 4
        // Use switch case to output the corresponding category
        switch (category)
        {
            case 1:
                Console.WriteLine("You are underweight.");
                break;
            case 2:
                Console.WriteLine("You are in a healthy weight range.");
                break;
            case 3:
                Console.WriteLine("You are overweight.");
                break;
            case 4:
                Console.WriteLine("You are in the obesity range.");
                break;
            default:
                Console.WriteLine("Invalid BMI value.");
                break;
        }
    }
}
