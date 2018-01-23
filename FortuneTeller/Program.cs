using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // initial greeting
            Console.WriteLine("Hello, welcome to the fortune teller program.");
            Console.WriteLine("To find out your future, I will ask you a series of questions.");
            
            // user input
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("In what month were you born? Please enter a numerical value only.");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type your favorite color from ROYGBIV or type \"help\" for more options.");
            string favoriteColor = Console.ReadLine().ToLower();
            if (favoriteColor.ToLower().Contains("help")){
                Console.WriteLine("ROYGBIV stands for red, orange, yellow, green, blue, indigo, violet.");
                Console.WriteLine("What is your favorite color from these choices?");
                favoriteColor = Console.ReadLine().ToLower();
            }
            favoriteColor = favoriteColor.ToLower();
            Console.WriteLine("How many siblings do you have? Please enter a numerical value only.");
            int siblingNumber = int.Parse(Console.ReadLine());

            // retirement age calculation based on whether age is even or odd
            int ageDeterminant = (age % 2); // finding out if age is even or odd
            int yearsToRetirement = 0;
            
            if (ageDeterminant == 0)
            {
                yearsToRetirement = 35;
            }
            else if ((ageDeterminant > 0) || (ageDeterminant < 0))
            {
                yearsToRetirement = 25;
            }

            // vacation home determination based on number of siblings
            string vacationHomeDestination =""; // Middle Earth locations

            if (siblingNumber > 3) // I really should have used a switch statement because this is so messy!
            {
                vacationHomeDestination = ("Fangorn Forest");
            }
            else if (siblingNumber == 3)
            {
                vacationHomeDestination = ("Helms Deep");
            }
            else if (siblingNumber == 2)
            {
                vacationHomeDestination = ("Gondor");
            }
            else if (siblingNumber == 1)
            {
                vacationHomeDestination = ("Rivendell");
            }
            else if (siblingNumber == 0)
            {
                vacationHomeDestination = ("Isengard");
            }
            else if (siblingNumber < 0)
            {
                vacationHomeDestination = ("Mordor");
            }

            // mode of transportation based on ROYGBIV selection
            string modeOfTransportation =""; 
            // 7 choices: horse, nazgul, eagle, oliphaunts, warg, shadowfax, boat

            switch (favoriteColor)
            {
                case "red":
                    modeOfTransportation = "horse";
                    break;
                case "orange":
                    modeOfTransportation = "nazgul";
                    break;
                case "yellow":
                    modeOfTransportation = "eagle";
                    break;
                case "green":
                    modeOfTransportation = "oliphaunt";
                    break;
                case "blue":
                    modeOfTransportation = "warg";
                    break;
                case "indigo":
                    modeOfTransportation = "Shadowfax";
                    break;
                case "violet":
                    modeOfTransportation = "boat";
                    break;
                default:
                    modeOfTransportation = "pair of boots";
                    break;
            }

            // amount of money based on birth month
            // 1 - 4, 5 - 8, 9 - 12, 0 or less than 0 
            int retirementMoney = 0; 

            if ((birthMonth <1) || (birthMonth > 12))
            {
                retirementMoney = 0;
            }
            else if ((birthMonth >=1) && (birthMonth <=4))
            {
                retirementMoney = 30000;
            }
            else if ((birthMonth >=5) && (birthMonth <= 8))
            {
                retirementMoney = 40000;
            }
            else if ((birthMonth >=9) && (birthMonth <= 12))
            {
                retirementMoney = 50000;
            }

            // fortune output

            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsToRetirement + " years with $"+ retirementMoney + " in the bank, a vacation home in "+ vacationHomeDestination + " and a " + modeOfTransportation + ".");

        
        }
    }
}
