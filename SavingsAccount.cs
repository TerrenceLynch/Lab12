using System;

class SavingsAccount : BankAccount
    {
      public override void CalculateInterest() 
      { 
        decimal interest = (DateTime.Today.Year - DateCreated.Year) * (Convert.ToDecimal(.05)) * (Balance);
        Balance = Balance + interest;
        Console.WriteLine ("The intrest of $" + interest + " has been added.");
        Console.WriteLine("New balance is $" + Balance + ".");         
      }
      public override void Withdraw(decimal amount)
      {
        if (Balance < 2000)
        {Console.WriteLine("The Balance is insufficient.");}
        else 
        {
          Console.WriteLine("The amount $" + amount + " was withdrawn.");
          base.Withdraw(amount);
        }

      }

      
    }