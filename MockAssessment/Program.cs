using System;

namespace MockAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note to self: REMEMBER ORDER OF OPERATIONS
            //Add in validation since Nick will likely try to break it.
            string userInput = "";
            int sameCheckOne = -1;
            int sameCheckTwo = -1;
            
            Console.Write("Please enter in a number: ");
            userInput = Console.ReadLine();
            sameCheckOne = int.Parse(userInput);

            Console.Write("Please enter in a second number: ");
            userInput = Console.ReadLine();
            sameCheckTwo = int.Parse(userInput);

            bool theSameResults = IsTheSame(sameCheckOne, sameCheckTwo);
           
            double numDifference1 = -1;
            double numDifference2 = -1;
            double subtractNumber1 = -1;
            double subtractNumber2 = -1;
            
            Console.Write("Enter in two numbers to see the difference! Let's start with the first number: ");
            string numDifferenceResult = Console.ReadLine();
            numDifference1 = double.Parse(numDifferenceResult);
            numDifference1 = Math.Round(numDifference1, 2);

            Console.Write("Enter in another number!: ");
            numDifferenceResult = Console.ReadLine();
            numDifference2 = double.Parse(numDifferenceResult);
            numDifference2 = Math.Round(numDifference2, 2);
            double differenceUserInput = Subtract(subtractNumber1, subtractNumber2);

            int buildingCheck = -1;
            string buildingValue = "";
            Console.Write("Enter in a number to see what type of building it is!: ");
            buildingValue = Console.ReadLine();
            buildingCheck = int.Parse(buildingValue);
            string buildingReturn = FindBuildingType(buildingCheck);
            Console.WriteLine(buildingReturn);

            Console.ReadKey();
        }

        //IsTheSame() - static method, returns a bool. Two ints as parameters. If Num1 = Num2 return true, if not return false
        public static bool IsTheSame(int sameCheckOne, int sameCheckTwo)
        {
            return sameCheckOne == sameCheckTwo;
        }

        //Subtract() - static method, double as the type it takes in. Returns the difference between num1 and num2.num2 - num1 is the difference they're looking for.
        public static double Subtract(double numDifferenceOne, double numDifferenceTwo)
        {
            return numDifferenceTwo - numDifferenceOne; 
        }

        //FindBuildingType() static method public. Takes int as a parameter and returns a string (out). 
        public static string FindBuildingType(int buildingInput)
        {
            //If the number is between 4 and 10, return “This is an office building!”
            if (buildingInput >= 4 || buildingInput <= 10)
            {
                return "This is an office building!";
            }
            //If the number is less than 3, return “This is a house!”
            else if (buildingInput < 3)
            {
                return "This is a house!";
            }
            //If a number is between 11 and 49, return “This is a skyscraper!”
            else if (buildingInput >= 11 || buildingInput <= 49)
            {
                return "This is a skyscraper!";
            }
            //If the number is over 50, return “This is a SUPER skyscraper!”
            else
            {
                return "This is a SUPER skyscraper!";
            }
        }

    }


}


