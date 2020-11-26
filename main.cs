using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    /*Write code to implement the test cases below*/

            /*Test case 1
             * Create a savingsaccount object
             * Deposit $2000
             * Withdraw $5000
             * Calculate interest
             * Withdraw $500
            */
            SavingsAccount t1 = new SavingsAccount();
            t1.DateCreated = Convert.ToDateTime("11/20/2005");
            t1.Deposit(2000);
            t1.Withdraw(5000);
            t1.CalculateInterest();
            t1.Withdraw(500);
            /*Test case 2
            * Create a checkingaccount object
            * Deposit $2000
            * Withdraw $5000
            * Calculate interest
            * Withdraw $500
           */
           CheckingAccount t2 = new CheckingAccount();
           t2.DateCreated = Convert.ToDateTime("11/20/2004");
           t2.Deposit(2000);
           t2.Withdraw(5000);
           t2.CalculateInterest();
           t2.Withdraw(500);
  }
}