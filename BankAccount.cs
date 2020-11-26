 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount()
        {
            Balance = 1000;
        }

         public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("The amount $" + amount + " has been deposited.");
            Console.WriteLine("The current balance is $" + Balance + ".");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (Balance > amount)
            {Balance = Balance - amount;}
            else
            {Console.WriteLine("There was an error.");}
            Console.WriteLine("The current balance is $" + Balance + ".");
        }
        public abstract void CalculateInterest();

    }