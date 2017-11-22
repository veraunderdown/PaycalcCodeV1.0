using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaycalcCodeV1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // v 1.0 - with realistic tax deductions and meal card
            // 
            //Declare variables
            int payRate;
            int totalHours;
            int netPay;
            int grossPay;
            int deductions;
            int tax;
            int mealCard;
            int jobRole;


            Console.WriteLine("Welcome to the pay calculator" + System.Environment.NewLine);

            Console.WriteLine("Please enter the code for your job role:\n1 for Cleaner, 2 for Graduate Clerk, 3 for Senior Clerk");
            jobRole = int.Parse(Console.ReadLine());

            switch (jobRole)
            {
                case 1:
                    Console.Write("Your job role is: Cleaner\n");
                    payRate = 700;
                    break;
                case 2:
                    Console.Write("Your job role is: Graduate Clerk\n");
                    payRate = 1125;
                    break;
                case 3:
                    Console.Write("Your job role is: Senior Clerk\n");
                    payRate = 1780;
                    break;
                default:
                    Console.Write("Code not known. Please enter a valid code\n");
                    payRate = 0;
                    break;

            }

            Console.WriteLine("Please enter in the number of hours that you have worked");
            totalHours = int.Parse(Console.ReadLine());

            grossPay = payRate * totalHours;
            

            //Test amount earnt and make tax deductions and rounddown to two decimal places
            if (grossPay < 20000)
            {
                tax = grossPay / 10;
            }
            else
            {
                tax = (20000 / 10) + (grossPay - 20000) / 4;
            }

            deductions = tax;

            if ((grossPay - tax - 1000) / totalHours > 500)
            {
                //eligible for meal card 
                Console.WriteLine("Would you like a meal card? Enter 1 for yes, 0 for no");
                mealCard = int.Parse(Console.ReadLine());
                if (mealCard == 1)
                {
                    Console.WriteLine("Meal Card Selected");
                    deductions = deductions + 1000;
                }
                else
                {
                    Console.WriteLine("Meal Card not selected");
                }
            }


            netPay = grossPay - deductions;

            //Output
            Console.WriteLine("Total; " + netPay.ToString());

            //Pause the program
            Console.ReadLine();

        }
    }
}
