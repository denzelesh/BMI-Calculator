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
        
        double weight;
        double height;

        if (unitChoice == 1)
        {
            //Imperial 
            // Imperial  Weight - (Stones)
            Console.WriteLine("Enter your weight in stones:");
            if (!double.TryParse(Console.ReadLine(), out double UserWeightStones))
            {
                //displays error if wrong data type is entered
                Console.WriteLine("Incorrect input");    
            }


            // Imperial Weight - (Pounds)
            Console.WriteLine("Enter your weight in pounds:");
            if (!double.TryParse(Console.ReadLine(), out double UserWeightPounds))
            {
                //displays error if wrong data type is entered
                Console.WriteLine("Incorrect input");
            }


            // Multiply by 14 to convert stones to pounds for accuracy
            weight = (UserWeightStones * 14) + UserWeightPounds; 

            // Imperial Height - (Feet)
            Console.WriteLine("Enter your height in feet:");
            if (!double.TryParse(Console.ReadLine(), out double UserHeightFeet))
            {
                //displays error if wrong data type is entered
                Console.WriteLine("Incorrect input");
            }

            // Imperial Height - (Inches)
            Console.WriteLine("Enter your height in inches:");
            if (!double.TryParse(Console.ReadLine(), out double UserHeightInches))
            {
                //displays error if wrong data type is entered
                Console.WriteLine("Incorrect input");
            }

            // Multiply by 12 to convert inches to feet for accuracy
            height = (UserHeightFeet * 12) + UserHeightInches;
            height = height * 0.0254; // convert to meters
        }
        else
        // Metric
        // Metric Weight - (Kilograms)
        {
            
            Console.WriteLine("Enter your weight in kilograms:");
            weight = Convert.ToDouble(Console.ReadLine());


        // Metric Height - (Kilograms)
            Console.WriteLine("Enter your height in meters:");
            height = Convert.ToDouble(Console.ReadLine());
        }

        // Determining BMI 
        double UserBMI = weight / (height * height);

        // Determining Weight Class
        if (UserBMI < Underweight)
        {
            string BMIname = "Underweight";
            Console.WriteLine("Your weight status is:  " + BMIname);
        }

        if (UserBMI > Underweight & UserBMI < Normal)
        {
            string BMIname = "Normal";
            Console.WriteLine("Your weight status is:  " + BMIname);
        }

        if (UserBMI > Normal & UserBMI < Overweight)
        {
            string BMIname = "Overweight";
            Console.WriteLine("Your weight status is:  " + BMIname);
        }

        if (UserBMI > Overweight & UserBMI < ObeseClass_1)
        {
            string BMIname = "Obese Class 1";
            Console.WriteLine("Your weight status is:  " + BMIname);
        }

        if (UserBMI > ObeseClass_1 & UserBMI < ObeseClass_2)
        {
            string BMIname = "Obese Class 2";
            Console.WriteLine("Your weight status is:  " + BMIname);
        }

        if (UserBMI >= ObeseClass_3)
        {
            string BMIname = "Obese Class 3";
            Console.WriteLine("Your weight status is:  " + BMIname);
        }


    }


    static void Main()  // runs the seperate methods  
    {
        AuthorName();
        CalculateBMI();

    }
}
