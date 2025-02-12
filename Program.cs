namespace Topic_4___Assignment_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) 


            string userFirstName, userLastName, month, city, provinceState, country, registerGivenName,
                registerLastName, courseCodeHomeroom, attendingSchool,
                streetName,
                addressCity,
                addressProvince,
                addressCountry,
                userEmail,
                applicationUsername,
                applicationPasscode, ageCalculatorName, groceryNameOne,
                groceryNameTwo;

            int userAge, year, dateNumber_1_31, fareClass, grade_9_12,
                studentId,
                streetNumber, ageCalculatorValue;

            double userSalary, studentAverage, firstNumber, secondNumber, thirdNumber, groceryPriceOne,
                groceryPriceTwo,
                pretotalGroceryPrice,
                subtotalGrocery,
                finalPrice; ;

            Console.WriteLine("Hello fair User! Welcome aboard the Elmington Express!");
            Console.WriteLine("Please enter your first and last name to get your boarding number!");
            Console.WriteLine();
            Console.WriteLine("Last Name: ");
            userLastName = Console.ReadLine();
            Console.WriteLine("First Name: ");
            userFirstName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome aboard " + userFirstName + " " + userLastName + "! Your boarding number is #004703");
            Console.WriteLine("Before you board, we need to ask you a couple of routine questions to verify our file.");

            Console.WriteLine();

            Console.WriteLine("Where is your desired destination of travel? Please capitalize.");
            Console.WriteLine();
            Console.WriteLine("City / Town: ");
            city = Console.ReadLine();
            Console.WriteLine("Province / State: ");
            provinceState = Console.ReadLine();
            Console.WriteLine("Country: ");
            country = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Thank you very much!");

            Console.WriteLine();

            Console.WriteLine("What is your requested date of travel? Please follow the directions below:");
            Console.WriteLine("Date Number between 1 and 31 (Do not include day name: ie monday, month or year): ");

            Int32.TryParse(Console.ReadLine(), out dateNumber_1_31);
            Console.WriteLine("Name of the Month");
            month = Console.ReadLine();
            Console.WriteLine("What is the desired year of travel?");
            Int32.TryParse(Console.ReadLine(), out year);

            Console.WriteLine();
            Console.WriteLine("What is your age as of 2025?");
            Int32.TryParse(Console.ReadLine(), out userAge);
            Console.WriteLine("Wow you are actually " + userAge + "! People look very young these days.");

            Console.WriteLine();

            Console.WriteLine("What is your desired fare? Type '1' for Business, '2' for Economy or any number for Escape: ");
            Int32.TryParse(Console.ReadLine(), out fareClass);

            Console.WriteLine("Finally, what was your yearly salary as of last year? We need to make sure you can afford this fare.");
            Console.WriteLine("Do not include commas or spaces");

            Double.TryParse(Console.ReadLine(), out userSalary);
            Console.WriteLine(userSalary.ToString("C") + " eh? Not bad! I see no reason why you cannot board the train.");
            Console.WriteLine();
            Console.WriteLine("Have a lovely trip!");
            Console.WriteLine("Here is your boarding pass:");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("========================================================");
            Console.WriteLine("User Details # 004703");
            Console.WriteLine();
            Console.WriteLine("Register Name     : " + userLastName + ", " + userFirstName);
            Console.WriteLine("Register Age      : " + userAge);
            Console.WriteLine("Register Salary   : " + userSalary.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Travel Details");
            Console.WriteLine();
            Console.WriteLine("Date of Departure : " + dateNumber_1_31 + ", " + month + ", " + year);
            Console.WriteLine("Destination       : " + city + ", " + provinceState + ", " + country);
            if (country == "Canada")
                Console.WriteLine("International     : No");
            else Console.WriteLine("International     : Yes");

            if (fareClass == 1)
                Console.WriteLine("Class Fare        : Business Class");
            else if (fareClass == 2)
                Console.WriteLine("Class Fare        : Economy Class");
            else Console.WriteLine("Class Fare       : Escape Class");
            Console.WriteLine();
            Console.WriteLine("========================================================");


            Console.WriteLine();
            Console.WriteLine();

            //2


            Console.WriteLine("Please Enter Your Information to Access the Board's Resource Databases");
            Console.WriteLine();
            Console.WriteLine("General Information: ");
            Console.WriteLine();
            Console.WriteLine("Enter Your Last Name:");
            registerLastName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter Your First Name:");
            registerGivenName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter Your School Email: ");
            userEmail = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter Your Set Password:");
            applicationPasscode = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("School Information:");
            Console.WriteLine();
            Console.WriteLine("Enter Your 9 Digit Student ID:");
            Int32.TryParse(Console.ReadLine(), out studentId);
            Console.WriteLine("Enter Your Grade Number (9 - 12):");
            Int32.TryParse(Console.ReadLine(), out grade_9_12);
            Console.WriteLine("Enter Your Overall Average (Do not include %)");
            Double.TryParse(Console.ReadLine(), out studentAverage);
            studentAverage = Math.Round(studentAverage, 2);
            Console.WriteLine("Enter Your Current Attending School:");
            attendingSchool = Console.ReadLine();
            Console.WriteLine("Enter Your Homeroom Course Code:");
            courseCodeHomeroom = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("Enter Your Address:");
            Console.WriteLine();
            Console.WriteLine("Street Number:");
            Int32.TryParse(Console.ReadLine(), out streetNumber);
            Console.WriteLine("Street Name:");
            streetName = Console.ReadLine();
            Console.WriteLine("City / Town:");
            addressCity = Console.ReadLine();
            Console.WriteLine("Province / State:");
            addressProvince = Console.ReadLine();
            Console.WriteLine("Country:");
            addressCountry = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("========================================================");
            Console.WriteLine("Your Entered Information");
            Console.WriteLine("General Identification");
            Console.WriteLine();
            Console.WriteLine("Name \t\t\t" + ": " + registerLastName + ", " + registerGivenName);
            Console.WriteLine("Email \t\t\t" + ": " + userEmail);
            Console.WriteLine("Password \t\t" + ": " + applicationPasscode);
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("School Identification");
            Console.WriteLine();
            Console.WriteLine("Student ID \t\t" + ": " + studentId);
            Console.WriteLine("Grade (9-12) \t\t" + ": " + grade_9_12);
            Console.WriteLine("Student Average \t" + ": " + studentAverage + " %");
            Console.WriteLine("Attending School \t" + ": " + attendingSchool);
            Console.WriteLine("Homeroom Course Code \t" + ": " + courseCodeHomeroom);
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Home Address \t\t" + ": " + streetNumber + ", " + streetName);
            Console.WriteLine("\t\t\t" + "  " + addressCity + ", " + addressProvince + ", " + addressCountry);
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();
            Console.WriteLine();

            //3)
            

            Console.WriteLine("~~~ Welcome to the Age Name Number Game ~~~");
            Console.WriteLine("Please enter your name to find out how old you were 5 years ago,");
            Console.WriteLine("and how old you'll be in 5 more years with ease!");

            ageCalculatorName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Nice to meet you, " + (ageCalculatorName) + "!");
            Console.WriteLine("How old are you!");
            Int32.TryParse(Console.ReadLine(), out ageCalculatorValue);
            Console.WriteLine(ageCalculatorName + ", 5 years ago, you were " + (ageCalculatorValue - 5) + ".");
            Console.WriteLine("And in five more years, you will be " + (ageCalculatorValue + 5) + ".");

            Console.WriteLine();
            Console.WriteLine();


            //4)

            
            Console.WriteLine("Please Enter a Number!");
            Double.TryParse((Console.ReadLine()), out firstNumber);
            Console.WriteLine("Please Enter Another Number!");
            Double.TryParse((Console.ReadLine()), out secondNumber);
            Console.WriteLine("Please Enter a Third Number!");
            Double.TryParse((Console.ReadLine()), out thirdNumber);

            Console.WriteLine("The sum of the numbers divided by two is as follows:");
            Console.WriteLine((firstNumber + secondNumber + thirdNumber) / 2 + ".");


            Console.WriteLine();
            Console.WriteLine();

            //5) 

                   

            Console.WriteLine("Welcome to Foodland! Canada's Favourite Grocery Chain!");
            Console.WriteLine("You have 2 item(s) in the cart");
            Console.WriteLine("Please enter the name of the first item.");
            groceryNameOne = Console.ReadLine();
            Console.WriteLine("Please enter the price of the first item. (Do not include $)");
            Double.TryParse((Console.ReadLine()), out groceryPriceOne);
            Console.WriteLine("Please enter the name of the second item.");
            groceryNameTwo = Console.ReadLine();
            Console.WriteLine("Please enter the price of the second item. (Do not include $)");
            Double.TryParse((Console.ReadLine()), out groceryPriceTwo);
            Console.WriteLine("Congratulations! Your items have a 20% Discound.");
            Console.WriteLine();
            Console.WriteLine("Below is your sales recipt:");
            Console.WriteLine();

            pretotalGroceryPrice = (groceryPriceOne + groceryPriceTwo);
            subtotalGrocery = Math.Round(((pretotalGroceryPrice - (pretotalGroceryPrice * 0.20))), 2);
            Console.WriteLine();
            Console.WriteLine("Sales Recipt");
            Console.WriteLine("===================================");
            Console.WriteLine("Item One  :" + "\t" + " " + groceryNameOne);                
            Console.WriteLine("Price     :" + "\t" + " " + (Math.Round(groceryPriceOne, 2).ToString("C")));
            Console.WriteLine("Item Two  :" + "\t" + " " + groceryNameTwo);
            Console.WriteLine("Price     :" + "\t" + " " + (Math.Round(groceryPriceTwo, 2).ToString("C")));
            Console.WriteLine("===================================");
            Console.WriteLine("Total     :" + "\t" + " " + pretotalGroceryPrice.ToString("C"));
            Console.WriteLine("Discount  :" + "\t" + "-" + (Math.Round(((pretotalGroceryPrice) * 0.20), 2)).ToString("C"));
            Console.WriteLine("Subtotal  :" + "\t" + " " + subtotalGrocery);
            Console.WriteLine("Taxes     :" + "\t" + " " + (Math.Round((subtotalGrocery * 0.13), 2).ToString("C")));
            Console.WriteLine("===================================");
            Console.WriteLine("Total Owed:" + "\t" + " " + (Math.Round((subtotalGrocery * 1.13), 2).ToString("C")));
            Console.ReadLine();


        }
    }
}
