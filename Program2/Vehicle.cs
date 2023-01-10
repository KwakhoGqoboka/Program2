using System;
using System.Collections.Generic;
using System.Text;


namespace Program2
{
    // Inheritance
    class Vehicle: Calculations
    {
        // Declarations for the vehicle details
        public String VehicleMakeModel;
        public double Price;
        public double Deposit;
        public double yearInterestRate;
        public double yearInsurance;
        
        // Gets the infomation for the vehicle details
        public void vehicle()
        {
            Console.WriteLine("Please enter the following vehicle details:");
            //Exception handling for the user to input the correct infomation
            try
            {
                Console.WriteLine("Make and Model:");
                VehicleMakeModel = Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("Purchase price:");
                Price = Convert.ToDouble(Console.ReadLine());

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("Deposit:");
                Deposit = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("Yearly interest rate (5 years) %:");
                yearInterestRate = Convert.ToDouble(Console.ReadLine());

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("Monthly insurance premium:");
                yearInsurance = Convert.ToDouble(Console.ReadLine());

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            // A = P(1+in) this is the formula used to calculate home loan repayment
            // formula has been modified to return the monthly repayment

            double P = Price - Deposit;
            double A = P * (1 + (yearInterestRate / 100) * 5);
            double Final = A / 60;
            double PlusInsurance = Final + yearInsurance;
            Console.WriteLine("THE MONTHLY REPAYMENT FOR THE VEHICLE IS: R " + (PlusInsurance));  //calculating the monthly repayment 
            PlusInsurance = Expensesarray[7];
            double TotalExpense = Expensesarray[0] + Expensesarray[1] + Expensesarray[2]
               + Expensesarray[3] + Expensesarray[4] + Expensesarray[5] + Expensesarray[6];
            double SeventyFivePercent = 3 / 4 * GrossMonthlyIncome;
            // if statement states, if the total is expenses is greater then 75% the user has used more than 75% of their income
            if (TotalExpense > SeventyFivePercent)
            {
                DelegateMethod("you have used more than 75% of your income");
            }
            
            for (int x = 0; x < Expensesarray.Length; x++)
            {
                Console.WriteLine(Expensesarray[x]);
            }
          
        }
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(" The total expenses exceeds 75% of your income.");
        }
    }
    //Reference List
    //W3Schools(2019). W3Schools Online Web Tutorials. [online] W3schools.com.Available at: https://www.w3schools.com/.
    //Troelsen, A.and Japikse, P. (2021). Pro C# 9 with .NET 5 : foundational principles and practices in programming. Berkeley, Ca: Apress L. P., . Copyright.

}

