using System;
using System.Collections.Generic;
using System.Text;

namespace Program2
{
    //Inheritance
    class Calculations: Expenses
    {
        //Declarations
        //Array containing expenses
        public double[] Expensesarray = new double[8];
        public static int Groceries = 0;
        public static int Utilities = 0;
        public static int TravelCosts = 0;
        public static int CellphoneandTelephone = 0;
        public static int OtherExpenses = 0;
        public static int Rent = 0;
        public static int GrossMonthlyIncome = 0;
        public static int Deductions = 0;
        public int MonthlyExpenses = 0;

        //Gets the infomation for the expenses for the home loan
        public void Expense()
        {

            Console.WriteLine("Please enter the following monthly requirements:");
            //Exception handling for the user to input the correct infomation
            try 
            {
                Console.WriteLine("a) gross monthly income(before deductions):");
                GrossMonthlyIncome = Convert.ToInt32(Console.ReadLine());
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("b) estimated tax deducted:");
                Deductions = Convert.ToInt32(Console.ReadLine());
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("c) (expense) groceries:");
                Groceries = Convert.ToInt32(Console.ReadLine());
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("d) (expense) utilities:");
                Utilities = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("e) (expense) travel costs:");
                TravelCosts = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("f) (expense) cell phone and telephone:");
                CellphoneandTelephone = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("g) (expense) other monthly expenses:");
                MonthlyExpenses = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        Start:
            try
            {
                
                for (int x = 0; x < Expensesarray.Length; x++)
                {
                    // arrays for the expenses
                    Expensesarray[0] = GrossMonthlyIncome;
                    Expensesarray[1] = Deductions;
                    Expensesarray[2] = Groceries;
                    Expensesarray[3] = Utilities;
                    Expensesarray[4] = CellphoneandTelephone;
                    Expensesarray[5] = TravelCosts;
                    Expensesarray[6] = MonthlyExpenses;
                }

            }
            // catch method to return the array
            catch (IndexOutOfRangeException e)
            {
                goto Start;
            }
        }

        // Infomation for the home loan
        public static void Home()
        {
            //Declarations for the price, deposit, interest rate and the repayment
            double price = 0;
            double deposit = 0;
            double yearInterestRate = 0;
            double yearRepayment = 0;

            
            Console.WriteLine("Would you like to BUY (1), RENT (2) a property");
            Console.WriteLine("Please input (1) or (2) ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // if statement so the user can determine their preference between BUY and RENT
            if (choice == 2)
            {
                Console.WriteLine("Please enter the monthly rental amount:");
                Rent = Convert.ToInt32(Console.ReadLine());

            }
            else if (choice == 1)
            {
                try
                {
                    Console.WriteLine("Please enter the purchase price:");
                    price = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Please enter the deposit:");
                deposit = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine("Please enter the interest rate:");
                    yearInterestRate = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    Console.WriteLine("Please enter the repayment:");
                    yearRepayment = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                //Calculations for the Home Loan if you decide to buy
                double P = price - deposit;
                double n = yearRepayment / 12;
                double A = P * (1 + (yearInterestRate / 100) * n);
                double MonthlyPrice = A / yearRepayment;
                Console.WriteLine("The monthly price of the house is: R " + MonthlyPrice);
                double Third = (1 / 3) * GrossMonthlyIncome;

                // If statement states if the Monthly income is greater than the third of the monthly income the house will not be approved
                if (MonthlyPrice > Third)
                {
                    Console.WriteLine("APPROVAL OF THE HOME LOAN IS UNLIKELY");
                }

            }

        }

        //override method for the base class Home() and Expense()
        public override void HomeLoan()
        {
        Beginning:
            Expense();
            Home();
            //The calculation for the balance
            double Balance = GrossMonthlyIncome - Expensesarray[7];
            //If statement to state the decision of the balance if it is more than the income or to to show it after expenses
            if (Balance < 0)
            {
                Console.WriteLine("The expenses are more than the income");
            }
            else
            {
                Console.WriteLine("Balance after all the expenses " + Balance);
            }

            
            Console.WriteLine("Would you like to start again (Yes) or input (NO) to continue to Vehicle? ");
            String start = Console.ReadLine();
            if (start == "yes")
            {
                goto Beginning;
            }

        }
    }

    //Reference List
    //W3Schools(2019). W3Schools Online Web Tutorials. [online] W3schools.com.Available at: https://www.w3schools.com/.
    //Troelsen, A.and Japikse, P. (2021). Pro C# 9 with .NET 5 : foundational principles and practices in programming. Berkeley, Ca: Apress L. P., . Copyright.
}

