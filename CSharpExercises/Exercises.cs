using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello()
        {
            Console.WriteLine("Enter First Name");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Hello "+nameInput);
            return "Hello"+ nameInput;  
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum()
        {
            Console.WriteLine("Enter a number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstNumber + secondNumber);

            return firstNumber + secondNumber;

        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide()
        {
            Console.WriteLine("Enter a number");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter a number");
            string secondString = Console.ReadLine();

            decimal decimalOne = decimal.Parse(firstString);
            decimal decimalTwo = decimal.Parse(secondString);
            Console.WriteLine(decimalOne / decimalTwo);

            return decimalOne / decimalTwo;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount()
        {
            Console.WriteLine("Enter an age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                return true;
            } else
            {
                return false;
            }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName()
        {
            Console.WriteLine("Enter a first and last name");
            string name = Console.ReadLine();
            Console.WriteLine(name.Split(' ').First());
            return name.Split(' ').First();
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard()
        {
            Console.WriteLine("Enter a string to reverse hard");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            foreach(char ch in name)
            {
                reverse = ch + reverse;
            }
            Console.WriteLine(reverse);
            return name;

        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy()
        {
            Console.WriteLine("Enter a string to reverse easy");
            string name = Console.ReadLine();

            string reversedName = new string(name.Reverse().ToArray());
            Console.WriteLine(reversedName);

            return reversedName;
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */

        public static string PrintTimesTable()
        {
            Console.WriteLine("Enter a number to be multiplied 10 times");

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(number*i);
            }

            return number.ToString();
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.

        public static double ConvertKelvinToFahrenheit()
        {
            double enteredTempK = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((enteredTempK - 273.15)*1.8000+32.00);
            return enteredTempK;
        }

        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)

        public static double GetAverageHard()
        {

            int[] numbers = new int [7];

            for(int i = 0; i < 7; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }

            double result = numbers.Sum() / numbers.Length;
            Console.WriteLine(result);

            

            return result;
        }

        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)

        public static double GetAverageEasy()
        {
            int[] numbers = new int[7];
            for (int i = 0; i < 7; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }

            double average= numbers.Average();
            Console.WriteLine(average);
            return average;

        }

        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */

        public static string DrawTriangle()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());

            string numberToString = Convert.ToString(number);
           
            while (width > 0)
            {
                string result = new String((char)number, width);
                Console.WriteLine(result);
                width--;
            }
            return numberToString;
        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")

        public static string GetMilesPerHour()
        {
            Console.WriteLine("Enter distance in miles");
            double miles = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter hours");
           int hours = Convert.ToInt32(Console.ReadLine());
            int hoursInSeconds = hours * 3600;

            Console.WriteLine("Enter minutes");
            int minutes = Convert.ToInt32(Console.ReadLine());
            int minutesInSeconds = minutes * 60;

            Console.WriteLine("Enter seconds");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int totalSeconds = hoursInSeconds + minutesInSeconds + seconds;
            Console.WriteLine(totalSeconds);
            //200 2 30 45 80
            string returnString = (Math.Ceiling((miles / totalSeconds) * 3600))+"MPH";
            Console.WriteLine(returnString);
            return returnString;
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.

        public static bool IsVowel()
        {
            char check = Convert.ToChar(Console.ReadLine());

            bool isV = "aeiouAEIOU".IndexOf(check) >= 0;
            Console.WriteLine(isV);
            return isV;
        }

        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.

        public static bool IsConsonant()
        {
            char check = Convert.ToChar(Console.ReadLine());

            bool isC = "aeiouAEIOU".IndexOf(check) >= 0;
            isC = !isC;
            Console.WriteLine(isC);
            return isC;
        }

        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.

        public static int CollatzConjecture()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    //even
                    n = n / 2;
                }
                else
                {
                    //odd
                    n = (n * 3) + 1;
                }
                Console.WriteLine(n);
            }

                return n;
            

        }

        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).

        public static DateTime[] GetNext7Days()
        {

            DateTime today = DateTime.Today;
            //int daysUntil = (((int)DayOfWeek.Friday - (int)today.DayOfWeek + 7) % 7) + 1;

            DateTime[] timeArray = new DateTime[7];
            for(int i = 0; i < 7; i++)
            {
                DateTime day = today.AddDays(i);
                //timeArray[i] = new DateTime(i);
                //Console.WriteLine(today.AddDays(i));
                timeArray[i] = today.AddDays(i);
                Console.WriteLine(today.AddDays(i));
            }
            Console.WriteLine(timeArray);
            return timeArray;
        }

        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)

        public static bool IsLeapYear()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if(DateTime.IsLeapYear(year))
            {
                return true;
            } else
            {
                return false;
            }
            
        }

        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */

        public static decimal MortgageCalculator()
        {
            Console.WriteLine("Loan");
            string loanString = Console.ReadLine();

            Console.WriteLine("interest");
            string interestString = Console.ReadLine();

            decimal loanDecimal = decimal.Parse(loanString);
            decimal interestDecimal = decimal.Parse(interestString);

            Console.WriteLine("loanterm");
            int loanTermInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("paymentperiod");
            int paymentPeriod = Convert.ToInt32(Console.ReadLine());


            decimal monthlyInterestRate = (interestDecimal / (decimal)100.0) / paymentPeriod;

            int numberOfPayments = loanTermInt * paymentPeriod;
           
            double compoundedInterestRate = Math.Pow((1+(double)monthlyInterestRate), numberOfPayments);
            

            decimal interestQuotient = (monthlyInterestRate * (decimal)compoundedInterestRate) / ((decimal)compoundedInterestRate - 1);

            decimal monthlyPayment = loanDecimal * interestQuotient;

            Console.WriteLine(monthlyInterestRate + "," + numberOfPayments + "," + compoundedInterestRate + "," + interestQuotient + "," + monthlyPayment);
            Console.WriteLine(Math.Round(monthlyPayment,2));
            return Math.Round(monthlyPayment, 2);
        }


        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        public static string DuckGoose()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("DuckGoose");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Duck");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine("Goose");
                }else
                {
                    Console.WriteLine(i);
                }

            }
            return "HI";
        }
       

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}