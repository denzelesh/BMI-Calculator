class BMIapp
{
    // WHO <- BMI Ratings
    const double Underweight = 18.50;
    const double Normal = 24.90;
    const double Overweight = 29.90;
    const double ObeseClass_1 = 34.90;
    const double ObeseClass_2 = 39.90;
    const double ObeseClass_3 = 40.00;


    static void AuthorName()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("   App 02 - BMI Calculator");
        Console.WriteLine("         By Denzel Eshun");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("   This application will calculate");
        Console.WriteLine("     your basal metabolic rate");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(" "); // Message for BAME Groups
        Console.WriteLine("For BAME groups, due genetic ");
        Console.WriteLine("differences in the distribution");
        Console.WriteLine("of body fat, BMI is typically ");
        Console.WriteLine("not an accurate representation of");
        Console.WriteLine("one's weight class, therefore these");
        Console.WriteLine("results should be taken with caution.");
        Console.WriteLine(" ");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(" ");
    }
    
    static void CalculateBMI()
    {
        Console.WriteLine("Choose your preferred units of measurement:");
        Console.WriteLine("1. Imperial Units");
        Console.WriteLine("2. Metric Units");
        
        int unitChoice; // Variable Declaration

         // Adds a parse to check and make sure correct data type has been entred
        if (!int.TryParse(Console.ReadLine(), out unitChoice))
        {
            //Displays error message if an incorrect conversion...
            //...option is chosen
            Console.WriteLine("Incorrect input");
            return;
        }

    }


    static void Main()  
    {
        AuthorName();
        CalculateBMI();

    }
}
