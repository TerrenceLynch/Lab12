using System;

class CheckingAccount : BankAccount
    {
      public override void CalculateInterest()
      {
        decimal interest = (DateTime.Today.Year - DateCreated.Year) * (Convert.ToDecimal(.005)) * (Balance);
        Balance = Balance + interest;
        Console.WriteLine ("The intrest of $" + interest + " has been added.");
        Console.WriteLine("New balance is $" + Balance + "."); 
      }
      public override void Withdraw(decimal amount)
      {
        Console.WriteLine("The amount $" + amount + " was withdrawn.");
        base.Withdraw(amount);
         }
      
    }